using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using Tyuiu.KlochenokVA.Sprint6.Task2.V27.Lib;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            EnsureChart();
        }

        private void EnsureChart()
        {
            if (chart_KVA == null)
            {
                chart_KVA = new Chart();
                chart_KVA.Name = "chart_KVA";
                chart_KVA.Location = new Point(270,38);
                chart_KVA.Size = new Size(320,237);
                var chartArea = new ChartArea("ChartArea1");
                chart_KVA.ChartAreas.Add(chartArea);
                var series = new Series("Series1") { ChartType = SeriesChartType.Line, ChartArea = "ChartArea1" };
                chart_KVA.Series.Add(series);
                groupBoxRes_KVA.Controls.Add(chart_KVA);
            }
            else
            {
                if (chart_KVA.ChartAreas.Count ==0) chart_KVA.ChartAreas.Add(new ChartArea("ChartArea1"));
                if (chart_KVA.Series.Count ==0) chart_KVA.Series.Add(new Series("Series1") { ChartType = SeriesChartType.Line, ChartArea = "ChartArea1" });
            }
        }

        private void buttonHelp_KVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Табулирование функции F(x) на диапазоне с шагом1. F(x)=cos(x)+sin(x)/(2-2*x)-4*x. При делении на ноль возвращается0.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            var ds = new DataService();
            try
            {
                int start = -5;
                int stop =5;
                if (!string.IsNullOrWhiteSpace(textBoxStart_KVA.Text)) int.TryParse(textBoxStart_KVA.Text, out start);
                if (!string.IsNullOrWhiteSpace(textBoxStop_KVA.Text)) int.TryParse(textBoxStop_KVA.Text, out stop);

                var values = ds.GetMassFunction(start, stop);

                DataGridView_KVA.Rows.Clear();
                EnsureChart();
                chart_KVA.Series[0].Points.Clear();

                int idx =0;
                var ci = new CultureInfo("ru-RU");
                for (int x = start; x <= stop; x++)
                {
                    double v = values.Length > idx ? values[idx] :0.0;
                    string fs = v.ToString("F2", ci);
                    DataGridView_KVA.Rows.Add(x.ToString(), fs);
                    chart_KVA.Series[0].Points.AddXY(x, v);
                    idx++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при вычислении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
