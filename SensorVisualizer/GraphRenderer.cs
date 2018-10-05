using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SensorVisualizer
{
    class GraphRenderer
    {
        // Colors
        private static Color green = ColorTranslator.FromHtml("#4CAF50");
        private static Color yellow = ColorTranslator.FromHtml("#FFC107");
        private static Color red = ColorTranslator.FromHtml("#F4511E");
        //variables for 3-Axis Graph
        private int panel_max_width;

        //rectagle for Dot graph
        RectangleF r1 = new RectangleF();

        public int Panel_max_width
        {
            get { return panel_max_width; }
            set { panel_max_width = value; }
        }
        private float X_axis_panel_width_factor;
        private float Y_axis_panel_width_factor;
        private float Z_axis_panel_width_factor;
        private int length_X_axis = 50;

        //panels

        public int Length_X_axis
        {
            get { return length_X_axis; }
            set { length_X_axis = value; }
        }
        private int intervall_X_axis = 2;

        public int Intervall_X_axis
        {
            get { return intervall_X_axis; }
            set { intervall_X_axis = value; }
        }
        
        //Method to initialize graph panels
        public void resetPanels(Panel p_green, Panel p_yellow, Panel p_red, Panel p_xAxis, Panel p_yAxis, Panel p_zAxis, Chart chart1, Chart chart2, TrafficLightForm tlForm, TextBox txtReceived)
        {
            txtReceived.Clear();

            p_xAxis.Width = panel_max_width;
            p_xAxis.BackColor = green;
            p_yAxis.Width = panel_max_width;
            p_yAxis.BackColor = green;
            p_zAxis.Width = panel_max_width;
            p_zAxis.BackColor = green;

            p_green.BackColor = Color.FromName("Component");
            p_yellow.BackColor = Color.FromName("Component");
            p_red.BackColor = Color.FromName("Component");

            X_axis_panel_width_factor = 0;
            Y_axis_panel_width_factor = 0;
            Z_axis_panel_width_factor = 0;

            if (tlForm != null)
                tlForm.reset();

            //save chart
            //string exePath = AppDomain.CurrentDomain.BaseDirectory;
            //this.chart1.SaveImage(exePath+DateTime.Now+"_chart.png", ChartImageFormat.Png);

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            chart1.Annotations.Clear();
            chart2.Annotations.Clear();
        }
        
        //method to render traffic light depending on threshold value entered
        public void renderTrafficLight(bool reverseTL, float x_value, float thresX, float thresY, float thresZ, Panel p_green, Panel p_yellow, Panel p_red)
        {
            Color low;
            Color mid;
            Color high;
            Color neutral = Color.LightGray;


            if (reverseTL)
            {            //if CB is checked, reverse the colors
                low = red;
                mid = yellow;
                high = green;
            }
            else
            {
                low = green;
                mid = yellow;
                high = red;
            }

                if (x_value < 0)
                    x_value = x_value * -1;

                if (x_value <= thresX)     //green panel lights up
                {
                    p_green.BackColor = low;
                    p_yellow.BackColor = neutral;
                    p_red.BackColor = neutral;
                }
                else if (x_value > thresX && x_value <= thresY)
                {
                    p_green.BackColor = neutral;
                    p_yellow.BackColor = mid;
                    p_red.BackColor = neutral;
                }
                else if (x_value >= thresY && x_value < thresZ)
                {
                    p_green.BackColor = neutral;
                    p_yellow.BackColor = mid;
                    p_red.BackColor = high;
                }
                else if (x_value > thresZ)
                {
                    p_green.BackColor = neutral;
                    p_yellow.BackColor = neutral;
                    p_red.BackColor = high;
                    SystemSounds.Beep.Play();
                }

                return;
            }

        
        //method to render dot graph
        public void renderDotGraph(float x_value, float y_value, int thres_x, int thres_y, Chart chart)
        {
            if (x_value > thres_x && y_value <= thres_y)
            {
                SystemSounds.Beep.Play();
            }
            else if (x_value <= thres_x && y_value > thres_y)
            {
                SystemSounds.Beep.Play();
            }
            else if (x_value > thres_x && y_value > thres_y)
            {
                SystemSounds.Beep.Play();
            }
                // min value
            else if (x_value < 0 - thres_x && y_value >= 0 - thres_y)
            {
                SystemSounds.Beep.Play();
            }
            else if (x_value >= 0 - thres_x && y_value < 0 - thres_y)
            {
                SystemSounds.Beep.Play();
            }
            else if (x_value < 0 - thres_x && y_value < 0 - thres_y)
            {
                SystemSounds.Beep.Play();
            }
            UpdateDotChart(chart, 0, x_value, y_value);
        }
        
        //method to render 3-Axis Graphs
        public void render3AxisGraph(float x_value, float y_value, float z_value, Panel p_xAxis, Panel p_yAxis, Panel p_zAxis, Chart chart1, int count, bool showX, bool showY, bool showZ)
        {
            float x_value_orig = x_value;
            float y_value_orig = y_value;
            float z_value_orig = z_value;
            
            //normalize negative values
            if (x_value < 0)
                x_value = x_value * -1;

            if (y_value < 0)
                y_value = y_value * -1;

            if (z_value < 0)
                z_value = z_value * -1;

            int panelWidth_x = (int)Math.Ceiling(x_value * X_axis_panel_width_factor);
            int panelWidth_y = (int)Math.Ceiling(y_value * Y_axis_panel_width_factor);
            int panelWidth_z = (int)Math.Ceiling(z_value * Z_axis_panel_width_factor);

            //render X Bar
            if (showX)
            {
                if (panelWidth_x < panel_max_width)
                    UpdatePanel(p_xAxis, panelWidth_x);
                else
                {
                    UpdatePanel(p_xAxis, panel_max_width);
                    SystemSounds.Beep.Play();
                }
                //render X Line Chart
                
                
            }


            if (showY)
            {
                if (panelWidth_y < panel_max_width)
                    UpdatePanel(p_yAxis, panelWidth_y);
                else
                {
                    UpdatePanel(p_yAxis, panel_max_width);
                    SystemSounds.Beep.Play();
                }
                //render Z Line Chart
                UpdateChart(chart1, 1, count, y_value_orig);
            }

            if (showZ)
            {
                if (panelWidth_z < panel_max_width)
                    UpdatePanel(p_zAxis, panelWidth_z);
                else
                {
                    UpdatePanel(p_zAxis, panel_max_width);
                    SystemSounds.Beep.Play();
                }
                //render Y Line Chart
                UpdateChart(chart1, 2, count, z_value_orig);
            }
        }

        public void UpdatePanel(Panel p, int width)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (ControlInvokeRequired(p, () => UpdatePanel(p, width))) return;
            p.Width = width;
            if (width == panel_max_width)
                p.BackColor = red;
            else
                p.BackColor = green;
        }

        public void UpdateChart(Chart c, int series, float x_value, float y_value)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (ControlInvokeRequired(c, () => UpdateChart(c, series, x_value, y_value))) return;
            c.Series[series].Points.AddXY(x_value, y_value);
        }

        public void UpdateDotChart(Chart c, int series, float x_value, float y_value)
        {
            //Check if invoke requied if so return - as i will be recalled in correct thread
            if (ControlInvokeRequired(c, () => UpdateDotChart(c, series, x_value, y_value))) return;
            c.Series[0].Points.Clear();
            c.Series[series].Points.AddXY(x_value, y_value);
        }

        public bool ControlInvokeRequired(Control c, Action a)
        {
            if (c.InvokeRequired) c.Invoke(new MethodInvoker(delegate { a(); }));
            else return false;

            return true;
        }


        //Chart
        public bool setupAxisChart(float thresX, float thresY, float thresZ, int lengthXAxis, int intervall_X, Chart chart1, int marking_value)
        {
            X_axis_panel_width_factor = panel_max_width / thresX;
            Y_axis_panel_width_factor = panel_max_width / thresY;
            Z_axis_panel_width_factor = panel_max_width / thresZ;
            
            ChartArea ca = chart1.ChartAreas[0];
            intervall_X_axis = intervall_X;
            length_X_axis = lengthXAxis;
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = length_X_axis;
            ca.AxisY.Maximum = Double.NaN;
            ca.AxisY.Minimum = Double.NaN;
            // Set automatic scrolling 
            ca.CursorX.AutoScroll = true;
            ca.AxisX.ScrollBar.Enabled = true;
            ca.AxisX.MajorGrid.Interval = intervall_X_axis;
            ca.AxisX.Interval = intervall_X_axis;

            HorizontalLineAnnotation max = new HorizontalLineAnnotation();
            max.AxisY = ca.AxisY;
            max.AnchorY = marking_value;

            max.IsInfinitive = true;
            max.LineColor = Color.Red;
            max.LineWidth = 2;
            chart1.Annotations.Add(max);

            HorizontalLineAnnotation min = new HorizontalLineAnnotation();
            min.AxisY = ca.AxisY;
            min.AnchorY = 0 - marking_value;

            min.IsInfinitive = true;
            min.LineColor = Color.Red;
            min.LineWidth = 2;
            chart1.Annotations.Add(min);

            return true;
        }

        public void setupDotChart(Chart chart, int minX, int maxX, int minY, int maxY, int thresX, int thresY)
        {
            ChartArea ca = chart.ChartAreas[0];
            // Set automatic scrolling 
            ca.CursorX.AutoScroll = true;
            ca.AxisX.ScrollBar.Enabled = true;

            chart.Series[0].MarkerSize = 20;
            chart.Series[0].MarkerStyle = MarkerStyle.Circle;
            if (maxY < minY)
            {
                ca.AxisY.IsReversed = true;
                ca.AxisY.Minimum = maxY;
                ca.AxisY.Maximum = minY;
            }
            else
            {
                ca.AxisY.Minimum = minY;
                ca.AxisY.Maximum = maxY;
            }
            
            ca.AxisY.MajorGrid.Interval = 200;
            ca.AxisY.Interval = 200;
            ca.AxisY.MinorGrid.Interval = 50;
            ca.AxisY.MinorGrid.LineDashStyle = ChartDashStyle.Dash;

            if (maxX < minX)
            {
                ca.AxisX.IsReversed = true;
                ca.AxisX.Minimum = maxX;
                ca.AxisX.Maximum = minX;
            }
            else
            {
                ca.AxisX.Minimum = minX;
                ca.AxisX.Maximum = maxX;
            }
            ca.AxisX.MajorGrid.Interval = 200;
            ca.AxisX.Interval = 200;
            ca.AxisX.MinorGrid.Interval = 50;
            ca.AxisX.MinorGrid.LineDashStyle = ChartDashStyle.Dash;

            
            HorizontalLineAnnotation ymax = new HorizontalLineAnnotation();
            ymax.AxisY = ca.AxisY;
            ymax.AnchorY = thresY;
            ymax.IsInfinitive = true;
            ymax.LineColor = Color.Red;
            ymax.LineWidth = 2;
            chart.Annotations.Add(ymax);

            HorizontalLineAnnotation ymin = new HorizontalLineAnnotation();
            ymin.AxisY = ca.AxisY;
            ymin.AnchorY = 0 - thresY;
            ymin.IsInfinitive = true;
            ymin.LineColor = Color.Red;
            ymin.LineWidth = 2;
            chart.Annotations.Add(ymin);

            VerticalLineAnnotation xmax = new VerticalLineAnnotation();
            xmax.AxisX = ca.AxisX;
            xmax.AnchorX = thresX;
            xmax.IsInfinitive = true;
            xmax.LineColor = Color.Red;
            xmax.LineWidth = 2;
            chart.Annotations.Add(xmax);

            VerticalLineAnnotation xmin = new VerticalLineAnnotation();
            xmin.AxisX = ca.AxisX;
            xmin.AnchorX = 0 - thresX;
            xmin.IsInfinitive = true;
            xmin.LineColor = Color.Red;
            xmin.LineWidth = 2;
            chart.Annotations.Add(xmin);

            //this.drawThesholdRectangle(chart, thresX, thresY);
        }

     }
 }
