using System.Windows.Forms.VisualStyles;
using Tyuiu.KlochenoKVA.Sprint6.Task4.V29.Lib;

namespace Tyuiu.KlochenoKVA.Sprint6.Task4.V29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Шакиров Сергей Александрович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart.Text);
                int stop = Convert.ToInt32(textBoxStop.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] array;
                array = new double[len];
                array = ds.GetMassFunction(start, stop);
                this.chartGraph.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraph.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult.Text = "";
                chartGraph.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartGraph.Series[0].Points.AddXY(start, array[i]);
                    textBoxResult.AppendText(array[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V29.txt");
                File.WriteAllText(path, textBoxResult.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
