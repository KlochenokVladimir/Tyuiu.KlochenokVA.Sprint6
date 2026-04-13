using Tyuiu.KlochenoKVA.Sprint6.Task2.V27.Lib;
namespace Tyuiu.KlochenoKVA.Sprint6.Task2.V27
{
    public partial class FormMain_KVA : Form
    {
        public FormMain_KVA()
        {
            InitializeComponent();
        }


        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KVA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_KVA.Text);

                // получаем настоящий массив значений
                double[] valueArray = ds.GetMassFunction(startStep, stopStep);

                this.DataGridView_KVA.Rows.Clear();
                this.chart_KVA.Series[0].Points.Clear();

                this.chart_KVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart_KVA.ChartAreas[0].AxisY.Title = "Ось Y";

                int x = startStep;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    this.DataGridView_KVA.Rows.Add(x.ToString(), valueArray[i].ToString());
                    this.chart_KVA.Series[0].Points.AddXY(x, valueArray[i]);
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-25-1 Клоченок Владимир Алексеевич");
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonDone_KVA.BackColor = Color.Purple;
        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KVA.BackColor = Color.White;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KVA.BackColor = Color.Green;

        }

        private void FormMain_KVA_Load(object sender, EventArgs e)
        {

        }
    }
}
