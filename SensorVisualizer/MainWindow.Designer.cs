namespace SensorVisualizer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_counter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_graphType = new System.Windows.Forms.ComboBox();
            this.gb_settings = new System.Windows.Forms.GroupBox();
            this.cb_minMax = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_contCSVPath = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.saveCSVButton = new System.Windows.Forms.Button();
            this.cb_reverseTL = new System.Windows.Forms.CheckBox();
            this.timer_intervall = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_thresZ = new System.Windows.Forms.TextBox();
            this.t_thresY = new System.Windows.Forms.TextBox();
            this.t_thresX = new System.Windows.Forms.TextBox();
            this.l_thresZ = new System.Windows.Forms.Label();
            this.l_thresY = new System.Windows.Forms.Label();
            this.l_thresX = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_connect = new System.Windows.Forms.Button();
            this.cb_ports = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.p_2DAxis = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_XDot = new System.Windows.Forms.CheckBox();
            this.cb_YDot = new System.Windows.Forms.CheckBox();
            this.cb_ZDot = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.t_maxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_minX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_maxY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.t_minY = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.p_axisChart = new System.Windows.Forms.Panel();
            this.gb_Diagramm = new System.Windows.Forms.GroupBox();
            this.tb_intervall_X = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_lengthXAxis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gb_allAxis = new System.Windows.Forms.GroupBox();
            this.cb_showZ = new System.Windows.Forms.CheckBox();
            this.cb_showY = new System.Windows.Forms.CheckBox();
            this.cb_showX = new System.Windows.Forms.CheckBox();
            this.p_zAxis = new System.Windows.Forms.Panel();
            this.p_yAxis = new System.Windows.Forms.Panel();
            this.p_xAxis = new System.Windows.Forms.Panel();
            this.p_trafficLight = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_tlAxisSelect = new System.Windows.Forms.ComboBox();
            this.p_red = new System.Windows.Forms.Panel();
            this.p_yellow = new System.Windows.Forms.Panel();
            this.p_green = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cb_axis_marking = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gb_settings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.p_2DAxis.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.p_axisChart.SuspendLayout();
            this.gb_Diagramm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.gb_allAxis.SuspendLayout();
            this.p_trafficLight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tb_counter);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.gb_settings);
            this.groupBox2.Controls.Add(this.txtReceive);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bt_connect);
            this.groupBox2.Controls.Add(this.cb_ports);
            this.groupBox2.Location = new System.Drawing.Point(12, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1003, 191);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(378, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(140, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Sensor Output anzeigen";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(855, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_counter
            // 
            this.tb_counter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_counter.Location = new System.Drawing.Point(814, 14);
            this.tb_counter.Name = "tb_counter";
            this.tb_counter.Size = new System.Drawing.Size(35, 20);
            this.tb_counter.TabIndex = 27;
            this.tb_counter.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dauer [sek] (0 = unbegrenzt):";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_graphType);
            this.panel1.Location = new System.Drawing.Point(6, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 26);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Graph-Typ:";
            // 
            // cb_graphType
            // 
            this.cb_graphType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_graphType.FormattingEnabled = true;
            this.cb_graphType.Items.AddRange(new object[] {
            "Ampel (1 Achse)",
            "Balken + Graph (1-3 Achsen)",
            "2-Achsen Punkt"});
            this.cb_graphType.Location = new System.Drawing.Point(74, 3);
            this.cb_graphType.Name = "cb_graphType";
            this.cb_graphType.Size = new System.Drawing.Size(167, 21);
            this.cb_graphType.TabIndex = 29;
            this.cb_graphType.SelectedIndexChanged += new System.EventHandler(this.cb_graphType_SelectedIndexChanged);
            // 
            // gb_settings
            // 
            this.gb_settings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_settings.Controls.Add(this.cb_minMax);
            this.gb_settings.Controls.Add(this.button1);
            this.gb_settings.Controls.Add(this.tb_contCSVPath);
            this.gb_settings.Controls.Add(this.checkBox3);
            this.gb_settings.Controls.Add(this.saveCSVButton);
            this.gb_settings.Controls.Add(this.cb_reverseTL);
            this.gb_settings.Controls.Add(this.timer_intervall);
            this.gb_settings.Controls.Add(this.label7);
            this.gb_settings.Controls.Add(this.t_thresZ);
            this.gb_settings.Controls.Add(this.t_thresY);
            this.gb_settings.Controls.Add(this.t_thresX);
            this.gb_settings.Controls.Add(this.l_thresZ);
            this.gb_settings.Controls.Add(this.l_thresY);
            this.gb_settings.Controls.Add(this.l_thresX);
            this.gb_settings.Location = new System.Drawing.Point(6, 42);
            this.gb_settings.Name = "gb_settings";
            this.gb_settings.Size = new System.Drawing.Size(366, 143);
            this.gb_settings.TabIndex = 25;
            this.gb_settings.TabStop = false;
            this.gb_settings.Text = "Einstellungen";
            // 
            // cb_minMax
            // 
            this.cb_minMax.AutoSize = true;
            this.cb_minMax.Location = new System.Drawing.Point(182, 66);
            this.cb_minMax.Name = "cb_minMax";
            this.cb_minMax.Size = new System.Drawing.Size(173, 17);
            this.cb_minMax.TabIndex = 22;
            this.cb_minMax.Text = "Min. und Max. Wert berechnen";
            this.cb_minMax.UseVisualStyleBackColor = true;
            this.cb_minMax.CheckedChanged += new System.EventHandler(this.cb_minMax_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Durchsuchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_contCSVPath
            // 
            this.tb_contCSVPath.Location = new System.Drawing.Point(6, 116);
            this.tb_contCSVPath.Name = "tb_contCSVPath";
            this.tb_contCSVPath.Size = new System.Drawing.Size(266, 20);
            this.tb_contCSVPath.TabIndex = 20;
            this.tb_contCSVPath.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(182, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(113, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Fortlaufende Datei";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // saveCSVButton
            // 
            this.saveCSVButton.Enabled = false;
            this.saveCSVButton.Location = new System.Drawing.Point(6, 90);
            this.saveCSVButton.Name = "saveCSVButton";
            this.saveCSVButton.Size = new System.Drawing.Size(152, 23);
            this.saveCSVButton.TabIndex = 18;
            this.saveCSVButton.Text = "Daten als .csv speichern";
            this.saveCSVButton.UseVisualStyleBackColor = true;
            this.saveCSVButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // cb_reverseTL
            // 
            this.cb_reverseTL.AutoSize = true;
            this.cb_reverseTL.Location = new System.Drawing.Point(182, 44);
            this.cb_reverseTL.Name = "cb_reverseTL";
            this.cb_reverseTL.Size = new System.Drawing.Size(105, 17);
            this.cb_reverseTL.TabIndex = 17;
            this.cb_reverseTL.Text = "Ampel umkehren";
            this.cb_reverseTL.UseVisualStyleBackColor = true;
            this.cb_reverseTL.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer_intervall
            // 
            this.timer_intervall.Location = new System.Drawing.Point(264, 16);
            this.timer_intervall.Name = "timer_intervall";
            this.timer_intervall.Size = new System.Drawing.Size(75, 20);
            this.timer_intervall.TabIndex = 12;
            this.timer_intervall.Text = "150";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Intervall (ms):";
            // 
            // t_thresZ
            // 
            this.t_thresZ.Location = new System.Drawing.Point(81, 64);
            this.t_thresZ.Name = "t_thresZ";
            this.t_thresZ.Size = new System.Drawing.Size(77, 20);
            this.t_thresZ.TabIndex = 5;
            // 
            // t_thresY
            // 
            this.t_thresY.Location = new System.Drawing.Point(81, 41);
            this.t_thresY.Name = "t_thresY";
            this.t_thresY.Size = new System.Drawing.Size(77, 20);
            this.t_thresY.TabIndex = 4;
            // 
            // t_thresX
            // 
            this.t_thresX.Location = new System.Drawing.Point(81, 16);
            this.t_thresX.Name = "t_thresX";
            this.t_thresX.Size = new System.Drawing.Size(77, 20);
            this.t_thresX.TabIndex = 3;
            // 
            // l_thresZ
            // 
            this.l_thresZ.AutoSize = true;
            this.l_thresZ.Location = new System.Drawing.Point(4, 67);
            this.l_thresZ.Name = "l_thresZ";
            this.l_thresZ.Size = new System.Drawing.Size(73, 13);
            this.l_thresZ.TabIndex = 2;
            this.l_thresZ.Text = "Z-Achse (mg):";
            // 
            // l_thresY
            // 
            this.l_thresY.AutoSize = true;
            this.l_thresY.Location = new System.Drawing.Point(4, 44);
            this.l_thresY.Name = "l_thresY";
            this.l_thresY.Size = new System.Drawing.Size(73, 13);
            this.l_thresY.TabIndex = 1;
            this.l_thresY.Text = "Y-Achse (mg):";
            // 
            // l_thresX
            // 
            this.l_thresX.AutoSize = true;
            this.l_thresX.Location = new System.Drawing.Point(4, 22);
            this.l_thresX.Name = "l_thresX";
            this.l_thresX.Size = new System.Drawing.Size(73, 13);
            this.l_thresX.TabIndex = 0;
            this.l_thresX.Text = "X-Achse (mg):";
            // 
            // txtReceive
            // 
            this.txtReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceive.BackColor = System.Drawing.SystemColors.Window;
            this.txtReceive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReceive.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtReceive.Location = new System.Drawing.Point(378, 75);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReceive.Size = new System.Drawing.Size(619, 110);
            this.txtReceive.TabIndex = 22;
            this.txtReceive.TabStop = false;
            this.txtReceive.Visible = false;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "COM Ports:";
            // 
            // bt_connect
            // 
            this.bt_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_connect.Location = new System.Drawing.Point(926, 13);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(71, 23);
            this.bt_connect.TabIndex = 20;
            this.bt_connect.Text = "Start";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // cb_ports
            // 
            this.cb_ports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ports.FormattingEnabled = true;
            this.cb_ports.Location = new System.Drawing.Point(556, 13);
            this.cb_ports.Name = "cb_ports";
            this.cb_ports.Size = new System.Drawing.Size(101, 21);
            this.cb_ports.TabIndex = 19;
            this.cb_ports.SelectedIndexChanged += new System.EventHandler(this.cb_ports_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.p_axisChart);
            this.groupBox3.Controls.Add(this.p_2DAxis);
            this.groupBox3.Controls.Add(this.p_trafficLight);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1003, 323);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphische Darstellung";
            // 
            // p_2DAxis
            // 
            this.p_2DAxis.AutoSize = true;
            this.p_2DAxis.Controls.Add(this.groupBox5);
            this.p_2DAxis.Controls.Add(this.groupBox4);
            this.p_2DAxis.Controls.Add(this.groupBox1);
            this.p_2DAxis.Controls.Add(this.chart2);
            this.p_2DAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_2DAxis.Location = new System.Drawing.Point(3, 16);
            this.p_2DAxis.Name = "p_2DAxis";
            this.p_2DAxis.Size = new System.Drawing.Size(997, 304);
            this.p_2DAxis.TabIndex = 27;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.cb_XDot);
            this.groupBox5.Controls.Add(this.cb_YDot);
            this.groupBox5.Controls.Add(this.cb_ZDot);
            this.groupBox5.Location = new System.Drawing.Point(859, 45);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sensor-Achsen";
            // 
            // cb_XDot
            // 
            this.cb_XDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_XDot.AutoSize = true;
            this.cb_XDot.Location = new System.Drawing.Point(13, 17);
            this.cb_XDot.Name = "cb_XDot";
            this.cb_XDot.Size = new System.Drawing.Size(66, 17);
            this.cb_XDot.TabIndex = 6;
            this.cb_XDot.Text = "X-Achse";
            this.cb_XDot.UseVisualStyleBackColor = true;
            this.cb_XDot.CheckedChanged += new System.EventHandler(this.cb_XDot_CheckedChanged);
            // 
            // cb_YDot
            // 
            this.cb_YDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_YDot.AutoSize = true;
            this.cb_YDot.Location = new System.Drawing.Point(13, 41);
            this.cb_YDot.Name = "cb_YDot";
            this.cb_YDot.Size = new System.Drawing.Size(66, 17);
            this.cb_YDot.TabIndex = 5;
            this.cb_YDot.Text = "Y-Achse";
            this.cb_YDot.UseVisualStyleBackColor = true;
            this.cb_YDot.CheckedChanged += new System.EventHandler(this.cb_XDot_CheckedChanged);
            // 
            // cb_ZDot
            // 
            this.cb_ZDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ZDot.AutoSize = true;
            this.cb_ZDot.Location = new System.Drawing.Point(13, 65);
            this.cb_ZDot.Name = "cb_ZDot";
            this.cb_ZDot.Size = new System.Drawing.Size(66, 17);
            this.cb_ZDot.TabIndex = 4;
            this.cb_ZDot.Text = "Z-Achse";
            this.cb_ZDot.UseVisualStyleBackColor = true;
            this.cb_ZDot.CheckedChanged += new System.EventHandler(this.cb_XDot_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.t_maxX);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.t_minX);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(859, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(132, 74);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "X-Achse";
            // 
            // t_maxX
            // 
            this.t_maxX.Location = new System.Drawing.Point(64, 45);
            this.t_maxX.Name = "t_maxX";
            this.t_maxX.Size = new System.Drawing.Size(65, 20);
            this.t_maxX.TabIndex = 3;
            this.t_maxX.Text = "2000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maximum";
            // 
            // t_minX
            // 
            this.t_minX.Location = new System.Drawing.Point(64, 17);
            this.t_minX.Name = "t_minX";
            this.t_minX.Size = new System.Drawing.Size(65, 20);
            this.t_minX.TabIndex = 1;
            this.t_minX.Text = "-2000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Minimum";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.t_maxY);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.t_minY);
            this.groupBox1.Location = new System.Drawing.Point(859, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Y-Achse";
            // 
            // t_maxY
            // 
            this.t_maxY.Location = new System.Drawing.Point(64, 43);
            this.t_maxY.Name = "t_maxY";
            this.t_maxY.Size = new System.Drawing.Size(65, 20);
            this.t_maxY.TabIndex = 7;
            this.t_maxY.Text = "2000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Minimum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Maximum";
            // 
            // t_minY
            // 
            this.t_minY.Location = new System.Drawing.Point(64, 17);
            this.t_minY.Name = "t_minY";
            this.t_minY.Size = new System.Drawing.Size(65, 20);
            this.t_minY.TabIndex = 5;
            this.t_minY.Text = "-2000";
            // 
            // chart2
            // 
            chartArea2.AxisX.Interval = 100D;
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea2.AxisX.MajorGrid.Interval = 100D;
            chartArea2.AxisX.Maximum = 2000D;
            chartArea2.AxisX.Minimum = -2000D;
            chartArea2.AxisY.Interval = 200D;
            chartArea2.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisY.Maximum = 2000D;
            chartArea2.AxisY.Minimum = -2000D;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 0);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.LegendText = "Achsen-Beschleunigung";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(997, 304);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // p_axisChart
            // 
            this.p_axisChart.AutoSize = true;
            this.p_axisChart.Controls.Add(this.gb_Diagramm);
            this.p_axisChart.Controls.Add(this.gb_allAxis);
            this.p_axisChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_axisChart.Location = new System.Drawing.Point(3, 16);
            this.p_axisChart.Name = "p_axisChart";
            this.p_axisChart.Size = new System.Drawing.Size(997, 304);
            this.p_axisChart.TabIndex = 26;
            // 
            // gb_Diagramm
            // 
            this.gb_Diagramm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Diagramm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_Diagramm.Controls.Add(this.label2);
            this.gb_Diagramm.Controls.Add(this.cb_axis_marking);
            this.gb_Diagramm.Controls.Add(this.tb_intervall_X);
            this.gb_Diagramm.Controls.Add(this.label9);
            this.gb_Diagramm.Controls.Add(this.tb_lengthXAxis);
            this.gb_Diagramm.Controls.Add(this.label10);
            this.gb_Diagramm.Controls.Add(this.chart1);
            this.gb_Diagramm.Location = new System.Drawing.Point(562, 3);
            this.gb_Diagramm.Name = "gb_Diagramm";
            this.gb_Diagramm.Size = new System.Drawing.Size(432, 291);
            this.gb_Diagramm.TabIndex = 9;
            this.gb_Diagramm.TabStop = false;
            this.gb_Diagramm.Text = "Linien-Diagramm";
            // 
            // tb_intervall_X
            // 
            this.tb_intervall_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_intervall_X.Location = new System.Drawing.Point(339, 217);
            this.tb_intervall_X.Name = "tb_intervall_X";
            this.tb_intervall_X.Size = new System.Drawing.Size(80, 20);
            this.tb_intervall_X.TabIndex = 16;
            this.tb_intervall_X.Text = "2";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(336, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Intervall X-Achse:";
            // 
            // tb_lengthXAxis
            // 
            this.tb_lengthXAxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_lengthXAxis.Location = new System.Drawing.Point(339, 261);
            this.tb_lengthXAxis.Name = "tb_lengthXAxis";
            this.tb_lengthXAxis.Size = new System.Drawing.Size(80, 20);
            this.tb_lengthXAxis.TabIndex = 14;
            this.tb_lengthXAxis.Text = "50";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(336, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Länge X-Achse:";
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 16);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.EmptyPointStyle.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.DodgerBlue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "X-Achse";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.DarkOrange;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Y-Achse";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Z-Achse";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(426, 272);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // gb_allAxis
            // 
            this.gb_allAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb_allAxis.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gb_allAxis.Controls.Add(this.cb_showZ);
            this.gb_allAxis.Controls.Add(this.cb_showY);
            this.gb_allAxis.Controls.Add(this.cb_showX);
            this.gb_allAxis.Controls.Add(this.p_zAxis);
            this.gb_allAxis.Controls.Add(this.p_yAxis);
            this.gb_allAxis.Controls.Add(this.p_xAxis);
            this.gb_allAxis.Location = new System.Drawing.Point(2, 4);
            this.gb_allAxis.Name = "gb_allAxis";
            this.gb_allAxis.Size = new System.Drawing.Size(431, 290);
            this.gb_allAxis.TabIndex = 8;
            this.gb_allAxis.TabStop = false;
            this.gb_allAxis.Text = "Achsen";
            // 
            // cb_showZ
            // 
            this.cb_showZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_showZ.Checked = true;
            this.cb_showZ.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showZ.Location = new System.Drawing.Point(13, 250);
            this.cb_showZ.Name = "cb_showZ";
            this.cb_showZ.Size = new System.Drawing.Size(33, 17);
            this.cb_showZ.TabIndex = 9;
            this.cb_showZ.Text = "Z";
            this.cb_showZ.UseVisualStyleBackColor = true;
            this.cb_showZ.CheckedChanged += new System.EventHandler(this.cb_showZ_CheckedChanged);
            // 
            // cb_showY
            // 
            this.cb_showY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_showY.Checked = true;
            this.cb_showY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showY.Location = new System.Drawing.Point(13, 227);
            this.cb_showY.Name = "cb_showY";
            this.cb_showY.Size = new System.Drawing.Size(33, 17);
            this.cb_showY.TabIndex = 8;
            this.cb_showY.Text = "Y";
            this.cb_showY.UseVisualStyleBackColor = true;
            this.cb_showY.CheckedChanged += new System.EventHandler(this.cb_showY_CheckedChanged);
            // 
            // cb_showX
            // 
            this.cb_showX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_showX.Checked = true;
            this.cb_showX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_showX.Location = new System.Drawing.Point(13, 204);
            this.cb_showX.Name = "cb_showX";
            this.cb_showX.Size = new System.Drawing.Size(33, 17);
            this.cb_showX.TabIndex = 7;
            this.cb_showX.Text = "X";
            this.cb_showX.UseVisualStyleBackColor = true;
            this.cb_showX.CheckedChanged += new System.EventHandler(this.cb_showX_CheckedChanged);
            // 
            // p_zAxis
            // 
            this.p_zAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_zAxis.BackColor = System.Drawing.Color.Green;
            this.p_zAxis.Location = new System.Drawing.Point(52, 196);
            this.p_zAxis.Name = "p_zAxis";
            this.p_zAxis.Size = new System.Drawing.Size(373, 70);
            this.p_zAxis.TabIndex = 1;
            // 
            // p_yAxis
            // 
            this.p_yAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_yAxis.BackColor = System.Drawing.Color.Green;
            this.p_yAxis.Location = new System.Drawing.Point(52, 106);
            this.p_yAxis.Name = "p_yAxis";
            this.p_yAxis.Size = new System.Drawing.Size(373, 70);
            this.p_yAxis.TabIndex = 1;
            // 
            // p_xAxis
            // 
            this.p_xAxis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_xAxis.BackColor = System.Drawing.Color.Green;
            this.p_xAxis.Location = new System.Drawing.Point(52, 16);
            this.p_xAxis.Name = "p_xAxis";
            this.p_xAxis.Size = new System.Drawing.Size(373, 70);
            this.p_xAxis.TabIndex = 0;
            // 
            // p_trafficLight
            // 
            this.p_trafficLight.Controls.Add(this.checkBox1);
            this.p_trafficLight.Controls.Add(this.label6);
            this.p_trafficLight.Controls.Add(this.cb_tlAxisSelect);
            this.p_trafficLight.Controls.Add(this.p_red);
            this.p_trafficLight.Controls.Add(this.p_yellow);
            this.p_trafficLight.Controls.Add(this.p_green);
            this.p_trafficLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_trafficLight.Location = new System.Drawing.Point(3, 16);
            this.p_trafficLight.Name = "p_trafficLight";
            this.p_trafficLight.Size = new System.Drawing.Size(997, 304);
            this.p_trafficLight.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(193, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Ampel in eigenem Fenster anzeigen";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Achse für Ampel-Anzeige:";
            // 
            // cb_tlAxisSelect
            // 
            this.cb_tlAxisSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_tlAxisSelect.FormattingEnabled = true;
            this.cb_tlAxisSelect.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cb_tlAxisSelect.Location = new System.Drawing.Point(15, 247);
            this.cb_tlAxisSelect.Name = "cb_tlAxisSelect";
            this.cb_tlAxisSelect.Size = new System.Drawing.Size(136, 21);
            this.cb_tlAxisSelect.TabIndex = 22;
            this.cb_tlAxisSelect.SelectedIndexChanged += new System.EventHandler(this.cb_tlAxisSelect_SelectedIndexChanged);
            // 
            // p_red
            // 
            this.p_red.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_red.BackColor = System.Drawing.Color.Red;
            this.p_red.Location = new System.Drawing.Point(385, 203);
            this.p_red.Name = "p_red";
            this.p_red.Size = new System.Drawing.Size(220, 91);
            this.p_red.TabIndex = 1;
            // 
            // p_yellow
            // 
            this.p_yellow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_yellow.BackColor = System.Drawing.Color.Yellow;
            this.p_yellow.Location = new System.Drawing.Point(385, 106);
            this.p_yellow.Name = "p_yellow";
            this.p_yellow.Size = new System.Drawing.Size(220, 91);
            this.p_yellow.TabIndex = 1;
            // 
            // p_green
            // 
            this.p_green.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_green.BackColor = System.Drawing.Color.Green;
            this.p_green.Location = new System.Drawing.Point(385, 10);
            this.p_green.Name = "p_green";
            this.p_green.Size = new System.Drawing.Size(220, 91);
            this.p_green.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb_axis_marking
            // 
            this.cb_axis_marking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_axis_marking.FormattingEnabled = true;
            this.cb_axis_marking.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.cb_axis_marking.Location = new System.Drawing.Point(339, 164);
            this.cb_axis_marking.Name = "cb_axis_marking";
            this.cb_axis_marking.Size = new System.Drawing.Size(80, 21);
            this.cb_axis_marking.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(336, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Markierung:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 559);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Institut Jansenberger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_settings.ResumeLayout(false);
            this.gb_settings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.p_2DAxis.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.p_axisChart.ResumeLayout(false);
            this.gb_Diagramm.ResumeLayout(false);
            this.gb_Diagramm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.gb_allAxis.ResumeLayout(false);
            this.p_trafficLight.ResumeLayout(false);
            this.p_trafficLight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_settings;
        private System.Windows.Forms.TextBox t_thresZ;
        private System.Windows.Forms.TextBox t_thresY;
        private System.Windows.Forms.TextBox t_thresX;
        private System.Windows.Forms.Label l_thresZ;
        private System.Windows.Forms.Label l_thresY;
        private System.Windows.Forms.Label l_thresX;
        internal System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox cb_ports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schließenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.TextBox timer_intervall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel p_trafficLight;
        private System.Windows.Forms.Panel p_red;
        private System.Windows.Forms.Panel p_yellow;
        private System.Windows.Forms.Panel p_green;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_tlAxisSelect;
        private System.Windows.Forms.CheckBox cb_reverseTL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_counter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_graphType;
        private System.Windows.Forms.Panel p_axisChart;
        private System.Windows.Forms.GroupBox gb_Diagramm;
        private System.Windows.Forms.TextBox tb_intervall_X;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_lengthXAxis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox gb_allAxis;
        private System.Windows.Forms.Panel p_zAxis;
        private System.Windows.Forms.Panel p_yAxis;
        private System.Windows.Forms.Panel p_xAxis;
        private System.Windows.Forms.Panel p_2DAxis;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.CheckBox cb_showZ;
        private System.Windows.Forms.CheckBox cb_showY;
        private System.Windows.Forms.CheckBox cb_showX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox t_maxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_minX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_maxY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t_minY;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cb_XDot;
        private System.Windows.Forms.CheckBox cb_YDot;
        private System.Windows.Forms.CheckBox cb_ZDot;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button saveCSVButton;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox tb_contCSVPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox cb_minMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_axis_marking;
    }
}

