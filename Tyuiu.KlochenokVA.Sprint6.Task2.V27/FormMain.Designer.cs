namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27
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
            buttonDone_KVA = new Button();
            buttonHelp_KVA = new Button();
            groupBoxData_KVA = new GroupBox();
            textBoxStart_KVA = new TextBox();
            textBoxStop_KVA = new TextBox();
            labelStop_KVA = new Label();
            labelStart_KVA = new Label();
            groupBoxRes_KVA = new GroupBox();
            DataGridView_KVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelRes_KVA = new Label();
            groupBoxTask_KVA = new GroupBox();
            labelTask2_KVA = new Label();
            pictureBox1 = new PictureBox();
            labelTask1_KVA = new Label();
            groupBoxData_KVA.SuspendLayout();
            groupBoxRes_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_KVA).BeginInit();
            groupBoxTask_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_KVA.FlatStyle = FlatStyle.Flat;
            buttonDone_KVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KVA.Location = new Point(352, 254);
            buttonDone_KVA.Margin = new Padding(1);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(84, 38);
            buttonDone_KVA.TabIndex = 9;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = false;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // buttonHelp_KVA
            // 
            buttonHelp_KVA.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp_KVA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KVA.Location = new Point(264, 254);
            buttonHelp_KVA.Margin = new Padding(1);
            buttonHelp_KVA.Name = "buttonHelp_KVA";
            buttonHelp_KVA.Size = new Size(77, 38);
            buttonHelp_KVA.TabIndex = 8;
            buttonHelp_KVA.Text = "Справка";
            buttonHelp_KVA.UseVisualStyleBackColor = false;
            buttonHelp_KVA.Click += buttonHelp_KVA_Click;
            // 
            // groupBoxData_KVA
            // 
            groupBoxData_KVA.Controls.Add(textBoxStart_KVA);
            groupBoxData_KVA.Controls.Add(textBoxStop_KVA);
            groupBoxData_KVA.Controls.Add(labelStop_KVA);
            groupBoxData_KVA.Controls.Add(labelStart_KVA);
            groupBoxData_KVA.Location = new Point(10, 214);
            groupBoxData_KVA.Margin = new Padding(1);
            groupBoxData_KVA.Name = "groupBoxData_KVA";
            groupBoxData_KVA.Padding = new Padding(1);
            groupBoxData_KVA.Size = new Size(243, 78);
            groupBoxData_KVA.TabIndex = 7;
            groupBoxData_KVA.TabStop = false;
            groupBoxData_KVA.Text = "Ввод данных:";
            // 
            // textBoxStart_KVA
            // 
            textBoxStart_KVA.Location = new Point(10, 48);
            textBoxStart_KVA.Margin = new Padding(1);
            textBoxStart_KVA.Name = "textBoxStart_KVA";
            textBoxStart_KVA.Size = new Size(105, 23);
            textBoxStart_KVA.TabIndex = 3;
            // 
            // textBoxStop_KVA
            // 
            textBoxStop_KVA.Location = new Point(128, 48);
            textBoxStop_KVA.Margin = new Padding(1);
            textBoxStop_KVA.Name = "textBoxStop_KVA";
            textBoxStop_KVA.Size = new Size(105, 23);
            textBoxStop_KVA.TabIndex = 2;
            // 
            // labelStop_KVA
            // 
            labelStop_KVA.AutoSize = true;
            labelStop_KVA.Location = new Point(126, 17);
            labelStop_KVA.Margin = new Padding(1, 0, 1, 0);
            labelStop_KVA.Name = "labelStop_KVA";
            labelStop_KVA.Size = new Size(75, 15);
            labelStop_KVA.TabIndex = 1;
            labelStop_KVA.Text = "Конец шага:";
            // 
            // labelStart_KVA
            // 
            labelStart_KVA.AutoSize = true;
            labelStart_KVA.Location = new Point(4, 17);
            labelStart_KVA.Margin = new Padding(1, 0, 1, 0);
            labelStart_KVA.Name = "labelStart_KVA";
            labelStart_KVA.Size = new Size(72, 15);
            labelStart_KVA.TabIndex = 0;
            labelStart_KVA.Text = "Старт шага:";
            // 
            // groupBoxRes_KVA
            // 
            groupBoxRes_KVA.Controls.Add(DataGridView_KVA);
            groupBoxRes_KVA.Controls.Add(labelRes_KVA);
            groupBoxRes_KVA.Location = new Point(448, 13);
            groupBoxRes_KVA.Margin = new Padding(1);
            groupBoxRes_KVA.Name = "groupBoxRes_KVA";
            groupBoxRes_KVA.Padding = new Padding(1);
            groupBoxRes_KVA.Size = new Size(554, 381);
            groupBoxRes_KVA.TabIndex = 6;
            groupBoxRes_KVA.TabStop = false;
            groupBoxRes_KVA.Text = "Вывод данных: ";
            // 
            // DataGridView_KVA
            // 
            DataGridView_KVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_KVA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            DataGridView_KVA.Location = new Point(11, 42);
            DataGridView_KVA.Margin = new Padding(1);
            DataGridView_KVA.Name = "DataGridView_KVA";
            DataGridView_KVA.RowHeadersVisible = false;
            DataGridView_KVA.RowHeadersWidth = 102;
            DataGridView_KVA.Size = new Size(244, 237);
            DataGridView_KVA.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 12;
            X.Name = "X";
            X.Width = 120;
            // 
            // FX
            // 
            FX.HeaderText = "F(x)";
            FX.MinimumWidth = 12;
            FX.Name = "FX";
            FX.Width = 120;
            // 
            // labelRes_KVA
            // 
            labelRes_KVA.AutoSize = true;
            labelRes_KVA.Location = new Point(11, 20);
            labelRes_KVA.Margin = new Padding(1, 0, 1, 0);
            labelRes_KVA.Name = "labelRes_KVA";
            labelRes_KVA.Size = new Size(63, 15);
            labelRes_KVA.TabIndex = 0;
            labelRes_KVA.Text = "Результат:";
            // 
            // groupBoxTask_KVA
            // 
            groupBoxTask_KVA.Controls.Add(labelTask2_KVA);
            groupBoxTask_KVA.Controls.Add(pictureBox1);
            groupBoxTask_KVA.Controls.Add(labelTask1_KVA);
            groupBoxTask_KVA.Location = new Point(10, 10);
            groupBoxTask_KVA.Margin = new Padding(1);
            groupBoxTask_KVA.Name = "groupBoxTask_KVA";
            groupBoxTask_KVA.Padding = new Padding(1);
            groupBoxTask_KVA.Size = new Size(426, 195);
            groupBoxTask_KVA.TabIndex = 5;
            groupBoxTask_KVA.TabStop = false;
            groupBoxTask_KVA.Text = "Условие";
            // 
            // labelTask2_KVA
            // 
            labelTask2_KVA.AutoSize = true;
            labelTask2_KVA.Location = new Point(8, 39);
            labelTask2_KVA.Margin = new Padding(1, 0, 1, 0);
            labelTask2_KVA.Name = "labelTask2_KVA";
            labelTask2_KVA.Size = new Size(359, 15);
            labelTask2_KVA.TabIndex = 2;
            labelTask2_KVA.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 69);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask1_KVA
            // 
            labelTask1_KVA.AutoSize = true;
            labelTask1_KVA.Location = new Point(8, 20);
            labelTask1_KVA.Margin = new Padding(1, 0, 1, 0);
            labelTask1_KVA.Name = "labelTask1_KVA";
            labelTask1_KVA.Size = new Size(295, 15);
            labelTask1_KVA.TabIndex = 0;
            labelTask1_KVA.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 404);
            Controls.Add(buttonDone_KVA);
            Controls.Add(buttonHelp_KVA);
            Controls.Add(groupBoxData_KVA);
            Controls.Add(groupBoxRes_KVA);
            Controls.Add(groupBoxTask_KVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт6 | Таск2 | Вариант27 | Клоченок В. А.";
            groupBoxData_KVA.ResumeLayout(false);
            groupBoxData_KVA.PerformLayout();
            groupBoxRes_KVA.ResumeLayout(false);
            groupBoxRes_KVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_KVA).EndInit();
            groupBoxTask_KVA.ResumeLayout(false);
            groupBoxTask_KVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_KVA;
        private Button buttonHelp_KVA;
        private GroupBox groupBoxData_KVA;
        private TextBox textBoxStart_KVA;
        private TextBox textBoxStop_KVA;
        private Label labelStop_KVA;
        private Label labelStart_KVA;
        private GroupBox groupBoxRes_KVA;
        private DataGridView DataGridView_KVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
        private Label labelRes_KVA;
        private GroupBox groupBoxTask_KVA;
        private Label labelTask2_KVA;
        private PictureBox pictureBox1;
        private Label labelTask1_KVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KVA;
    }
}
