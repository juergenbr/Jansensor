namespace SensorVisualizer
{
    partial class SaveCSVWindow
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
            this.p_csv = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.t_filepath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.p_csv.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_csv
            // 
            this.p_csv.Controls.Add(this.label2);
            this.p_csv.Controls.Add(this.t_filepath);
            this.p_csv.Controls.Add(this.button1);
            this.p_csv.Location = new System.Drawing.Point(12, 12);
            this.p_csv.Name = "p_csv";
            this.p_csv.Size = new System.Drawing.Size(353, 47);
            this.p_csv.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Speicherort für CSV Datei:";
            // 
            // t_filepath
            // 
            this.t_filepath.Location = new System.Drawing.Point(3, 21);
            this.t_filepath.Name = "t_filepath";
            this.t_filepath.Size = new System.Drawing.Size(259, 20);
            this.t_filepath.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Durchsuchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Abbrechen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // SaveCSVWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 100);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.p_csv);
            this.Name = "SaveCSVWindow";
            this.Text = "SaveCSVWindow";
            this.Load += new System.EventHandler(this.SaveCSVWindow_Load);
            this.p_csv.ResumeLayout(false);
            this.p_csv.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_csv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_filepath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}