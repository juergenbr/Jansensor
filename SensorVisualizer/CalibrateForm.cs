using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorVisualizer
{

    public partial class CalibrateForm : Form
    {
        private SerialConnection serialConnection;
        private System.Windows.Forms.Timer portTimer;
        private static int def_intervall = 150;

        private int count = 0;

        public CalibrateForm()
        {
            InitializeComponent();
        }

        private void btcalibrate_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.serialConnection.initSerialPort();                                         // initialize serial port
            this.serialConnection.setDataReceivedHandler(new SerialDataReceivedEventHandler(this.serialPort1_DataReceived));

            if (this.serialConnection.getPortName().Contains("COM"))              //If there is a valid serial port name selected
            {
                if (this.bt_calibrate.Enabled)
                {           //If the button currently reads Connect
                    try
                    {
                        this.bt_calibrate.Enabled = false;             //Change the button text to Disconnect
                        this.bt_calibrate.Update();

                        cb_X.Enabled = false;
                        cb_Y.Enabled = false;
                        cb_Z.Enabled = false;

                        //Open the serial Port
                        this.setupTimer();
                        this.serialConnection.connect();

                        return;
                    }

                    catch (IOException ex)
                    {
                        MessageBox.Show("Error opening COM Port.\r" + ex.Message);
                        return;
                    }
                }
            }
            MessageBox.Show("Select a valid COM Port");                     //else send error message
            return;
        }

        
        private void disconnectSerial()
        {
            /*
            this.FormBorderStyle = FormBorderStyle.Sizable;
            Thread CloseDown = new Thread(new ThreadStart(this.serialConnection.CloseSerialOnExit)); //close port in new thread to avoid hang
            CloseDown.Start();
            this.bt_connect.Text = button_start;                            //Change the text to Connect
            this.bt_connect.Update();
            this.stopPortTimer();

            this.count = 0;

            if (cb_saveCSV.Checked)
            {
                buffer.Clear();
                swOutput.Close();
            }

            return;
         */
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
            portTimer.Interval = def_intervall;
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
            /*
            count++;
            if (stringList.Count > 0)
            {
                lock (receivedDataLock)
                {
                    // Do something with your string, then empty the StringBuilder

                    //write values to textbox
                    txtReceive.Text += count + "\r\n";
                    string[] data = stringList.Last();
                    txtReceive.Text += String.Format("X: {0}, Y: {1}, Z: {2}", data[1], data[2], data[3]);

                    stringList.Clear();
                }
            }
          */
        }
         

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.serialConnection.isPortOpen() == false)
            {
                this.serialConnection.setPortName(cb_Ports.SelectedItem as string);      //change the serial port to the name selected in the combo box
            }
            else
            {
                MessageBox.Show("valid only if port is Closed");
                //ohterwise output error message
            }
        }
    }
}
