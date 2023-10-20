namespace DichtomyApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вВЛучшийПрезидентИПреподToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Location = new System.Drawing.Point(337, 103);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(180, 20);
            this.epsilonLabel.TabIndex = 8;
            this.epsilonLabel.Text = "Точность (прим. 0,001)";
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(341, 126);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(176, 26);
            this.epsilonTextBox.TabIndex = 9;
            this.epsilonTextBox.TextChanged += new System.EventHandler(this.epsilonTextBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 271);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(225, 20);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Точка пересечения функции";
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.solutionTextBox.Location = new System.Drawing.Point(243, 253);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(274, 66);
            this.solutionTextBox.TabIndex = 12;
            this.solutionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.solutionTextBox.TextChanged += new System.EventHandler(this.solutionTextBox_TextChanged);
            // 
            // chart1
            // 
            chartArea11.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea11);
            this.chart1.Location = new System.Drawing.Point(550, 27);
            this.chart1.Name = "chart1";
            series11.BorderWidth = 3;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Color = System.Drawing.Color.Red;
            series11.LabelBorderWidth = 5;
            series11.Name = "Series1";
            series11.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart1.Series.Add(series11);
            this.chart1.Size = new System.Drawing.Size(679, 449);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.UseWaitCursor = true;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.ClearMenuToolStripMenuItem,
            this.вВЛучшийПрезидентИПреподToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1241, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.CalculateToolStripMenuItem.Text = "Calculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // ClearMenuToolStripMenuItem
            // 
            this.ClearMenuToolStripMenuItem.Name = "ClearMenuToolStripMenuItem";
            this.ClearMenuToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.ClearMenuToolStripMenuItem.Text = "Clear Menu";
            this.ClearMenuToolStripMenuItem.Click += new System.EventHandler(this.ClearMenuToolStripMenuItem_Click);
            // 
            // вВЛучшийПрезидентИПреподToolStripMenuItem
            // 
            this.вВЛучшийПрезидентИПреподToolStripMenuItem.Name = "вВЛучшийПрезидентИПреподToolStripMenuItem";
            this.вВЛучшийПрезидентИПреподToolStripMenuItem.Size = new System.Drawing.Size(292, 29);
            this.вВЛучшийПрезидентИПреподToolStripMenuItem.Text = "В.В Лучший президент и препод";
            this.вВЛучшийПрезидентИПреподToolStripMenuItem.Click += new System.EventHandler(this.вВЛучшийПрезидентИПреподToolStripMenuItem_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(341, 325);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 26);
            this.textBox3.TabIndex = 15;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Значение функции в точке пересечения";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 502);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.epsilonLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dichtomy";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label epsilonLabel;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вВЛучшийПрезидентИПреподToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}

