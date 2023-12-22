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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.epsilonLabel = new System.Windows.Forms.Label();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateDichtomyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateGoldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateNewtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateDecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sLAEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IntersectionPoint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minFunction = new System.Windows.Forms.TextBox();
            this.maxFunction = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lSMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // epsilonLabel
            // 
            this.epsilonLabel.AutoSize = true;
            this.epsilonLabel.Location = new System.Drawing.Point(173, 19);
            this.epsilonLabel.Name = "epsilonLabel";
            this.epsilonLabel.Size = new System.Drawing.Size(180, 20);
            this.epsilonLabel.TabIndex = 8;
            this.epsilonLabel.Text = "Точность (прим. 0,001)";
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(178, 45);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(176, 26);
            this.epsilonTextBox.TabIndex = 9;
            this.epsilonTextBox.TextChanged += new System.EventHandler(this.epsilonTextBox_TextChanged);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(5, 44);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(225, 20);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Точка пересечения функции";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.functionTextBox.Location = new System.Drawing.Point(334, 10);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(176, 26);
            this.functionTextBox.TabIndex = 12;
            this.functionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.functionTextBox.TextChanged += new System.EventHandler(this.solutionTextBox_TextChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(550, 28);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBorderWidth = 5;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(680, 449);
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
            this.otherTasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1240, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateDichtomyToolStripMenuItem,
            this.calculateGoldenToolStripMenuItem,
            this.calculateNewtonToolStripMenuItem,
            this.calculateDecentToolStripMenuItem});
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.CalculateToolStripMenuItem.Text = "Calculate";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // calculateDichtomyToolStripMenuItem
            // 
            this.calculateDichtomyToolStripMenuItem.Name = "calculateDichtomyToolStripMenuItem";
            this.calculateDichtomyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculateDichtomyToolStripMenuItem.Text = "Calculate Dichtomy";
            this.calculateDichtomyToolStripMenuItem.Click += new System.EventHandler(this.calculateDichtomyToolStripMenuItem_Click);
            // 
            // calculateGoldenToolStripMenuItem
            // 
            this.calculateGoldenToolStripMenuItem.Name = "calculateGoldenToolStripMenuItem";
            this.calculateGoldenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculateGoldenToolStripMenuItem.Text = "Calculate Golden";
            this.calculateGoldenToolStripMenuItem.Click += new System.EventHandler(this.calculateGoldenToolStripMenuItem_Click);
            // 
            // calculateNewtonToolStripMenuItem
            // 
            this.calculateNewtonToolStripMenuItem.Name = "calculateNewtonToolStripMenuItem";
            this.calculateNewtonToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculateNewtonToolStripMenuItem.Text = "Calculate Newton";
            this.calculateNewtonToolStripMenuItem.Click += new System.EventHandler(this.calculateNewtonToolStripMenuItem_Click);
            // 
            // calculateDecentToolStripMenuItem
            // 
            this.calculateDecentToolStripMenuItem.Name = "calculateDecentToolStripMenuItem";
            this.calculateDecentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.calculateDecentToolStripMenuItem.Text = "Calculate Decent";
            this.calculateDecentToolStripMenuItem.Click += new System.EventHandler(this.calculateDecentToolStripMenuItem_Click);
            // 
            // ClearMenuToolStripMenuItem
            // 
            this.ClearMenuToolStripMenuItem.Name = "ClearMenuToolStripMenuItem";
            this.ClearMenuToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.ClearMenuToolStripMenuItem.Text = "Clear Menu";
            this.ClearMenuToolStripMenuItem.Click += new System.EventHandler(this.ClearMenuToolStripMenuItem_Click);
            // 
            // otherTasksToolStripMenuItem
            // 
            this.otherTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integralToolStripMenuItem,
            this.sLAEToolStripMenuItem,
            this.lSMToolStripMenuItem});
            this.otherTasksToolStripMenuItem.Name = "otherTasksToolStripMenuItem";
            this.otherTasksToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.otherTasksToolStripMenuItem.Text = "Other tasks";
            this.otherTasksToolStripMenuItem.Click += new System.EventHandler(this.otherTasksToolStripMenuItem_Click);
            // 
            // integralToolStripMenuItem
            // 
            this.integralToolStripMenuItem.Name = "integralToolStripMenuItem";
            this.integralToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.integralToolStripMenuItem.Text = "Integral";
            this.integralToolStripMenuItem.Click += new System.EventHandler(this.integralToolStripMenuItem_Click);
            // 
            // sLAEToolStripMenuItem
            // 
            this.sLAEToolStripMenuItem.Name = "sLAEToolStripMenuItem";
            this.sLAEToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sLAEToolStripMenuItem.Text = "SLAE";
            this.sLAEToolStripMenuItem.Click += new System.EventHandler(this.sLAEToolStripMenuItem_Click);
            // 
            // IntersectionPoint
            // 
            this.IntersectionPoint.Location = new System.Drawing.Point(334, 41);
            this.IntersectionPoint.Name = "IntersectionPoint";
            this.IntersectionPoint.Size = new System.Drawing.Size(176, 26);
            this.IntersectionPoint.TabIndex = 15;
            this.IntersectionPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IntersectionPoint.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Значение функции в точке пересечения";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 7);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(310, 26);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Введите функцию";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Минимум функции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Максимум функции";
            // 
            // minFunction
            // 
            this.minFunction.Location = new System.Drawing.Point(334, 10);
            this.minFunction.Name = "minFunction";
            this.minFunction.Size = new System.Drawing.Size(176, 26);
            this.minFunction.TabIndex = 22;
            this.minFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minFunction.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // maxFunction
            // 
            this.maxFunction.Location = new System.Drawing.Point(334, 42);
            this.maxFunction.Name = "maxFunction";
            this.maxFunction.Size = new System.Drawing.Size(176, 26);
            this.maxFunction.TabIndex = 23;
            this.maxFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxFunction.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.epsilonTextBox);
            this.panel1.Controls.Add(this.epsilonLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(28, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 97);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(10, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 45);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.IntersectionPoint);
            this.panel3.Controls.Add(this.functionTextBox);
            this.panel3.Controls.Add(this.resultLabel);
            this.panel3.Location = new System.Drawing.Point(5, 261);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(521, 79);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.maxFunction);
            this.panel4.Controls.Add(this.minFunction);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(5, 341);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(522, 81);
            this.panel4.TabIndex = 27;
            // 
            // lSMToolStripMenuItem
            // 
            this.lSMToolStripMenuItem.Name = "lSMToolStripMenuItem";
            this.lSMToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lSMToolStripMenuItem.Text = "LSM";
            this.lSMToolStripMenuItem.Click += new System.EventHandler(this.lSMToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1240, 502);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "AllInOne";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.TextBox functionTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuToolStripMenuItem;
        private System.Windows.Forms.TextBox IntersectionPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem calculateDichtomyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateNewtonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateDecentToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minFunction;
        private System.Windows.Forms.TextBox maxFunction;
        private System.Windows.Forms.ToolStripMenuItem calculateGoldenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sLAEToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolStripMenuItem lSMToolStripMenuItem;
    }
}

