using Microsoft.VisualBasic.Logging;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsApp1
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
            InitializePrecisionSelector();
            chart1.Series.Clear();
        }

        private double y0, x, y, v0, alpha, sina, cosa, t, S, m, k, vx, vy, ymax;

        private static int SeriesCounter = 0;
        private Series newSeries;
        private const double g = 9.8;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                newSeries = new Series($"series{SeriesCounter}");
                string data = "=== New Series - " + SeriesCounter + " ===\n";
                newSeries.Color = Color.FromArgb((SeriesCounter * 60) % 255, (SeriesCounter * 80) % 255, (SeriesCounter * 110) % 255);
                newSeries.ChartType = SeriesChartType.Line;
                newSeries.BorderWidth = 2;
                double dt = (double)cB_dt.SelectedItem;
                y0 = (double)nUD_height.Value;
                alpha = (double)nUD_angle.Value;
                S = (double)nUD_size.Value;
                m = (double)nUD_weight.Value;
                v0 = (double)nUD_speed.Value;
                ymax = 0;
                data += "y0 = " + y0 + "    alpha = " + alpha + "\nS = " + S + "    m = " + m + "   v0 = " + v0 + "\ndt = " + dt;
                sina = Math.Sin(alpha * Math.PI / 180);
                cosa = Math.Cos(alpha * Math.PI / 180);
                k = 0.15 * S * 1.29 / (2 * m);
                t = 0; x = 0; y = y0;
                newSeries.Points.AddXY(x, y0);
                vx = v0 * cosa; vy = v0 * sina;
                chart1.Series.Add(newSeries);
                timer1.Start();
                data += "\nx = " + x + "    ymax = " + ymax + " v = " + Math.Sqrt(vx * vx + vy * vy) + "\n";
                data += new string('=', 30) + "\n\n";
                SeriesCounter++;
                File.AppendAllText(@"..\..\..\..\data.txt", data, System.Text.Encoding.UTF8);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ymax <= y) ymax = y;
            t += (double)cB_dt.SelectedItem;
            double v = (double)Math.Sqrt((double)(vx * vx + vy * vy));
            vx = vx - k * vx * v * (double)cB_dt.SelectedItem;
            vy = vy - (g + k * vy * v) * (double)cB_dt.SelectedItem;
            x = x + vx * (double)cB_dt.SelectedItem;
            y = y + vy * (double)cB_dt.SelectedItem;
            newSeries.Points.AddXY(x, y);
            if (y <= 0) timer1.Stop();
        }
        private void InitializePrecisionSelector()
        {
            cB_dt.Items.Clear();
            cB_dt.Items.Add(1.0);
            cB_dt.Items.Add(0.1);
            cB_dt.Items.Add(0.01);
            cB_dt.Items.Add(0.001);
            cB_dt.Items.Add(0.0001);
            cB_dt.SelectedIndex = 0;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            SeriesCounter = 0;
            chart1.Series.Clear();
        }
    }
}
