using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;
using System.Reflection;
using System.Globalization;

namespace SensorVisualizer
{
    public partial class MainWindow : Form
    {
        private SerialConnection serialConnection;
        private System.Windows.Forms.Timer portTimer;
        private static int def_intervall = 1000;
        private Array myPort;
        private List<string[]> stringList = new List<string[]>();
        private object receivedDataLock = new object();

        private int counter;                                            //timer how long program should run
        
        private int count = 0;                                          //timer counter
        private int mode = 1;                                           // 0 = Z-Axis, 1 = X/Y/Z Axis
        private Size oldSize;
        private int counter_backup;

        // Colors
        private static Color green = ColorTranslator.FromHtml("#4CAF50");
        private static Color yellow = ColorTranslator.FromHtml("#FFC107");
        private static Color red = ColorTranslator.FromHtml("#F4511E");

        //button text constant
        private static string button_start = "Start";
        private static string button_stop  = "Stop";

        // CSV recording
        
        StringBuilder buffer;
        private const string strComma = ";";
        private int contCSVNumber = 0;
        private string contCSVPath = "";
        private bool saveContCSV = false;

        //Graph renderer
        private GraphRenderer renderer;

        //variavles for traffic light
        private float threshold_green;
        private float threshold_yellow;
        private float threshold_red;
        private bool renderInNewWindow = false;
        TrafficLightForm tlForm;

        private bool showX = true;
        private bool showY = true;
        private bool showZ = true;

        //Dot Graph valie indices
        private int x_ind;
        private int y_ind;

        private bool calcMinMax = false;
        private double[] maxValues = { 0, 0, 0 };
        private double[] minValues = { 0, 0, 0 };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-At");
            myPort = SerialPort.GetPortNames();                         //Get available Serial Ports
            foreach(string s in myPort){   
                cb_ports.Items.Add(s);                                  //Populate the Port Combo Box
            }

            //init Serial Connection
            serialConnection = new SerialConnection();
            
            //init CSV buffer
            buffer = new StringBuilder();

            initUserInterface();

            

        }

