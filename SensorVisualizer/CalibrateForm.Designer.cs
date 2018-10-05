namespace SensorVisualizer
{
    partial class CalibrateForm
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
            this.bt_calibrate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Ports = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Z = new System.Windows.Forms.CheckBox();
            this.cb_Y = new System.Windows.Forms.CheckBox();
            this.cb_X = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_calibrate
            // 
            this.bt_calibrate.Location = new System.Drawing.Point(197, 150);
            this.bt_calibrate.Name = "bt_calibrate";
            this.bt_calibrate.Size = new System.Drawing.Size(75, 23);
            this.bt_calibrate.TabIndex = 0;
            this.bt_calibrate.Text = "Kalibrieren";
            this.bt_calibrate.UseVisualStyleBackColor = true;
            this.bt_calibrate.Click += new System.EventHandler(this.btcalibrate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensor:";
            // 
            // cb_Ports
            // 
            this.cb_Ports.FormattingEnabled = true;
            this.cb_Ports.Location = new System.Drawing.Point(61, 15);
            this.cb_Ports.Name = "cb_Ports";
            this.cb_Ports.Size = new System.Drawing.Size(211, 21);
            this.cb_Ports.TabIndex = 2;
            this.cb_Ports.SelectedIndexChanged += new System.EventHandler(this.cbPorts_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Z);
            this.groupBox1.Controls.Add(this.cb_Y);
            this.groupBox1.Controls.Add(this.cb_X);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 93);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zu kalibrierende Achsen";
            // 
            // cb_Z
            // 
            this.cb_Z.AutoSize = true;
            this.cb_Z.Location = new System.Drawing.Point(6, 65);
            this.cb_Z.Name = "cb_Z";
            this.cb_Z.Size = new System.Drawing.Size(66, 17);
            this.cb_Z.TabIndex = 2;
            this.cb_Z.Text = "Z-Achse";
            this.cb_Z.UseVisualStyleBackColor = true;
            // 
            // cb_Y
            // 
            this.cb_Y.AutoSize = true;
            this.cb_Y.Location = new System.Drawing.Point(6, 42);
            this.cb_Y.Name = "cb_Y";
            this.cb_Y.Size = new System.Drawing.Size(66, 17);
            this.cb_Y.TabIndex = 1;
            this.cb_Y.Text = "Y-Achse";
            this.cb_Y.UseVisualStyleBackColor = true;
            // 
            // cb_X
            // 
            this.cb_X.AutoSize = true;
            this.cb_X.Location = new System.Drawing.Point(6, 19);
            this.cb_X.Name = "cb_X";
            this.cb_X.Size = new System.Drawing.Size(66, 17);
            this.cb_X.TabIndex = 0;
            this.cb_X.Text = "X-Achse";
            this.cb_X.UseVisualStyleBackColor = true;
            // 
            // CalibrateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_Ports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_calibrate);
            this.Name = "CalibrateForm";
            this.Text = "Sensor Kalibrierung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calibrate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Ports;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_Z;
        private System.Windows.Forms.CheckBox cb_Y;
        private System.Windows.Forms.CheckBox cb_X;
    }
}