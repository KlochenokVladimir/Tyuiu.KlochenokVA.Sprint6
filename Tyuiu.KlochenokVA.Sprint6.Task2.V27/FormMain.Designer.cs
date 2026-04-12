using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27
{
    partial class FormMain_KVA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KVA));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KVA = new GroupBox();
            labelTask2_KVA = new Label();
            pictureBox1 = new PictureBox();
            labelTask1_KVA = new Label();
            groupBoxRes_KVA = new GroupBox();
            DataGridView_KVA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            labelRes_KVA = new Label();
            groupBoxData_KVA = new GroupBox();
            textBoxStart_KVA = new TextBox();
            textBoxStop_KVA = new TextBox();
            labelStop_KVA = new Label();
            labelStart_KVA = new Label();
            buttonInfo_KVA = new Button();
            buttonDone_KVA = new Button();
            chart_KVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxRes_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView_KVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_KVA).BeginInit();
            groupBoxData_KVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KVA
            // 
            groupBoxTask_KVA.Controls.Add(labelTask2_KVA);
            groupBoxTask_KVA.Controls.Add(pictureBox1);
            groupBoxTask_KVA.Controls.Add(labelTask1_KVA);
            groupBoxTask_KVA.Location = new Point(18, 14);
            groupBoxTask_KVA.Margin = new Padding(1);
            groupBoxTask_KVA.Name = "groupBoxTask_KVA";
            groupBoxTask_KVA.Padding = new Padding(1);
            groupBoxTask_KVA.Size = new Size(604, 195);
            groupBoxTask_KVA.TabIndex = 0;
            groupBoxTask_KVA.TabStop = false;
            groupBoxTask_KVA.Text = "Условие";
            // 
            // labelTask2_KVA
            // 
            labelTask2_KVA.AutoSize = true;
            labelTask2_KVA.Location = new Point(10, 97);
            labelTask2_KVA.Margin = new Padding(1, 0, 1, 0);
            labelTask2_KVA.Name = "labelTask2_KVA";
            labelTask2_KVA.Size = new Size(359, 15);
            labelTask2_KVA.TabIndex = 2;
            labelTask2_KVA.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 49);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 32);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelTask1_KVA
            // 
            labelTask1_KVA.AutoSize = true;
            labelTask1_KVA.Location = new Point(10, 22);
            labelTask1_KVA.Margin = new Padding(1, 0, 1, 0);
            labelTask1_KVA.Name = "labelTask1_KVA";
            labelTask1_KVA.Size = new Size(295, 15);
            labelTask1_KVA.TabIndex = 0;
            labelTask1_KVA.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxRes_KVA
            // 
            groupBoxRes_KVA.Controls.Add(DataGridView_KVA);
            groupBoxRes_KVA.Controls.Add(labelRes_KVA);
            groupBoxRes_KVA.Location = new Point(638, 14);
            groupBoxRes_KVA.Margin = new Padding(1);
            groupBoxRes_KVA.Name = "groupBoxRes_KVA";
            groupBoxRes_KVA.Padding = new Padding(1);
            groupBoxRes_KVA.Size = new Size(475, 283);
            groupBoxRes_KVA.TabIndex = 1;
            groupBoxRes_KVA.TabStop = false;
            groupBoxRes_KVA.Text = "Вывод данных: ";
            // 
            // DataGridView_KVA
            // 
            DataGridView_KVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView_KVA.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            DataGridView_KVA.Location = new Point(13, 38);
            DataGridView_KVA.Margin = new Padding(1);
            DataGridView_KVA.Name = "DataGridView_KVA";
            DataGridView_KVA.RowHeadersVisible = false;
            DataGridView_KVA.RowHeadersWidth = 102;
            DataGridView_KVA.Size = new Size(100, 237);
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
            labelRes_KVA.Location = new Point(13, 22);
            labelRes_KVA.Margin = new Padding(1, 0, 1, 0);
            labelRes_KVA.Name = "labelRes_KVA";
            labelRes_KVA.Size = new Size(63, 15);
            labelRes_KVA.TabIndex = 0;
            labelRes_KVA.Text = "Результат:";
            // 
            // groupBoxData_KVA
            // 
            groupBoxData_KVA.Controls.Add(textBoxStart_KVA);
            groupBoxData_KVA.Controls.Add(textBoxStop_KVA);
            groupBoxData_KVA.Controls.Add(labelStop_KVA);
            groupBoxData_KVA.Controls.Add(labelStart_KVA);
            groupBoxData_KVA.Location = new Point(18, 218);
            groupBoxData_KVA.Margin = new Padding(1);
            groupBoxData_KVA.Name = "groupBoxData_KVA";
            groupBoxData_KVA.Padding = new Padding(1);
            groupBoxData_KVA.Size = new Size(347, 78);
            groupBoxData_KVA.TabIndex = 2;
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
            textBoxStop_KVA.Location = new Point(163, 48);
            textBoxStop_KVA.Margin = new Padding(1);
            textBoxStop_KVA.Name = "textBoxStop_KVA";
            textBoxStop_KVA.Size = new Size(105, 23);
            textBoxStop_KVA.TabIndex = 2;
            // 
            // labelStop_KVA
            // 
            labelStop_KVA.AutoSize = true;
            labelStop_KVA.Location = new Point(163, 19);
            labelStop_KVA.Margin = new Padding(1, 0, 1, 0);
            labelStop_KVA.Name = "labelStop_KVA";
            labelStop_KVA.Size = new Size(75, 15);
            labelStop_KVA.TabIndex = 1;
            labelStop_KVA.Text = "Конец шага:";
            labelStop_KVA.Click += label2_Click;
            // 
            // labelStart_KVA
            // 
            labelStart_KVA.AutoSize = true;
            labelStart_KVA.Location = new Point(6, 19);
            labelStart_KVA.Margin = new Padding(1, 0, 1, 0);
            labelStart_KVA.Name = "labelStart_KVA";
            labelStart_KVA.Size = new Size(72, 15);
            labelStart_KVA.TabIndex = 0;
            labelStart_KVA.Text = "Старт шага:";
            // 
            // buttonInfo_KVA
            // 
            buttonInfo_KVA.BackColor = Color.FromArgb(192, 192, 255);
            buttonInfo_KVA.FlatStyle = FlatStyle.Flat;
            buttonInfo_KVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonInfo_KVA.Location = new Point(410, 245);
            buttonInfo_KVA.Margin = new Padding(1);
            buttonInfo_KVA.Name = "buttonInfo_KVA";
            buttonInfo_KVA.Size = new Size(77, 38);
            buttonInfo_KVA.TabIndex = 3;
            buttonInfo_KVA.Text = "Справка";
            buttonInfo_KVA.UseVisualStyleBackColor = false;
            buttonInfo_KVA.Click += ButtonInfo_Click;
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_KVA.FlatStyle = FlatStyle.Flat;
            buttonDone_KVA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KVA.Location = new Point(524, 240);
            buttonDone_KVA.Margin = new Padding(1);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(98, 49);
            buttonDone_KVA.TabIndex = 4;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = false;
            buttonDone_KVA.Click += buttonDone_Click;
            buttonDone_KVA.MouseDown += buttonDone_MouseDown;
            buttonDone_KVA.MouseEnter += buttonDone_MouseEnter;
            buttonDone_KVA.MouseLeave += buttonDone_MouseLeave;
            // 
            // chart_KVA
            // 
            chartArea1.Name = "ChartArea1";
            chart_KVA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_KVA.Legends.Add(legend1);
            chart_KVA.Location = new Point(754, 52);
            chart_KVA.Margin = new Padding(1);
            chart_KVA.Name = "chart_KVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_KVA.Series.Add(series1);
            chart_KVA.Size = new Size(346, 237);
            chart_KVA.TabIndex = 2;
            chart_KVA.Text = "chart1";
            // 
            // FormMain_KVA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 310);
            Controls.Add(chart_KVA);
            Controls.Add(buttonDone_KVA);
            Controls.Add(buttonInfo_KVA);
            Controls.Add(groupBoxData_KVA);
            Controls.Add(groupBoxRes_KVA);
            Controls.Add(groupBoxTask_KVA);
            Margin = new Padding(1);
            Name = "FormMain_KVA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 27 | Клоченок В. А.";
            Load += FormMain_KVA_Load;
            groupBoxTask_KVA.ResumeLayout(false);
            groupBoxTask_KVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxRes_KVA.ResumeLayout(false);
            groupBoxRes_KVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart_KVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView_KVA).EndInit();
            groupBoxData_KVA.ResumeLayout(false);
            groupBoxData_KVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KVA;
        private Label labelTask1_KVA;
        private Label labelTask2_KVA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxRes_KVA;
        private Label labelRes_KVA;
        private GroupBox groupBoxData_KVA;
        private Label labelStop_KVA;
        private Label labelStart_KVA;
        private DataGridView DataGridView_KVA;
        private TextBox textBoxStart_KVA;
        private TextBox textBoxStop_KVA;
        private Button buttonInfo_KVA;
        private Button buttonDone_KVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_KVA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