        private void initUserInterface()
        {
            cb_tlAxisSelect.SelectedIndex = 0;

            cb_graphType.SelectedIndex = 0;

            oldSize = this.Size;
            p_green.BackColor = green;
            p_yellow.BackColor = yellow;
            p_red.BackColor = red;

            timer1.Interval = 1000; // 1 second

            renderer = new GraphRenderer();
            tb_lengthXAxis.Text = "" + renderer.Length_X_axis;
            tb_intervall_X.Text = "" + renderer.Intervall_X_axis;

            p_xAxis.BackColor = green;
            p_yAxis.BackColor = green;
            p_zAxis.BackColor = green;

        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.serialConnection.initSerialPort();                                         // initialize serial port
            this.serialConnection.setDataReceivedHandler(new SerialDataReceivedEventHandler(this.serialPort1_DataReceived));

            if (this.serialConnection.getPortName().Contains("COM"))              //If there is a valid serial port name selected
            {
                if (tb_counter.Text == "")
                {
                    MessageBox.Show("Bitte Testdauer eingeben (0 = unendlich)!");
                    stopAndDisconnectSerial();
                    return;
                }

                if (tb_contCSVPath.Text == "" && saveContCSV)
                {
                    MessageBox.Show("Bitte Pfad zum Speichern der CSV Dateien angeben!");
                    stopAndDisconnectSerial();
                    return;
                }

                if (this.bt_connect.Text.Equals(button_start))
                {           //If the button currently reads Connect
                    renderer.resetPanels(p_green, p_yellow, p_red, p_xAxis, p_yAxis, p_zAxis, chart1, chart2, tlForm, txtReceive);
                    if (mode == 0 || mode == 1)
                    {
                        if (t_thresX.Text == "" || t_thresY.Text == "" || t_thresZ.Text == "")
                        {
                            MessageBox.Show("Bitte Grenzwerte eingeben!");
                            stopAndDisconnectSerial();
                            return;
                        }
                        threshold_green = float.Parse(t_thresX.Text);
                        threshold_yellow = float.Parse(t_thresY.Text);
                        threshold_red = float.Parse(t_thresZ.Text);
                    }

                    this.MaximizeBox = false;
                    try
                    {
                        try
                        {
                            this.counter = int.Parse(tb_counter.Text);
                            this.counter_backup = int.Parse(tb_counter.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Bitte Dauer in Sekunden eingeben.");
                            stopAndDisconnectSerial();
                            return;
                        }
                        if (counter > 0)
                        {
                            timer1.Start();
                        }

                        this.bt_connect.Text = button_stop;             //Change the button text to Disconnect
                        this.bt_connect.Update();

                        renderer.Panel_max_width = gb_allAxis.Width - 80;

                        gb_settings.Enabled = false;
                        gb_allAxis.Enabled = false;
                        gb_Diagramm.Enabled = false;
                        panel1.Enabled = false;
                        cb_tlAxisSelect.Enabled = false;

                        cb_showX.Visible = false;
                        cb_showY.Visible = false;
                        cb_showZ.Visible = false;

                        checkBox1.Enabled = false;
                        checkBox3.Enabled = false;

                        txtReceive.Clear();


                        //setup 3-Axis graphs
                        if (mode == 1)
                        {
                            float thresX = float.Parse(t_thresX.Text);
                            float thresY = float.Parse(t_thresY.Text);
                            float thresZ = float.Parse(t_thresZ.Text);
                            int lengthXAxis;
                            int intervall_X;
                            try
                            {
                                lengthXAxis = int.Parse(tb_lengthXAxis.Text);
                                intervall_X = int.Parse(tb_intervall_X.Text);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show("Bitte nur ganze Zaheln eingeben.");
                                stopAndDisconnectSerial();
                                return;
                            }
                            
                            int marking_value = 0;
                            if (cb_axis_marking.Text.Equals("X"))
                            {
                                marking_value = int.Parse(t_thresX.Text);
                            }
                            else if (cb_axis_marking.Text.Equals("Y"))
                            {
                                marking_value = int.Parse(t_thresY.Text);
                            }
                            else if (cb_axis_marking.Text.Equals("Z"))
                            {
                                marking_value = int.Parse(t_thresZ.Text);
                            }

                            renderer.setupAxisChart(thresX, thresY, thresZ, lengthXAxis, intervall_X, chart1, marking_value);
                        }
                        if (mode == 2)
                        {
                            try
                            {
                                if (cb_XDot.Checked && cb_YDot.Checked)
                                {
                                    x_ind = 1;
                                    y_ind = 2;
                                }
                                else if (cb_YDot.Checked && cb_ZDot.Checked)
                                {
                                    x_ind = 2;
                                    y_ind = 3;
                                }
                                else if (cb_XDot.Checked && cb_ZDot.Checked)
                                {
                                    x_ind = 1;
                                    y_ind = 3;
                                }
                                else
                                {
                                    throw new Exception();
                                }

                                int minX = -1000;
                                int maxX = 1000;
                                int minY = -1000;
                                int maxY = 1000;

                                try
                                {
                                    minX = int.Parse(t_minX.Text);
                                    maxX = int.Parse(t_maxX.Text);
                                    minY = int.Parse(t_minY.Text);
                                    maxY = int.Parse(t_maxY.Text);

                                    if (mode == 2 && int.Parse(t_maxX.Text) <= int.Parse(t_thresX.Text))
                                    {
                                        MessageBox.Show("Grenzwert muss kleiner oder gleich dem Maximalwert der Achsen sein!");
                                        stopAndDisconnectSerial();
                                        return;
                                    }
                                    else if (mode == 2 && int.Parse(t_maxY.Text) <= int.Parse(t_thresY.Text))
                                    {
                                        MessageBox.Show("Grenzwert muss kleiner oder gleich dem Maximalwert der Achsen sein!");
                                        stopAndDisconnectSerial();
                                        return;
                                    }

                                    renderer.setupDotChart(chart2, minX, maxX, minY, maxY, int.Parse(t_thresX.Text), int.Parse(t_thresY.Text));
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Minimal- und Maximal Werte dürfen nur ganze Zahlen sein!");
                                    stopAndDisconnectSerial();
                                    return;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Es müssen 2 Achsen zur Darstellung ausgewält werden!");
                                stopAndDisconnectSerial();
                                return;
                            }

                        }
                        
                    }

                    catch (IOException ex)
                    {
                        MessageBox.Show("Error opening COM Port.\r" + ex.Message);
                        return;
                    }

                    //Open the serial Port
                    this.setupTimer();
                    this.serialConnection.connect();
                }

                else if (this.bt_connect.Text.Equals(button_stop))                   //If the serial port is open
                {
                    this.MaximizeBox = true;

                    stopAndDisconnectSerial();
                    //calculate Min and Max
                    if (calcMinMax)
                    {
                        calculateMinMax();
                    }

                    if (saveContCSV)
                    {
                        this.saveContCSVFile(buffer, contCSVNumber, contCSVPath);
                        contCSVNumber++;
                    }
                    else if(buffer.Length > 0) {
                        this.saveCSVButton.Enabled = true;
                    }
                    else
                        this.saveCSVButton.Enabled = false;

                    checkBox3.Enabled = true;
                        
                    
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select a valid COM Port");                     //else send error message
                return;
            }
                
        }

        private void calculateMinMax()
        {
            String line = "";
            String cvsSplitBy = ",";

            try
            {
                string[] delim = { Environment.NewLine, "\n" }; // "\n" added in case you manually appended a newline
                string[] lines = buffer.ToString().Split(delim, StringSplitOptions.None);

                string firstLine = lines[0];
                String[] columns = firstLine.Split(';');
                minValues[0] = double.Parse(columns[1]);
                minValues[1] = double.Parse(columns[2]);
                minValues[2] = double.Parse(columns[3]);

                maxValues[0] = double.Parse(columns[1]);
                maxValues[1] = double.Parse(columns[2]);
                maxValues[2] = double.Parse(columns[3]);

                foreach (string csvline in lines)
                {
                    // use comma as separator
                    columns = csvline.Split(';');

                    calculateMinAndMax(columns);
                }

                MessageBox.Show("Minimalwert X: " + minValues[0] + " Y: " + minValues[1] + " Z: " + minValues[2] + System.Environment.NewLine + "Maximalwert X: " + maxValues[0] + " Y: " + maxValues[1] + " Z: " + maxValues[2]);


            }
            catch (FileNotFoundException ex)
            {

            }
            catch (IOException ex)
            {

            }
        }

        private void saveContCSVFile(StringBuilder buffer, int contCSVNumber, string contCSVPath)
        {
            string filename = "jansensor_"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"_"+contCSVNumber+".csv";
            string filepath = contCSVPath + "\\" + filename;
            if (File.Exists(filepath))
            {
                filename = "jansensor_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "_" + contCSVNumber + "_1.csv";
                filepath = contCSVPath + "\\" + filename;
            }

            StreamWriter swOutput = new StreamWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Read));
            swOutput.WriteLine(buffer.ToString());

            buffer.Clear();
            swOutput.Close();
            serialConnection.resetSerial();
        }

        private void stopAndDisconnectSerial()
        {
            if (tb_counter.Text != "")
            {
                timer1.Stop();
                tb_counter.Text = counter_backup + "";
            }
            disconnectSerial();
            gb_settings.Enabled = true;
            gb_allAxis.Enabled = true;
            gb_Diagramm.Enabled = true;
            panel1.Enabled = true;
            cb_tlAxisSelect.Enabled = true;

            cb_showX.Visible = true;
            cb_showY.Visible = true;
            cb_showZ.Visible = true;

            checkBox1.Enabled = true;

            //renderer.resetPanels(p_green, p_yellow, p_red, p_xAxis, p_yAxis, p_zAxis, chart1, chart2);
            return;
        }

        private void disconnectSerial()
        {
            
            this.stopPortTimer();
            this.count = 0;
            Thread CloseDown = new Thread(new ThreadStart(this.serialConnection.CloseSerialOnExit)); //close port in new thread to avoid hang
            CloseDown.Start();
            this.bt_connect.Text = button_start;                            //Change the text to Connect
            this.bt_connect.Update();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            
            return;
        }

        

        private delegate void SetTextCallback(string text);

        private void ReceivedText(string text)
        {
            string rxData = null;
            //String for incoming serial port data

            //Handle Incoming serial data
            //If threadsafe call needed
            if (this.txtReceive.InvokeRequired && !this.IsDisposed)
            {
                try
                {
                    SetTextCallback x = new SetTextCallback(ReceivedText);
                    this.Invoke(x, new object[] { (text) });
                }
                catch (Exception ex)
                {
                    return;
                }
            }
            else
            {
                rxData = text;
                //Else assign rxData to the Serial Port Received Text
                bw_DoWork(rxData);
                //Do the computations on the recieved text
            }

        }

        public void setTimer(int time)
        {
            if (time > 0)
                this.portTimer.Interval = time;
            else
                portTimer.Interval = def_intervall;
        }

        private void setupTimer()
        {
            //timer für Mess-Intervall
            portTimer = new System.Windows.Forms.Timer();

            int intervall = 0;
            try
            {
                intervall = int.Parse(timer_intervall.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Intervall ungültig!");
            }
            this.setTimer(intervall);
            portTimer.Tick += portTimer_Tick;
            portTimer.Start();
        }

        public void stopPortTimer()
        {
            if (portTimer != null)
                portTimer.Stop();
        }

        void portTimer_Tick(object sender, EventArgs e)
        {
            count++;
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }

        public void UpdatePanel(Panel p, int width)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (ControlInvokeRequired(p, () => UpdatePanel(p, width))) return;
            p.Width = width;
            if (width == renderer.Panel_max_width)
                p.BackColor = red;
            else
                p.BackColor = green;
        }

        public void UpdateChart(Chart c, int series, float x_value, float y_value)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (ControlInvokeRequired(c, () => UpdateChart(c, series,  x_value, y_value))) return;
                c.Series[series].Points.AddXY(x_value, y_value);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if ((sender as SerialPort).IsOpen)
            {
                ReceivedText((sender as SerialPort).ReadExisting());
                //Recieve Data via the serial port
            }
        }

