namespace Tyuiu.KlochenokVA.Sprint6.Task1.V21
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
            buttonDone_KVA = new Button();
            buttonHelp_KVA = new Button();
            groupBoxVvod_KVA = new GroupBox();
            labelStop = new Label();
            labelStart_KVA = new Label();
            textBoxStart_KVA = new TextBox();
            textBoxStop_KVA = new TextBox();
            groupBoxResult_KVA = new GroupBox();
            textBoxResult_KVA = new TextBox();
            textBoxTask = new TextBox();
            groupBoxVvod_KVA.SuspendLayout();
            groupBoxResult_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.BackColor = Color.Green;
            buttonDone_KVA.Location = new Point(436, 281);
            buttonDone_KVA.Margin = new Padding(2, 1, 2, 1);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(115, 54);
            buttonDone_KVA.TabIndex = 10;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = false;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // buttonHelp_KVA
            // 
            buttonHelp_KVA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KVA.Location = new Point(335, 281);
            buttonHelp_KVA.Margin = new Padding(2, 1, 2, 1);
            buttonHelp_KVA.Name = "buttonHelp_KVA";
            buttonHelp_KVA.Size = new Size(92, 54);
            buttonHelp_KVA.TabIndex = 11;
            buttonHelp_KVA.Text = "Справка";
            buttonHelp_KVA.UseVisualStyleBackColor = false;
            buttonHelp_KVA.Click += buttonHelp_KVA_Click;
            // 
            // groupBoxVvod_KVA
            // 
            groupBoxVvod_KVA.Controls.Add(labelStop);
            groupBoxVvod_KVA.Controls.Add(labelStart_KVA);
            groupBoxVvod_KVA.Controls.Add(textBoxStart_KVA);
            groupBoxVvod_KVA.Controls.Add(textBoxStop_KVA);
            groupBoxVvod_KVA.Location = new Point(1, 215);
            groupBoxVvod_KVA.Margin = new Padding(2, 1, 2, 1);
            groupBoxVvod_KVA.Name = "groupBoxVvod_KVA";
            groupBoxVvod_KVA.Padding = new Padding(2, 1, 2, 1);
            groupBoxVvod_KVA.Size = new Size(330, 123);
            groupBoxVvod_KVA.TabIndex = 12;
            groupBoxVvod_KVA.TabStop = false;
            groupBoxVvod_KVA.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(201, 33);
            labelStop.Margin = new Padding(2, 0, 2, 0);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(75, 15);
            labelStop.TabIndex = 3;
            labelStop.Text = "Конец шага:";
            // 
            // labelStart_KVA
            // 
            labelStart_KVA.AutoSize = true;
            labelStart_KVA.Location = new Point(8, 34);
            labelStart_KVA.Margin = new Padding(2, 0, 2, 0);
            labelStart_KVA.Name = "labelStart_KVA";
            labelStart_KVA.Size = new Size(72, 15);
            labelStart_KVA.TabIndex = 2;
            labelStart_KVA.Text = "Старт шага:";
            // 
            // textBoxStart_KVA
            // 
            textBoxStart_KVA.Location = new Point(9, 58);
            textBoxStart_KVA.Margin = new Padding(2, 1, 2, 1);
            textBoxStart_KVA.Name = "textBoxStart_KVA";
            textBoxStart_KVA.Size = new Size(110, 23);
            textBoxStart_KVA.TabIndex = 0;
            // 
            // textBoxStop_KVA
            // 
            textBoxStop_KVA.Location = new Point(199, 58);
            textBoxStop_KVA.Margin = new Padding(2, 1, 2, 1);
            textBoxStop_KVA.Name = "textBoxStop_KVA";
            textBoxStop_KVA.Size = new Size(110, 23);
            textBoxStop_KVA.TabIndex = 1;
            // 
            // groupBoxResult_KVA
            // 
            groupBoxResult_KVA.Controls.Add(textBoxResult_KVA);
            groupBoxResult_KVA.Location = new Point(554, 8);
            groupBoxResult_KVA.Margin = new Padding(2, 1, 2, 1);
            groupBoxResult_KVA.Name = "groupBoxResult_KVA";
            groupBoxResult_KVA.Padding = new Padding(2, 1, 2, 1);
            groupBoxResult_KVA.Size = new Size(261, 336);
            groupBoxResult_KVA.TabIndex = 9;
            groupBoxResult_KVA.TabStop = false;
            groupBoxResult_KVA.Text = "Вывод данных                             Результат:";
            // 
            // textBoxResult_KVA
            // 
            textBoxResult_KVA.Font = new Font("Consolas", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KVA.Location = new Point(3, 33);
            textBoxResult_KVA.Margin = new Padding(2, 1, 2, 1);
            textBoxResult_KVA.Multiline = true;
            textBoxResult_KVA.Name = "textBoxResult_KVA";
            textBoxResult_KVA.ReadOnly = true;
            textBoxResult_KVA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KVA.Size = new Size(245, 302);
            textBoxResult_KVA.TabIndex = 0;
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(4, 3);
            textBoxTask.Margin = new Padding(2, 1, 2, 1);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(548, 212);
            textBoxTask.TabIndex = 8;
            textBoxTask.Text = "Условие\r\n\r\nПротабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 347);
            Controls.Add(groupBoxVvod_KVA);
            Controls.Add(buttonHelp_KVA);
            Controls.Add(buttonDone_KVA);
            Controls.Add(groupBoxResult_KVA);
            Controls.Add(textBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6 | Таск1 | Вариант21 | Клоченок В. А.";
            groupBoxVvod_KVA.ResumeLayout(false);
            groupBoxVvod_KVA.PerformLayout();
            groupBoxResult_KVA.ResumeLayout(false);
            groupBoxResult_KVA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDone_KVA;
        private Button buttonHelp_KVA;
        private GroupBox groupBoxVvod_KVA;
        private Label labelStop;
        private Label labelStart_KVA;
        private TextBox textBoxStart_KVA;
        private TextBox textBoxStop_KVA;
        private GroupBox groupBoxResult_KVA;
        private TextBox textBoxResult_KVA;
        private TextBox textBoxTask;
    }
}
