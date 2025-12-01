namespace Tyuiu.KlochenokVA.Sprint6.Task0.V9
{
        partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_KVA = new GroupBox();
            textBoxTask_KVA = new TextBox();
            pictureBoxTask_KVA = new PictureBox();
            groupBoxInput_KVA = new GroupBox();
            labelX_KVA = new Label();
            textBoxX_KVA = new TextBox();
            groupBoxOutput_KVA = new GroupBox();
            textBoxResult_KVA = new TextBox();
            labelResult_KVA = new Label();
            buttonDone_KVA = new Button();
            buttonHelp_KVA = new Button();
            groupBoxTask_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_KVA).BeginInit();
            groupBoxInput_KVA.SuspendLayout();
            groupBoxOutput_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KVA
            // 
            groupBoxTask_KVA.BackColor = SystemColors.Control;
            groupBoxTask_KVA.Controls.Add(textBoxTask_KVA);
            groupBoxTask_KVA.Controls.Add(pictureBoxTask_KVA);
            groupBoxTask_KVA.Location = new Point(26, 21);
            groupBoxTask_KVA.Name = "groupBoxTask_KVA";
            groupBoxTask_KVA.Size = new Size(511, 191);
            groupBoxTask_KVA.TabIndex = 0;
            groupBoxTask_KVA.TabStop = false;
            groupBoxTask_KVA.Text = "Условие";
            groupBoxTask_KVA.Enter += this.groupBoxTask_KVA_Enter;
            // 
            // textBoxTask_KVA
            // 
            textBoxTask_KVA.BackColor = SystemColors.Control;
            textBoxTask_KVA.BorderStyle = BorderStyle.None;
            textBoxTask_KVA.Location = new Point(15, 22);
            textBoxTask_KVA.Multiline = true;
            textBoxTask_KVA.Name = "textBoxTask_KVA";
            textBoxTask_KVA.ReadOnly = true;
            textBoxTask_KVA.Size = new Size(280, 100);
            textBoxTask_KVA.TabIndex = 0;
            textBoxTask_KVA.Text = "Вычислить выражение по формуле";
            textBoxTask_KVA.TextChanged += this.textBoxTask_KVA_TextChanged;
            // 
            // pictureBoxTask_KVA
            // 
            pictureBoxTask_KVA.Image = (Image)resources.GetObject("pictureBoxTask_KVA.Image");
            pictureBoxTask_KVA.Location = new Point(301, 22);
            pictureBoxTask_KVA.Name = "pictureBoxTask_KVA";
            pictureBoxTask_KVA.Size = new Size(204, 163);
            pictureBoxTask_KVA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_KVA.TabIndex = 1;
            pictureBoxTask_KVA.TabStop = false;
            // 
            // groupBoxInput_KVA
            // 
            groupBoxInput_KVA.BackColor = SystemColors.Control;
            groupBoxInput_KVA.Controls.Add(labelX_KVA);
            groupBoxInput_KVA.Controls.Add(textBoxX_KVA);
            groupBoxInput_KVA.Location = new Point(26, 218);
            groupBoxInput_KVA.Name = "groupBoxInput_KVA";
            groupBoxInput_KVA.Size = new Size(195, 89);
            groupBoxInput_KVA.TabIndex = 2;
            groupBoxInput_KVA.TabStop = false;
            groupBoxInput_KVA.Text = "Ввод данных";
            // 
            // labelX_KVA
            // 
            labelX_KVA.AutoSize = true;
            labelX_KVA.Location = new Point(6, 29);
            labelX_KVA.Name = "labelX_KVA";
            labelX_KVA.Size = new Size(89, 15);
            labelX_KVA.TabIndex = 1;
            labelX_KVA.Text = "Переменная X:";
            // 
            // textBoxX_KVA
            // 
            textBoxX_KVA.Location = new Point(6, 47);
            textBoxX_KVA.Name = "textBoxX_KVA";
            textBoxX_KVA.Size = new Size(183, 23);
            textBoxX_KVA.TabIndex = 0;
            textBoxX_KVA.KeyPress += textBoxX_KVA_KeyPress;
            // 
            // groupBoxOutput_KVA
            // 
            groupBoxOutput_KVA.BackColor = SystemColors.Control;
            groupBoxOutput_KVA.Controls.Add(textBoxResult_KVA);
            groupBoxOutput_KVA.Controls.Add(labelResult_KVA);
            groupBoxOutput_KVA.Location = new Point(348, 218);
            groupBoxOutput_KVA.Name = "groupBoxOutput_KVA";
            groupBoxOutput_KVA.Size = new Size(189, 89);
            groupBoxOutput_KVA.TabIndex = 3;
            groupBoxOutput_KVA.TabStop = false;
            groupBoxOutput_KVA.Text = "Вывод данных";
            // 
            // textBoxResult_KVA
            // 
            textBoxResult_KVA.BackColor = SystemColors.Control;
            textBoxResult_KVA.BorderStyle = BorderStyle.None;
            textBoxResult_KVA.ForeColor = SystemColors.WindowText;
            textBoxResult_KVA.Location = new Point(6, 47);
            textBoxResult_KVA.Name = "textBoxResult_KVA";
            textBoxResult_KVA.ReadOnly = true;
            textBoxResult_KVA.Size = new Size(177, 16);
            textBoxResult_KVA.TabIndex = 1;
            textBoxResult_KVA.TextChanged += this.textBoxResult_KVA_TextChanged;
            // 
            // labelResult_KVA
            // 
            labelResult_KVA.AutoSize = true;
            labelResult_KVA.Location = new Point(6, 29);
            labelResult_KVA.Name = "labelResult_KVA";
            labelResult_KVA.Size = new Size(63, 15);
            labelResult_KVA.TabIndex = 0;
            labelResult_KVA.Text = "Результат:";
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.FlatStyle = FlatStyle.Popup;
            buttonDone_KVA.Location = new Point(402, 313);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(135, 43);
            buttonDone_KVA.TabIndex = 4;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = true;
            buttonDone_KVA.Click += this.buttonDone_KVA_Click;
            // 
            // buttonHelp_KVA
            // 
            buttonHelp_KVA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KVA.Location = new Point(348, 313);
            buttonHelp_KVA.Name = "buttonHelp_KVA";
            buttonHelp_KVA.Size = new Size(48, 43);
            buttonHelp_KVA.TabIndex = 5;
            buttonHelp_KVA.Text = "?";
            buttonHelp_KVA.UseVisualStyleBackColor = true;
            buttonHelp_KVA.Click += this.buttonHelp_KVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 370);
            Controls.Add(buttonHelp_KVA);
            Controls.Add(buttonDone_KVA);
            Controls.Add(groupBoxOutput_KVA);
            Controls.Add(groupBoxInput_KVA);
            Controls.Add(groupBoxTask_KVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 9 | Клоченок В. А.";
            groupBoxTask_KVA.ResumeLayout(false);
            groupBoxTask_KVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_KVA).EndInit();
            groupBoxInput_KVA.ResumeLayout(false);
            groupBoxInput_KVA.PerformLayout();
            groupBoxOutput_KVA.ResumeLayout(false);
            groupBoxOutput_KVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KVA;
        private TextBox textBoxTask_KVA;
        private PictureBox pictureBoxTask_KVA;
        private GroupBox groupBoxInput_KVA;
        private Label labelX_KVA;
        private TextBox textBoxX_KVA;
        private GroupBox groupBoxOutput_KVA;
        private TextBox textBoxResult_KVA;
        private Label labelResult_KVA;
        private Button buttonDone_KVA;
        private Button buttonHelp_KVA;

        private void textBoxX_KVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем только цифры, точку, минус и клавиши управления
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
