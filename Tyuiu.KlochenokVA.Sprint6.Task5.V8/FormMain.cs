using System.Diagnostics;
using Tyuiu.KlochenoKVA.Sprint6.Task5.V8.Lib;
namespace Tyuiu.KlochenoKVA.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\PC\source\repos\ttt\InPutDataFileTask5V8.txt";

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            dataGridViewVivod_KVA.ColumnCount = 2;
            dataGridViewVivod_KVA.Columns[0].Width = 30;
            dataGridViewVivod_KVA.Columns[1].Width = 60;
            this.chartFunction_KVA.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartFunction_KVA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_KVA.Series[0].Points.Clear();
            double[] num = new double[ds.len];
            num = ds.LoadFromDataFile(path);
            for (int i = 0; i < num.Length; i++)
            {
                dataGridViewVivod_KVA.Rows.Add(Convert.ToString(i), Convert.ToString(num[i]));
                chartFunction_KVA.Series[0].Points.AddXY(i, -num[i]);
            }

        }

        private void buttonOtkrFile_KVA_Click(object sender, EventArgs e)
        {
            Process txt = new Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_KVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-25-1 Клоченок Владимир Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
