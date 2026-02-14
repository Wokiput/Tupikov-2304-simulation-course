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

        private double y0, x, y, v0, alpha, sina, cosa, t, S, m, k, vx, vy, vx_new, vy_new, ymax=-1;

        private int SeriesCounter = 0;

        private const double g = 9.8;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string data = "=== New Series - " + SeriesCounter + " ===\n"; //начало записи в строку для файла с данными по каждому графику
            //подготовкадля создания новых траекотрий на графике
            string SeriesName = $"series{SeriesCounter}";
            Series newSeries = new Series(SeriesName);
            newSeries.Color = Color.FromArgb((SeriesCounter * 60) % 255, (SeriesCounter * 80) % 255, (SeriesCounter * 110) % 255);
            newSeries.ChartType = SeriesChartType.Line;
            newSeries.BorderWidth = 2;
            //считывание данных с формы
            double dt = (double)cB_dt.SelectedItem;
            y0 = (double)nUD_height.Value;
            alpha = (double)nUD_angle.Value;
            S = (double)nUD_size.Value;
            m = (double)nUD_weight.Value;
            v0 = (double)nUD_speed.Value;
            ymax = 0;
            data += "y0 = " + y0 + "    alpha = " + alpha + "\nS = " + S + "    m = " + m + "   v0 = " + v0 + "\ndt = " + dt; //дозапись данных в строку
            //расчёт точек для графика
            sina = Math.Sin(alpha * Math.PI / 180);
            cosa = Math.Cos(alpha * Math.PI / 180);
            k = 0.15 * S * 1.29 / (2 * m);
            t = 0; x = 0; y = 0;
            newSeries.Points.AddXY(x, y);
            vx_new = v0 * cosa; vy_new = v0 * sina;
            do
            {
                if (ymax < y) ymax = y; //поиск максимальной высоты
                t += dt;
                vx = vx_new; vy = vy_new;
                double v = Math.Sqrt(vx * vx + vy * vy);
                vx_new = vx - k * vx * v * dt;
                vy_new = vy - (g + k * vy * v) * dt;
                x += vx * dt;
                y += vy * dt;
                newSeries.Points.AddXY(x, y);
            } while (y > 0);
            data += "\nx = " + x + "    ymax = " + ymax + " v = " + Math.Sqrt(vx * vx + vy * vy) + "\n"; //дозапись данных в строку
            //при апроксимации получается, что x и v - примерно равны x и v в конечной точке расчётов (когда y->0)
            data += new string('=', 30) + "\n\n";
            chart1.Series.Add(newSeries); //отрисовка графика
            SeriesCounter++;
            File.AppendAllText(@"..\..\..\..\data.txt", data, System.Text.Encoding.UTF8); //запись строки с данными в файл
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