        private void bw_DoWork(string rxData){
            bool accel = true;
            //set accelerometer as connected by default
            string[] lineData = null;
            //stores the incomming serial data as an array of lines
            string[] seperatedData = null;

            lineData = rxData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            //Split serial text recieved by line
            //Itterate through the lines
            for (int i = 0; i <= lineData.Length - 1; i++) {
	            lineData[i] = lineData[i].Trim();
                //Trim of begining and ending spaces

                seperatedData = lineData[i].Split(',');
                //seperate a line of serial data by commas
                
                    outPutData(seperatedData);
		       

		            if (accel.Equals(true)) {
			            if (seperatedData.Length == 4) {
                            //renderData(seperatedData);
                            // Ensure we arent trying to modify string builder from 2 different threads simultaneously
                            lock (receivedDataLock)
                            {
                                stringList.Add(seperatedData);
                            }
			            }
		            }
            }
        }

        private void renderData(string[] seperatedData)
        {
            string[] data = seperatedData;
            //display data depending on mode
            if (mode == 0)          //display traffic light
            {
                //read selected axis
                int axisIndex = 0;
                if (cb_tlAxisSelect.SelectedIndex == 0)
                {
                    axisIndex = 1;
                }
                else if (cb_tlAxisSelect.SelectedIndex == 1)
                {
                    axisIndex = 2;
                }
                else if (cb_tlAxisSelect.SelectedIndex == 2)
                {
                    axisIndex = 3;
                }

                if (renderInNewWindow)
                {
                    ThreadStart start = delegate { renderer.renderTrafficLight(cb_reverseTL.Checked, float.Parse(data[axisIndex]), threshold_green, threshold_yellow, threshold_red, tlForm.p_green, tlForm.p_yellow, tlForm.p_red); };
                    Thread render = new Thread(new ThreadStart(start));
                    render.Start();
                }
                else
                {
                    if (!string.IsNullOrEmpty(t_thresX.Text) && !string.IsNullOrEmpty(t_thresX.Text) && !string.IsNullOrEmpty(t_thresZ.Text))
                    {
                        float threshold_green = float.Parse(t_thresX.Text);
                        float threshold_yellow = float.Parse(t_thresY.Text);
                        float threshold_red = float.Parse(t_thresZ.Text);

                        ThreadStart start = delegate { renderer.renderTrafficLight(cb_reverseTL.Checked, float.Parse(data[axisIndex]), threshold_green, threshold_yellow, threshold_red, p_green, p_yellow, p_red); };
                        Thread render = new Thread(new ThreadStart(start));
                        render.Start();
                    }
                    else
                    {
                        disconnectSerial();
                        MessageBox.Show("Bitte Grenzwerte eingeben.");
                    }
                }

            }
            else if (mode == 1)      //display graph with all 3 axis
            {
                if (count > renderer.Length_X_axis)
                {
                    this.chart1.ChartAreas[0].AxisX.Minimum++;
                    this.chart1.ChartAreas[0].AxisX.Maximum = count + 1;
                }


                ThreadStart start = delegate { renderer.render3AxisGraph(float.Parse(data[1]), float.Parse(data[2]), float.Parse(data[3]), p_xAxis, p_yAxis, p_zAxis, chart1, count, showX, showY, showZ); };
                Thread render = new Thread(new ThreadStart(start));
                render.Start();
            }
            else if (mode == 2 && x_ind > 0 && y_ind > 0)
            {
                ThreadStart start = delegate { renderer.renderDotGraph(int.Parse(data[x_ind]), float.Parse(data[y_ind]), int.Parse(t_thresX.Text), int.Parse(t_thresY.Text), chart2); };
                Thread render = new Thread(new ThreadStart(start));
                render.Start();
            }
        }

