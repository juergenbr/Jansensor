using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorVisualizer
{
    public partial class TrafficLightForm : Form
    {

        // Colors
        private static Color green = ColorTranslator.FromHtml("#4CAF50");
        private static Color yellow = ColorTranslator.FromHtml("#FFC107");
        private static Color red = ColorTranslator.FromHtml("#F4511E");

        public TrafficLightForm()
        {
            InitializeComponent();
        }

        private void TrafficLightForm_Load(object sender, EventArgs e)
        {
            p_green.BackColor = green;
            p_yellow.BackColor = yellow;
            p_red.BackColor = red;
        }

        public void reset()
        {
            p_green.BackColor = green;
            p_yellow.BackColor = yellow;
            p_red.BackColor = red;
        }

        private void trafficLightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
