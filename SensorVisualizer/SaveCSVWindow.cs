using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SensorVisualizer
{
    public partial class SaveCSVWindow : Form
    {

        // CSV Output

        private static string default_csv = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Auswertung_" + DateTime.Today.ToString("ddMMyyy") + ".csv";
        private string csv_path;
        private StreamWriter swOutput;
        private StringBuilder buf;


        public SaveCSVWindow()
        {
            InitializeComponent();
        }

        public SaveCSVWindow(StringBuilder buffer)
        {
            InitializeComponent();
            this.buf = buffer;
        }

        private void SaveCSVWindow_Load(object sender, EventArgs e)
        {
            t_filepath.Text = default_csv;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            saveFileDialog1.Filter = "CSV Datei|*.csv";
            saveFileDialog1.Title = "Auswertung als CSV speichern";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            csv_path = saveFileDialog1.FileName;
            t_filepath.Text = csv_path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = t_filepath.Text;
            if (File.Exists(filepath))
                filepath.Replace(".csv", "_1.csv");
            
            swOutput = new StreamWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write, FileShare.Read));
            swOutput.WriteLine(buf.ToString());

            buf.Clear();
            swOutput.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