        private void outPutData(string[] seperatedData)
        {
            string[] data = seperatedData;
            double t = 0.0;
            int x = 0;
            int y = 0;
            int z = 0;
            bool validStringArray = false;
            try
            {
                t = double.Parse(data[0].Replace('.', ','));
                validStringArray = true;
            }
            catch
            {
                validStringArray = false;
            }

                if (data.Length >= 4 && validStringArray)
            {
                try
                {
                    t = double.Parse(data[0].Replace('.', ',')); //time in seconds
                    x = int.Parse(data[1]);
                    y = int.Parse(data[2]);
                    z = int.Parse(data[3]);
                    txtReceive.Text += String.Format("T: {0}, X: {1}, Y: {2}, Z: {3}", t, x, y, z) + System.Environment.NewLine;
                }
                catch (Exception ex)
                {
                    disconnectSerial();
                    MessageBox.Show("Error!! " + System.Environment.NewLine + ex.Message);
                    return;
                }
            }
           

            //write value to CSV
            try
            {
                float interval = float.Parse(timer_intervall.Text) / 1000;
                if (count <= 3 && t != 0 && t <= interval * 3)
                {
                    buffer.Append(t.ToString("G9")).Append(strComma).Append(x).Append(strComma).Append(y).Append(strComma).Append(z).Append(System.Environment.NewLine);
                }
                else if (count > 3)
                    buffer.Append(t.ToString("G9")).Append(strComma).Append(x).Append(strComma).Append(y).Append(strComma).Append(z).Append(System.Environment.NewLine);

            }
            catch (IOException ex)
            {
                disconnectSerial();
                MessageBox.Show("CSV Datei kann nichtg geschrieben werden. Fehler:\r\n" + ex.Message);
            }
        }

