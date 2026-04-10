using System;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;
using Tyuiu.KlochenokVA.Sprint6.Task1.V21.Lib;

namespace Tyuiu.KlochenokVA.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private string CenterText(string text, int width)
        {
            if (text.Length >= width) return text;
            int left = (width - text.Length) /2;
            int right = width - text.Length - left;
            return new string(' ', left) + text + new string(' ', right);
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
                var sb = new System.Text.StringBuilder();
                var ci = new CultureInfo("ru-RU");

                int col1 =11; // width for X column
                int col2 =12; // width for f(x) column

                sb.AppendLine("+-----------+------------+");
                sb.AppendLine("|" + CenterText("X", col1) + "|" + CenterText("f(x)", col2) + "|");
                sb.AppendLine("+-----------+------------+");

                int idx =0;
                for (int x = start; x <= stop; x++)
                {
                    string xs = x.ToString();
                    string fs = values[idx].ToString("F2", ci);
                    sb.AppendLine("|" + CenterText(xs, col1) + "|" + CenterText(fs, col2) + "|");
                    idx++;
                }

                sb.AppendLine("+-----------+------------+");

                textBoxResult_KVA.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при вычислении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
