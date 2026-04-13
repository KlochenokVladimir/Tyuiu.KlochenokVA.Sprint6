namespace Tyuiu.KlochenoKVA.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxYsl_KVA = new GroupBox();
            textBoxYsl_KVA = new TextBox();
            buttonOpen_KVA = new Button();
            buttonDone_KVA = new Button();
            openFileDialog_KVA = new OpenFileDialog();
            toolTip = new ToolTip(components);
            buttonHelp_KVA = new Button();
            groupBoxInput_KVA = new GroupBox();
            textBoxPath_KVA = new TextBox();
            textBoxIn_KVA = new TextBox();
            groupBoxOutput_KVA = new GroupBox();
            textBoxOut_KVA = new TextBox();
            buttonOpen_KDA = new Button();
            groupBoxYsl_KVA.SuspendLayout();
            groupBoxInput_KVA.SuspendLayout();
            groupBoxOutput_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxYsl_KVA
            // 
            groupBoxYsl_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxYsl_KVA.Controls.Add(textBoxYsl_KVA);
            groupBoxYsl_KVA.Location = new Point(12, 58);
            groupBoxYsl_KVA.Name = "groupBoxYsl_KVA";
            groupBoxYsl_KVA.Size = new Size(705, 72);
            groupBoxYsl_KVA.TabIndex = 0;
            groupBoxYsl_KVA.TabStop = false;
            groupBoxYsl_KVA.Text = "Условие";
            // 
            // textBoxYsl_KVA
            // 
            textBoxYsl_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxYsl_KVA.BackColor = SystemColors.MenuBar;
            textBoxYsl_KVA.BorderStyle = BorderStyle.None;
            textBoxYsl_KVA.Location = new Point(6, 22);
            textBoxYsl_KVA.Multiline = true;
            textBoxYsl_KVA.Name = "textBoxYsl_KVA";
            textBoxYsl_KVA.Size = new Size(693, 43);
            textBoxYsl_KVA.TabIndex = 0;
            // 
            // buttonOpen_KVA
            // 
            buttonOpen_KVA.Location = new Point(18, 7);
            buttonOpen_KVA.Name = "buttonOpen_KVA";
            buttonOpen_KVA.Size = new Size(58, 45);
            buttonOpen_KVA.TabIndex = 1;
            toolTip.SetToolTip(buttonOpen_KVA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_KVA.UseVisualStyleBackColor = true;
            buttonOpen_KVA.Click += buttonOpen_KVA_Click;
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.Enabled = false;
            buttonDone_KVA.Location = new Point(96, 7);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(58, 45);
            buttonDone_KVA.TabIndex = 2;
            toolTip.SetToolTip(buttonDone_KVA, "Производит поиск в файле символов \"z\" и конкатенирует строки в которых находятся эти символы\r\n");
            buttonDone_KVA.UseVisualStyleBackColor = true;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // openFileDialog_KVA
            // 
            openFileDialog_KVA.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_KVA
            // 
            buttonHelp_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KVA.Location = new Point(653, 12);
            buttonHelp_KVA.Name = "buttonHelp_KVA";
            buttonHelp_KVA.Size = new Size(58, 45);
            buttonHelp_KVA.TabIndex = 3;
            buttonHelp_KVA.UseVisualStyleBackColor = true;
            buttonHelp_KVA.Click += buttonHelp_KVA_Click;
            // 
            // groupBoxInput_KVA
            // 
            groupBoxInput_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxInput_KVA.Controls.Add(textBoxPath_KVA);
            groupBoxInput_KVA.Controls.Add(textBoxIn_KVA);
            groupBoxInput_KVA.Location = new Point(12, 136);
            groupBoxInput_KVA.Name = "groupBoxInput_KVA";
            groupBoxInput_KVA.Size = new Size(336, 246);
            groupBoxInput_KVA.TabIndex = 4;
            groupBoxInput_KVA.TabStop = false;
            groupBoxInput_KVA.Text = "Ввод";
            // 
            // textBoxPath_KVA
            // 
            textBoxPath_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxPath_KVA.BackColor = SystemColors.MenuBar;
            textBoxPath_KVA.BorderStyle = BorderStyle.None;
            textBoxPath_KVA.Location = new Point(42, -3);
            textBoxPath_KVA.Name = "textBoxPath_KVA";
            textBoxPath_KVA.Size = new Size(288, 16);
            textBoxPath_KVA.TabIndex = 1;
            // 
            // textBoxIn_KVA
            // 
            textBoxIn_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxIn_KVA.BackColor = SystemColors.ControlLightLight;
            textBoxIn_KVA.BorderStyle = BorderStyle.FixedSingle;
            textBoxIn_KVA.Location = new Point(6, 19);
            textBoxIn_KVA.Multiline = true;
            textBoxIn_KVA.Name = "textBoxIn_KVA";
            textBoxIn_KVA.ReadOnly = true;
            textBoxIn_KVA.Size = new Size(324, 221);
            textBoxIn_KVA.TabIndex = 0;
            // 
            // groupBoxOutput_KVA
            // 
            groupBoxOutput_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxOutput_KVA.Controls.Add(textBoxOut_KVA);
            groupBoxOutput_KVA.Location = new Point(381, 136);
            groupBoxOutput_KVA.Name = "groupBoxOutput_KVA";
            groupBoxOutput_KVA.Size = new Size(336, 246);
            groupBoxOutput_KVA.TabIndex = 5;
            groupBoxOutput_KVA.TabStop = false;
            groupBoxOutput_KVA.Text = "Вывод";
            // 
            // textBoxOut_KVA
            // 
            textBoxOut_KVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut_KVA.BackColor = SystemColors.ControlLightLight;
            textBoxOut_KVA.BorderStyle = BorderStyle.FixedSingle;
            textBoxOut_KVA.Location = new Point(6, 19);
            textBoxOut_KVA.Multiline = true;
            textBoxOut_KVA.Name = "textBoxOut_KVA";
            textBoxOut_KVA.ReadOnly = true;
            textBoxOut_KVA.Size = new Size(327, 221);
            textBoxOut_KVA.TabIndex = 1;
            // 
            // buttonOpen_KDA
            // 
            buttonOpen_KVA.Image = (Image)resources.GetObject("buttonOpen_KVA.Image");
            buttonOpen_KVA.Location = new Point(160, 7);
            buttonOpen_KVA.Name = "buttonOpen_KVA";
            buttonOpen_KVA.Size = new Size(58, 45);
            buttonOpen_KVA.TabIndex = 6;
            toolTip.SetToolTip(buttonOpen_KDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen_KVA.UseVisualStyleBackColor = true;
            buttonOpen_KVA.Click += buttonOpen_KVA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 394);
            Controls.Add(buttonOpen_KDA);
            Controls.Add(groupBoxOutput_KVA);
            Controls.Add(groupBoxInput_KVA);
            Controls.Add(buttonHelp_KVA);
            Controls.Add(buttonDone_KVA);
            Controls.Add(buttonOpen_KVA);
            Controls.Add(groupBoxYsl_KVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Кулько.Д.А";
            groupBoxYsl_KVA.ResumeLayout(false);
            groupBoxYsl_KVA.PerformLayout();
            groupBoxInput_KVA.ResumeLayout(false);
            groupBoxInput_KVA.PerformLayout();
            groupBoxOutput_KVA.ResumeLayout(false);
            groupBoxOutput_KVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYsl_KVA;
        private TextBox textBoxYsl_KVA;
        private Button buttonOpen_KVA;
        private ToolTip toolTip;
        private Button buttonDone_KVA;
        private OpenFileDialog openFileDialog_KVA;
        private Button buttonHelp_KVA;
        private GroupBox groupBoxInput_KVA;
        private TextBox textBoxIn_KVA;
        private GroupBox groupBoxOutput_KVA;
        private TextBox textBoxOut_KVA;
        private TextBox textBoxPath_KVA;
        private Button buttonOpen_KDA;
    }
}