        private void plotChart(float time, float x, float y, float z){
            ChartArea area = chart1.ChartAreas[0];
        }

        private void makeNewFileName(string fname){
            string origString = "";
            bool firstRun = true;
            StringBuilder sb = new StringBuilder();

            if (firstRun) {
	            origString = fname;
	            //save the orginal filename string
	            firstRun = false;
            }

            sb.Append(origString);
            //append the original string
            sb.Replace(".csv", "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + DateTime.Now.ToString("HHmmss"));
            //replace .csv with _yyyyMMdd_HHmmss this creates a unique file identifier
            sb.Append(".csv");
            //add the .csv extention back
	            //return the filename
            fname = sb.ToString();
        }

        private void cb_ports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.serialConnection.isPortOpen() == false)
            {
                this.serialConnection.setPortName(cb_ports.SelectedItem as string);
                //change the serial port to the name selected in the combo box
            }
            else
            {
                MessageBox.Show("valid only if port is Closed");
                //ohterwise output error message
            }
        }

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            txtReceive.SelectionStart = txtReceive.Text.Length;
            txtReceive.ScrollToCaret();
            txtReceive.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked == true)
            {

                p_axisChart.Visible = false;
                p_trafficLight.Visible = true;

                l_thresX.Text = "Grün (mg):";
                l_thresY.Text = "Gelb (mg):";
                l_thresZ.Text = "Rot (mg):";

                this.mode = 0;

                cb_reverseTL.Visible = true;
            }
            else
            {
                p_axisChart.Visible = true;
                p_trafficLight.Visible = false;

                l_thresX.Text = "X-Achse (mg):";
                l_thresY.Text = "Y-Achse (mg):";
                l_thresZ.Text = "Z-Achse (mg):";

                this.mode = 1;

                cb_reverseTL.Visible = false;
            }
            MainWindow_SizeChanged(this, null);
        }
        

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoWindow info = new InfoWindow();
            info.Show();
        }

        private void cb_showX_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked){
                p_xAxis.BackColor = green;
                p_xAxis.Visible = true;
                showX = true;
            }

            else
            {
                p_xAxis.BackColor = Color.FromName("Component");
                p_xAxis.Visible = false;
                showX = false;
            }
            p_xAxis.Update();    
        }

        private void cb_showY_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked){
                p_yAxis.BackColor = green;
                p_yAxis.Visible = true;
                showY = true;
            }
            else{
                p_yAxis.BackColor = Color.FromName("Component");
                p_yAxis.Visible = false;
                showY = false;
            }
            p_yAxis.Update();
        }

        private void cb_showZ_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                p_zAxis.BackColor = green;
                p_zAxis.Visible = true;
                showZ = true;
            }
            else
            {
                p_zAxis.BackColor = Color.FromName("Component");
                p_zAxis.Visible = false;
                showZ = false;
            }
            p_zAxis.Update();
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (mode == 0)
            {
                //resize traffic light
                Size tlpSize = p_trafficLight.Size;
                int panelHeight = (int)Math.Round(((float)tlpSize.Height - 32.0) / 3.0);
                p_green.Height = panelHeight;
                p_yellow.Height = panelHeight;
                p_red.Height = panelHeight;
                p_green.Width = panelHeight;
                p_yellow.Width = panelHeight;
                p_red.Width = panelHeight;
                int xPos = p_axisChart.Location.Y + (p_trafficLight.Width / 2) - (p_green.Width / 2);
                p_green.Location = new Point(xPos, p_trafficLight.Location.Y);
                p_yellow.Location = new Point(xPos, p_green.Location.Y + p_green.Height + 6);
                p_red.Location = new Point(xPos, p_yellow.Location.Y + p_yellow.Height + 6);
            }

            if (mode == 1 && this.WindowState != FormWindowState.Minimized)
            {
                //resize axis graphs
                int axisPanelHeight = (int)Math.Round(((float)p_axisChart.Height - 104.0) / 3.0);
                p_xAxis.Height = axisPanelHeight;
                p_yAxis.Height = axisPanelHeight;
                p_zAxis.Height = axisPanelHeight;
                p_xAxis.Location = new Point(p_xAxis.Location.X, p_axisChart.Location.Y + 11);
                p_yAxis.Location = new Point(p_yAxis.Location.X, p_xAxis.Location.Y + p_xAxis.Height + 15);
                p_zAxis.Location = new Point(p_zAxis.Location.X, p_yAxis.Location.Y + p_yAxis.Height + 15);
                renderer.Panel_max_width = gb_allAxis.Width - 80;

                int newWidth = (int)Math.Round((float)(groupBox3.Width - 10.0) / 2.0);
                gb_allAxis.Width = newWidth;
                gb_Diagramm.Width = newWidth;
                gb_Diagramm.Location = new Point(gb_allAxis.Width + 10, gb_Diagramm.Location.Y);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                l_thresX.Text = "Rot (mg):";
                l_thresY.Text = "Gelb (mg):";
                l_thresZ.Text = "Grün (mg):";
            }
            else
            {
                l_thresX.Text = "Grün (mg):";
                l_thresY.Text = "Gelb (mg):";
                l_thresZ.Text = "Rot (mg):";
            }
                
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            renderInNewWindow = cb.Checked;
            if (cb.Checked){
                //setup Traffic Light window
                if (tlForm == null)
                    tlForm = new TrafficLightForm();
                tlForm.Show();
                //trafficLightPanel.Enabled = false;
            }
            else
            {
                tlForm.Close();
                tlForm = null;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            tb_counter.Text = ""+counter;
            if (counter == 0)
            {
                timer1.Stop();
                bt_connect.PerformClick();
                tb_counter.Text = this.counter_backup + "";
                Assembly assembly;
                assembly = Assembly.GetExecutingAssembly();
                Stream soundStream = assembly.GetManifestResourceStream("SensorVisualizer.sound.wav");
                SoundPlayer sp;
                sp = new SoundPlayer(soundStream);
                sp.Play(); 
            }

        }

        private void kalibrierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalibrateForm form = new CalibrateForm();
            form.Show();
        }

        private void cb_graphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            //Ampel
            if(box.SelectedIndex == 0)
                {
                    l_thresX.Visible = true;
                    l_thresY.Visible = true;
                    l_thresZ.Visible = true;

                    t_thresX.Visible = true;
                    t_thresY.Visible = true;
                    t_thresZ.Visible = true;    

                    p_axisChart.Visible = false;
                    p_2DAxis.Visible = false;
                    p_trafficLight.Visible = true;


                    t_thresX.Text = "200";
                    t_thresY.Text = "300";
                    t_thresZ.Text = "400";

                    timer_intervall.Text = "150";

                    l_thresX.Text = "Grün (mg):";
                    l_thresY.Text = "Gelb (mg):";
                    l_thresZ.Text = "Rot (mg):";

                    this.mode = 0;

                    cb_reverseTL.Visible = true;
                }
            
            else if (box.SelectedIndex == 1)
            {
                l_thresX.Visible = true;
                l_thresY.Visible = true;
                l_thresZ.Visible = true;

                t_thresX.Visible = true;
                t_thresY.Visible = true;
                t_thresZ.Visible = true;

                p_axisChart.Visible = true;
                p_2DAxis.Visible = false;
                p_trafficLight.Visible = false;


                t_thresX.Text = "1600";
                t_thresY.Text = "400";
                t_thresZ.Text = "800";

                timer_intervall.Text = "10";

                tb_intervall_X.Text = "100";
                tb_lengthXAxis.Text = "400";

                l_thresX.Text = "X-Achse (mg):";
                l_thresY.Text = "Y-Achse (mg):";
                l_thresZ.Text = "Z-Achse (mg):";

                this.mode = 1;

                cb_reverseTL.Visible = false;
            }
            //2D Kreuz
            else if (box.SelectedIndex == 2)
            {

                t_thresX.Text = "400";
                t_thresY.Text = "400";

                timer_intervall.Text = "10";

                l_thresX.Text = "X-Achse (mg):";
                l_thresY.Text = "Y-Achse (mg):";

                l_thresZ.Visible = false;

                t_thresZ.Visible = false;

                p_2DAxis.Visible = true;
                p_axisChart.Visible = false;
                p_trafficLight.Visible = false;
                cb_reverseTL.Visible = false;

                this.mode = 2;

                
            }
            //Balken Graph

            MainWindow_SizeChanged(this, null);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bt_connect.Text.Equals(button_stop))                   //If the serial port is open
            {
                stopAndDisconnectSerial();
                return;
            }
        }

        private void cb_XDot_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_XDot.Checked && cb_YDot.Checked)
                cb_ZDot.Enabled = false;
            else
                cb_ZDot.Enabled = true;

            if (cb_YDot.Checked && cb_ZDot.Checked)
                cb_XDot.Enabled = false;
            else
                cb_XDot.Enabled = true;

            if (cb_XDot.Checked && cb_ZDot.Checked)
                cb_YDot.Enabled = false;
            else
                cb_YDot.Enabled = true;
        }

        private void cb_tlAxisSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renderer.resetPanels(p_green, p_yellow, p_red, p_xAxis, p_yAxis, p_zAxis, chart1, chart2, tlForm, txtReceive);
            checkBox3.Checked = false;
            saveCSVButton.Enabled = false;
            buffer.Clear();
            serialConnection.resetSerial();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox s = (CheckBox)sender;
            if (s.Checked)
                txtReceive.Visible = true;
            else
                txtReceive.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveCSVWindow saveCSV = new SaveCSVWindow(buffer);
            saveCSV.Show();
        }


        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                saveContCSV = true;
                saveCSVButton.Enabled = false;
                tb_contCSVPath.Visible = true;
                button1.Visible = true;
                saveContCSV = true;
            }
            else if (buffer.Length > 0)
            {
                saveCSVButton.Enabled = true;
                tb_contCSVPath.Visible = false;
                button1.Visible = false;
                saveContCSV = false;
                contCSVNumber = 0;
            }
            else {
                saveCSVButton.Enabled = false;
                tb_contCSVPath.Visible = false;
                button1.Visible = false;
                saveContCSV = false;
                contCSVNumber = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            tb_contCSVPath.Text = dialog.SelectedPath;
            contCSVPath = tb_contCSVPath.Text;
        }

        private void cb_minMax_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                calcMinMax = true;
            }
            else if (buffer.Length > 0)
            {
                calcMinMax = false;
            }
        }


        private void calculateMinAndMax(String[] line)
        {
            for (int i = 1; i < line.Length; i++)
            {
                //check the max value
                double currentValue = Double.Parse(line[i]);
                /*if (currentValue < 0)
                    currentValue *= -1;*/
                if (currentValue > maxValues[i-1])
                {
                    maxValues[i-1] = currentValue;
                }

                //check the min value
                if (currentValue < minValues[i-1])
                {
                    minValues[i-1] = currentValue;
                }
            }
        }

    }
}
