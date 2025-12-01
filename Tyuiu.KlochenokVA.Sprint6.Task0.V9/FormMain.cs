using Tyuiu.KlochenokVA.Sprint6.Task0.V9.Lib;

namespace Tyuiu.KlochenokVA.Sprint6.Task0.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_KVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПб-25-1 Клоченок Владимир Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int x = Convert.ToInt32(textBoxX_KVA.Text);
                double result = ds.Calculate(x);
                textBoxResult_KVA.Text = result.ToString("F3");
            }
            catch (Exception)
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxTask_KVA_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBoxTask_KVA_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxResult_KVA_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
