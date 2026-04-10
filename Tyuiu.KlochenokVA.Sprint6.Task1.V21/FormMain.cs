using System;
using System.Windows.Forms;
using System.Drawing;
using Tyuiu.KlochenokVA.Sprint6.Task1.V21.Lib;

namespace Tyuiu.KlochenokVA.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_KVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСПб-25-1 Клоченок В. А.");
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            var ds = new DataService();
            try
            {
                int start = -5;
                int stop =5;
                // если пользователь ввёл значения, попытаемся их распарсить
                if (!string.IsNullOrWhiteSpace(textBoxStart_KVA.Text)) int.TryParse(textBoxStart_KVA.Text, out start);
                if (!string.IsNullOrWhiteSpace(textBoxStop_KVA.Text)) int.TryParse(textBoxStop_KVA.Text, out stop);

                var values = ds.GetMassFunction(start, stop);
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("x\tF(x)");
                int idx =0;
                for (int x = start; x <= stop; x++)
                {
                    sb.AppendLine($"{x}\t{values[idx]:F2}");
                    idx++;
                }
                textBoxResult_KVA.Text = sb.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при вычислении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
