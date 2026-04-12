using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.KlochenokVA.Sprint6.Task4.V29
{
    partial class Form1
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
            panelImport = new Panel();
            buttonResult = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBoxImport = new GroupBox();
            labelStop = new Label();
            label1 = new Label();
            textBoxStop = new TextBox();
            labelStart = new Label();
            textBox1 = new TextBox();
            textBoxStart = new TextBox();
            groupBoxHeading = new GroupBox();
            textBoxHeading = new TextBox();
            panelGraph = new Panel();
            chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterResultt = new Splitter();
            splitterResult = new Splitter();
            panelResult = new Panel();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            panelImport.SuspendLayout();
            groupBoxImport.SuspendLayout();
            groupBoxHeading.SuspendLayout();
            panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraph).BeginInit();
            panelResult.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelImport
            // 
            panelImport.Controls.Add(buttonResult);
            panelImport.Controls.Add(buttonSave);
            panelImport.Controls.Add(buttonHelp);
            panelImport.Controls.Add(groupBoxImport);
            panelImport.Controls.Add(groupBoxHeading);
            panelImport.Dock = DockStyle.Top;
            panelImport.Location = new Point(0, 0);
            panelImport.Name = "panelImport";
            panelImport.Size = new Size(784, 101);
            panelImport.TabIndex = 0;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(652, 31);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(57, 56);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(579, 31);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(57, 56);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(727, 31);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(57, 56);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxImport
            // 
            groupBoxImport.Controls.Add(labelStop);
            groupBoxImport.Controls.Add(label1);
            groupBoxImport.Controls.Add(textBoxStop);
            groupBoxImport.Controls.Add(labelStart);
            groupBoxImport.Controls.Add(textBox1);
            groupBoxImport.Controls.Add(textBoxStart);
            groupBoxImport.Location = new Point(397, 12);
            groupBoxImport.Name = "groupBoxImport";
            groupBoxImport.Size = new Size(165, 75);
            groupBoxImport.TabIndex = 1;
            groupBoxImport.TabStop = false;
            groupBoxImport.Text = "Ввод данных";
            // 
            // labelStop
            // 
            labelStop.AutoSize = true;
            labelStop.Location = new Point(95, 22);
            labelStop.Name = "labelStop";
            labelStop.Size = new Size(41, 15);
            labelStop.TabIndex = 2;
            labelStop.Text = "Конец";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Старт";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(95, 49);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(70, 23);
            textBoxStop.TabIndex = 2;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(6, 22);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(38, 15);
            labelStart.TabIndex = 3;
            labelStart.Text = "Старт";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(95, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 2;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(0, 49);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(75, 23);
            textBoxStart.TabIndex = 0;
            // 
            // groupBoxHeading
            // 
            groupBoxHeading.Controls.Add(textBoxHeading);
            groupBoxHeading.Location = new Point(12, 12);
            groupBoxHeading.Name = "groupBoxHeading";
            groupBoxHeading.Size = new Size(379, 75);
            groupBoxHeading.TabIndex = 0;
            groupBoxHeading.TabStop = false;
            groupBoxHeading.Text = "Условие";
            // 
            // textBoxHeading
            // 
            textBoxHeading.Dock = DockStyle.Fill;
            textBoxHeading.Location = new Point(3, 19);
            textBoxHeading.Multiline = true;
            textBoxHeading.Name = "textBoxHeading";
            textBoxHeading.ReadOnly = true;
            textBoxHeading.Size = new Size(373, 53);
            textBoxHeading.TabIndex = 0;
            textBoxHeading.Text = "Протабулировать функциюна заданном диапозоне -5 5\r\nРезультат вывести в textBox, построить график и сохранить в файл\r\nOutPutFileTask.txt по нажатию кнопки\r\n";
            // 
            // panelGraph
            // 
            panelGraph.BackColor = SystemColors.Control;
            panelGraph.Controls.Add(chartGraph);
            panelGraph.Controls.Add(splitterResultt);
            panelGraph.Controls.Add(splitterResult);
            panelGraph.Dock = DockStyle.Fill;
            panelGraph.Location = new Point(0, 101);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(784, 310);
            panelGraph.TabIndex = 0;
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            chartGraph.ChartAreas.Add(chartArea1);
            chartGraph.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartGraph.Legends.Add(legend1);
            chartGraph.Location = new Point(160, 0);
            chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraph.Series.Add(series1);
            chartGraph.Size = new Size(624, 310);
            chartGraph.TabIndex = 2;
            chartGraph.Text = "chart1";

            // 
            // splitterResultt
            // 
            splitterResultt.Location = new Point(150, 0);
            splitterResultt.Name = "splitterResultt";
            splitterResultt.Size = new Size(10, 310);
            splitterResultt.TabIndex = 1;
            splitterResultt.TabStop = false;
            // 
            // splitterResult
            // 
            splitterResult.Location = new Point(0, 0);
            splitterResult.Name = "splitterResult";
            splitterResult.Size = new Size(150, 310);
            splitterResult.TabIndex = 0;
            splitterResult.TabStop = false;
            // 
            // panelResult
            // 
            panelResult.BackColor = SystemColors.Control;
            panelResult.Controls.Add(groupBoxResult);
            panelResult.Dock = DockStyle.Left;
            panelResult.Location = new Point(0, 101);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(150, 310);
            panelResult.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(150, 310);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(144, 288);
            textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panelResult);
            Controls.Add(panelGraph);
            Controls.Add(panelImport);
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelImport.ResumeLayout(false);
            groupBoxImport.ResumeLayout(false);
            groupBoxImport.PerformLayout();
            groupBoxHeading.ResumeLayout(false);
            groupBoxHeading.PerformLayout();
            panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGraph).EndInit();
            panelResult.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelImport;
        private Panel panelGraph;
        private Panel panelResult;
        private Splitter splitterResult;
        private Splitter splitterResultt;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private GroupBox groupBoxHeading;
        private TextBox textBoxHeading;
        private GroupBox groupBoxImport;
        private TextBox textBoxStart;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBoxStop;
        private Label labelStart;
        private Label labelStop;
        private Button buttonResult;
        private Button buttonSave;
        private Button buttonHelp;
    }
}
