namespace Tyuiu.KlochenoKVA.Sprint6.Task5.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelVerh_KVA = new Panel();
            buttonSpravka_KVA = new Button();
            buttonOtkrFile_KVA = new Button();
            buttonDone_KVA = new Button();
            groupBoxUsl_KVA = new GroupBox();
            textBoxUsl_KVA = new TextBox();
            panelLeft_KVA = new Panel();
            groupBoxVivod_KVA = new GroupBox();
            dataGridViewVivod_KVA = new DataGridView();
            groupBox3 = new GroupBox();
            panelFill_KVA = new Panel();
            chartFunction_KVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelVerh_KVA.SuspendLayout();
            groupBoxUsl_KVA.SuspendLayout();
            panelLeft_KVA.SuspendLayout();
            groupBoxVivod_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_KVA).BeginInit();
            panelFill_KVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KVA).BeginInit();
            SuspendLayout();
            // 
            // panelVerh_KVA
            // 
            panelVerh_KVA.Controls.Add(buttonSpravka_KVA);
            panelVerh_KVA.Controls.Add(buttonOtkrFile_KVA);
            panelVerh_KVA.Controls.Add(buttonDone_KVA);
            panelVerh_KVA.Controls.Add(groupBoxUsl_KVA);
            panelVerh_KVA.Dock = DockStyle.Top;
            panelVerh_KVA.Location = new Point(0, 0);
            panelVerh_KVA.Name = "panelVerh_KVA";
            panelVerh_KVA.Size = new Size(1010, 80);
            panelVerh_KVA.TabIndex = 0;
            // 
            // buttonSpravka_KVA
            // 
            buttonSpravka_KVA.BackColor = Color.RoyalBlue;
            buttonSpravka_KVA.Font = new Font("Segoe UI", 12F);
            buttonSpravka_KVA.Location = new Point(873, 14);
            buttonSpravka_KVA.Name = "buttonSpravka_KVA";
            buttonSpravka_KVA.Size = new Size(123, 54);
            buttonSpravka_KVA.TabIndex = 1;
            buttonSpravka_KVA.Text = "Справка";
            buttonSpravka_KVA.UseVisualStyleBackColor = false;
            buttonSpravka_KVA.Click += buttonSpravka_KVA_Click;
            // 
            // buttonOtkrFile_KVA
            // 
            buttonOtkrFile_KVA.BackColor = Color.FromArgb(128, 128, 255);
            buttonOtkrFile_KVA.Font = new Font("Segoe UI", 12F);
            buttonOtkrFile_KVA.Location = new Point(670, 14);
            buttonOtkrFile_KVA.Name = "buttonOtkrFile_KVA";
            buttonOtkrFile_KVA.Size = new Size(184, 54);
            buttonOtkrFile_KVA.TabIndex = 1;
            buttonOtkrFile_KVA.Text = "Открыть файл";
            buttonOtkrFile_KVA.UseVisualStyleBackColor = false;
            buttonOtkrFile_KVA.Click += buttonOtkrFile_KVA_Click;
            // 
            // buttonDone_KVA
            // 
            buttonDone_KVA.BackColor = Color.Green;
            buttonDone_KVA.Font = new Font("Segoe UI", 12F);
            buttonDone_KVA.Location = new Point(498, 14);
            buttonDone_KVA.Name = "buttonDone_KVA";
            buttonDone_KVA.Size = new Size(154, 56);
            buttonDone_KVA.TabIndex = 1;
            buttonDone_KVA.Text = "Выполнить";
            buttonDone_KVA.UseVisualStyleBackColor = false;
            buttonDone_KVA.Click += buttonDone_KVA_Click;
            // 
            // groupBoxUsl_KVA
            // 
            groupBoxUsl_KVA.Controls.Add(textBoxUsl_KVA);
            groupBoxUsl_KVA.Font = new Font("Segoe UI", 12F);
            groupBoxUsl_KVA.Location = new Point(3, 3);
            groupBoxUsl_KVA.Name = "groupBoxUsl_KVA";
            groupBoxUsl_KVA.Size = new Size(489, 71);
            groupBoxUsl_KVA.TabIndex = 0;
            groupBoxUsl_KVA.TabStop = false;
            groupBoxUsl_KVA.Text = "Условие";
            // 
            // textBoxUsl_KVA
            // 
            textBoxUsl_KVA.BackColor = SystemColors.Menu;
            textBoxUsl_KVA.BorderStyle = BorderStyle.None;
            textBoxUsl_KVA.Location = new Point(6, 21);
            textBoxUsl_KVA.Multiline = true;
            textBoxUsl_KVA.Name = "textBoxUsl_KVA";
            textBoxUsl_KVA.ReadOnly = true;
            textBoxUsl_KVA.Size = new Size(466, 44);
            textBoxUsl_KVA.TabIndex = 0;
            textBoxUsl_KVA.Text = "Прочитать данные из файла. Вывести в dataGridView значения больше 0 и построить диаграмму.\r\n";
            // 
            // panelLeft_KVA
            // 
            panelLeft_KVA.Controls.Add(groupBoxVivod_KVA);
            panelLeft_KVA.Controls.Add(groupBox3);
            panelLeft_KVA.Dock = DockStyle.Left;
            panelLeft_KVA.Location = new Point(0, 80);
            panelLeft_KVA.Name = "panelLeft_KVA";
            panelLeft_KVA.Size = new Size(246, 423);
            panelLeft_KVA.TabIndex = 0;
            // 
            // groupBoxVivod_KVA
            // 
            groupBoxVivod_KVA.Controls.Add(dataGridViewVivod_KVA);
            groupBoxVivod_KVA.Dock = DockStyle.Fill;
            groupBoxVivod_KVA.Font = new Font("Segoe UI", 12F);
            groupBoxVivod_KVA.Location = new Point(0, 0);
            groupBoxVivod_KVA.Name = "groupBoxVivod_KVA";
            groupBoxVivod_KVA.Size = new Size(246, 423);
            groupBoxVivod_KVA.TabIndex = 0;
            groupBoxVivod_KVA.TabStop = false;
            groupBoxVivod_KVA.Text = "Вывод данных";
            // 
            // dataGridViewVivod_KVA
            // 
            dataGridViewVivod_KVA.BackgroundColor = SystemColors.ControlDarKVArk;
            dataGridViewVivod_KVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVivod_KVA.Dock = DockStyle.Fill;
            dataGridViewVivod_KVA.Location = new Point(3, 25);
            dataGridViewVivod_KVA.Name = "dataGridViewVivod_KVA";
            dataGridViewVivod_KVA.ScrollBars = ScrollBars.Vertical;
            dataGridViewVivod_KVA.Size = new Size(240, 395);
            dataGridViewVivod_KVA.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(324, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox1";
            // 
            // panelFill_KVA
            // 
            panelFill_KVA.Controls.Add(chartFunction_KVA);
            panelFill_KVA.Dock = DockStyle.Fill;
            panelFill_KVA.Location = new Point(246, 80);
            panelFill_KVA.Name = "panelFill_KVA";
            panelFill_KVA.Size = new Size(764, 423);
            panelFill_KVA.TabIndex = 1;
            // 
            // chartFunction_KVA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KVA.ChartAreas.Add(chartArea1);
            chartFunction_KVA.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_KVA.Legends.Add(legend1);
            chartFunction_KVA.Location = new Point(0, 0);
            chartFunction_KVA.MaximumSize = new Size(1000, 700);
            chartFunction_KVA.MinimumSize = new Size(578, 390);
            chartFunction_KVA.Name = "chartFunction_KVA";
            chartFunction_KVA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KVA.Series.Add(series1);
            chartFunction_KVA.Size = new Size(764, 423);
            chartFunction_KVA.TabIndex = 0;
            chartFunction_KVA.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 503);
            Controls.Add(panelFill_KVA);
            Controls.Add(panelLeft_KVA);
            Controls.Add(panelVerh_KVA);
            MinimumSize = new Size(810, 490);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 8 | Клоченок В. А.";
            panelVerh_KVA.ResumeLayout(false);
            groupBoxUsl_KVA.ResumeLayout(false);
            groupBoxUsl_KVA.PerformLayout();
            panelLeft_KVA.ResumeLayout(false);
            groupBoxVivod_KVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVivod_KVA).EndInit();
            panelFill_KVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelVerh_KVA;
        private Panel panelLeft_KVA;
        private Panel panelFill_KVA;
        private GroupBox groupBoxUsl_KVA;
        private GroupBox groupBoxVivod_KVA;
        private GroupBox groupBox3;
        private TextBox textBoxUsl_KVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KVA;
        private Button buttonSpravka_KVA;
        private Button buttonOtkrFile_KVA;
        private Button buttonDone_KVA;
        private DataGridView dataGridViewVivod_KVA;
    }
}
