using Tyuiu.KlochenoKVA.Sprint6.Task6.V8.Lib;
namespace Tyuiu.KlochenoKVA.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonHelp_KVA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void buttonDone_KVA_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOut_KVA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_KVA_Click(object sender, EventArgs e)
        {
            openFileDialog_KVA.ShowDialog();
            openFilePath = openFileDialog_KVA.FileName;
            textBoxIn_KVA.Text = File.ReadAllText(openFilePath);
            textBoxPath_KVA.Text = textBoxPath_KVA.Text + " " + openFileDialog_KVA.FileName;
            buttonDone_KVA.Enabled = true;
        }
    }
}
