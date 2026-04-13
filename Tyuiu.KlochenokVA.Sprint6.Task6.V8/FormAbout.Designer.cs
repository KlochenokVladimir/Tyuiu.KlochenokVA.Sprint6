namespace Tyuiu.KlochenoKVA.Sprint6.Task6.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxabout_KVA = new TextBox();
            buttonAbout_KVA = new Button();
            SuspendLayout();
            // 
            // textBoxabout_KVA
            // 
            textBoxabout_KVA.BackColor = SystemColors.MenuBar;
            textBoxabout_KVA.BorderStyle = BorderStyle.None;
            textBoxabout_KVA.Location = new Point(12, 12);
            textBoxabout_KVA.Multiline = true;
            textBoxabout_KVA.Name = "textBoxabout_KVA";
            textBoxabout_KVA.ReadOnly = true;
            textBoxabout_KVA.Size = new Size(241, 114);
            textBoxabout_KVA.TabIndex = 1;
            textBoxabout_KVA.Text = "Разработчик: Клоченок В. А.\r\nгруппа ИСПб-25-1\r\n\r\nТюменский индустриальный университет 2026\r\nВысшая школа цифровых технологий 2026\r\n\r\n\r\n";
            // 
            // buttonAbout_KVA
            // 
            buttonAbout_KVA.Location = new Point(178, 132);
            buttonAbout_KVA.Name = "buttonAbout_KVA";
            buttonAbout_KVA.Size = new Size(75, 23);
            buttonAbout_KVA.TabIndex = 2;
            buttonAbout_KVA.Text = "Ок";
            buttonAbout_KVA.UseVisualStyleBackColor = true;
            buttonAbout_KVA.Click += buttonAbout_KVA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 168);
            Controls.Add(buttonAbout_KVA);
            Controls.Add(textBoxabout_KVA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxabout_KVA;
        private Button buttonAbout_KVA;
    }
}