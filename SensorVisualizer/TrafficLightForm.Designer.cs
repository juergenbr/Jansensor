namespace SensorVisualizer
{
    partial class TrafficLightForm
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
            this.trafficLightPanel = new System.Windows.Forms.Panel();
            this.p_red = new System.Windows.Forms.Panel();
            this.p_yellow = new System.Windows.Forms.Panel();
            this.p_green = new System.Windows.Forms.Panel();
            this.trafficLightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // trafficLightPanel
            // 
            this.trafficLightPanel.Controls.Add(this.p_red);
            this.trafficLightPanel.Controls.Add(this.p_yellow);
            this.trafficLightPanel.Controls.Add(this.p_green);
            this.trafficLightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafficLightPanel.Location = new System.Drawing.Point(0, 0);
            this.trafficLightPanel.Name = "trafficLightPanel";
            this.trafficLightPanel.Size = new System.Drawing.Size(284, 501);
            this.trafficLightPanel.TabIndex = 1;
            this.trafficLightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.trafficLightPanel_Paint);
            // 
            // p_red
            // 
            this.p_red.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_red.BackColor = System.Drawing.Color.Red;
            this.p_red.Location = new System.Drawing.Point(90, 306);
            this.p_red.Name = "p_red";
            this.p_red.Size = new System.Drawing.Size(120, 120);
            this.p_red.TabIndex = 4;
            // 
            // p_yellow
            // 
            this.p_yellow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_yellow.BackColor = System.Drawing.Color.Yellow;
            this.p_yellow.Location = new System.Drawing.Point(90, 166);
            this.p_yellow.Name = "p_yellow";
            this.p_yellow.Size = new System.Drawing.Size(120, 120);
            this.p_yellow.TabIndex = 3;
            // 
            // p_green
            // 
            this.p_green.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.p_green.BackColor = System.Drawing.Color.Green;
            this.p_green.Location = new System.Drawing.Point(90, 26);
            this.p_green.Name = "p_green";
            this.p_green.Size = new System.Drawing.Size(120, 120);
            this.p_green.TabIndex = 2;
            // 
            // TrafficLightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 501);
            this.ControlBox = false;
            this.Controls.Add(this.trafficLightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrafficLightForm";
            this.ShowInTaskbar = false;
            this.Text = "Ampel";
            this.Load += new System.EventHandler(this.TrafficLightForm_Load);
            this.trafficLightPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel trafficLightPanel;
        public System.Windows.Forms.Panel p_red;
        public System.Windows.Forms.Panel p_yellow;
        public System.Windows.Forms.Panel p_green;
    }
}