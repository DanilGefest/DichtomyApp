namespace DichtomyApp
{
    partial class Integral
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Integral));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.upperIntegral = new System.Windows.Forms.TextBox();
            this.lowerIntegral = new System.Windows.Forms.TextBox();
            this.formulaIntegral = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateFiotstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateSecondTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOfSteps = new System.Windows.Forms.TextBox();
            this.epsilonTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Точность = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rectangleResult = new System.Windows.Forms.TextBox();
            this.trapeseResult = new System.Windows.Forms.TextBox();
            this.simpsonResult = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rectangleCheckBox = new System.Windows.Forms.CheckBox();
            this.trapeseCheckBox = new System.Windows.Forms.CheckBox();
            this.simpsonCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 136);
            this.label1.TabIndex = 2;
            this.label1.Text = "∫";
            // 
            // upperIntegral
            // 
            this.upperIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.upperIntegral.Location = new System.Drawing.Point(8, 20);
            this.upperIntegral.Name = "upperIntegral";
            this.upperIntegral.Size = new System.Drawing.Size(84, 30);
            this.upperIntegral.TabIndex = 3;
            this.upperIntegral.Text = "5";
            this.upperIntegral.TextChanged += new System.EventHandler(this.upperIntegral_TextChanged);
            // 
            // lowerIntegral
            // 
            this.lowerIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lowerIntegral.Location = new System.Drawing.Point(8, 197);
            this.lowerIntegral.Name = "lowerIntegral";
            this.lowerIntegral.Size = new System.Drawing.Size(84, 30);
            this.lowerIntegral.TabIndex = 4;
            this.lowerIntegral.Text = "-5";
            this.lowerIntegral.TextChanged += new System.EventHandler(this.lowerIntegral_TextChanged);
            // 
            // formulaIntegral
            // 
            this.formulaIntegral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formulaIntegral.Location = new System.Drawing.Point(80, 112);
            this.formulaIntegral.Name = "formulaIntegral";
            this.formulaIntegral.Size = new System.Drawing.Size(414, 35);
            this.formulaIntegral.TabIndex = 5;
            this.formulaIntegral.Text = "x^2+5";
            this.formulaIntegral.TextChanged += new System.EventHandler(this.formulaIntegral_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.otherTasksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1556, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateFiotstToolStripMenuItem,
            this.calculateSecondTaskToolStripMenuItem});
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.calculateToolStripMenuItem.Text = "Calculate";
            // 
            // calculateFiotstToolStripMenuItem
            // 
            this.calculateFiotstToolStripMenuItem.Name = "calculateFiotstToolStripMenuItem";
            this.calculateFiotstToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.calculateFiotstToolStripMenuItem.Text = "Calculate first task";
            this.calculateFiotstToolStripMenuItem.Click += new System.EventHandler(this.calculateFiotstToolStripMenuItem_Click);
            // 
            // calculateSecondTaskToolStripMenuItem
            // 
            this.calculateSecondTaskToolStripMenuItem.Name = "calculateSecondTaskToolStripMenuItem";
            this.calculateSecondTaskToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.calculateSecondTaskToolStripMenuItem.Text = "Calculate second task";
            this.calculateSecondTaskToolStripMenuItem.Click += new System.EventHandler(this.calculateSecondTaskToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(67, 29);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // otherTasksToolStripMenuItem
            // 
            this.otherTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathFunctionsToolStripMenuItem});
            this.otherTasksToolStripMenuItem.Name = "otherTasksToolStripMenuItem";
            this.otherTasksToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.otherTasksToolStripMenuItem.Text = "Other tasks";
            this.otherTasksToolStripMenuItem.Click += new System.EventHandler(this.otherTasksToolStripMenuItem_Click);
            // 
            // mathFunctionsToolStripMenuItem
            // 
            this.mathFunctionsToolStripMenuItem.Name = "mathFunctionsToolStripMenuItem";
            this.mathFunctionsToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.mathFunctionsToolStripMenuItem.Text = "Math functions";
            this.mathFunctionsToolStripMenuItem.Click += new System.EventHandler(this.mathFunctionsToolStripMenuItem_Click);
            // 
            // countOfSteps
            // 
            this.countOfSteps.Location = new System.Drawing.Point(44, 91);
            this.countOfSteps.Name = "countOfSteps";
            this.countOfSteps.Size = new System.Drawing.Size(198, 26);
            this.countOfSteps.TabIndex = 7;
            this.countOfSteps.Text = "50";
            this.countOfSteps.TextChanged += new System.EventHandler(this.countOfSteps_TextChanged);
            // 
            // epsilonTextBox
            // 
            this.epsilonTextBox.Location = new System.Drawing.Point(44, 168);
            this.epsilonTextBox.Name = "epsilonTextBox";
            this.epsilonTextBox.Size = new System.Drawing.Size(198, 26);
            this.epsilonTextBox.TabIndex = 8;
            this.epsilonTextBox.Text = "0,01";
            this.epsilonTextBox.TextChanged += new System.EventHandler(this.epsilon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Кол-во шагов";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Точность
            // 
            this.Точность.AutoSize = true;
            this.Точность.Location = new System.Drawing.Point(80, 145);
            this.Точность.Name = "Точность";
            this.Точность.Size = new System.Drawing.Size(80, 20);
            this.Точность.TabIndex = 11;
            this.Точность.Text = "Точность";
            // 
            // chart1
            // 
            this.chart1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.chart1.Series;
            this.chart1.Location = new System.Drawing.Point(544, 20);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(988, 737);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Метод прямоугольников";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Метод трапеции";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Метод Симпсона";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(128, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 36);
            this.label7.TabIndex = 16;
            this.label7.Text = "РЕЗУЛЬТАТ";
            // 
            // rectangleResult
            // 
            this.rectangleResult.Location = new System.Drawing.Point(232, 72);
            this.rectangleResult.Name = "rectangleResult";
            this.rectangleResult.Size = new System.Drawing.Size(202, 26);
            this.rectangleResult.TabIndex = 17;
            this.rectangleResult.TextChanged += new System.EventHandler(this.rectangleResult_TextChanged);
            // 
            // trapeseResult
            // 
            this.trapeseResult.Location = new System.Drawing.Point(232, 115);
            this.trapeseResult.Name = "trapeseResult";
            this.trapeseResult.Size = new System.Drawing.Size(202, 26);
            this.trapeseResult.TabIndex = 18;
            this.trapeseResult.TextChanged += new System.EventHandler(this.trapeseResult_TextChanged);
            // 
            // simpsonResult
            // 
            this.simpsonResult.Location = new System.Drawing.Point(232, 158);
            this.simpsonResult.Name = "simpsonResult";
            this.simpsonResult.Size = new System.Drawing.Size(202, 26);
            this.simpsonResult.TabIndex = 19;
            this.simpsonResult.TextChanged += new System.EventHandler(this.simpsonResult_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpsonResult);
            this.panel1.Controls.Add(this.trapeseResult);
            this.panel1.Controls.Add(this.rectangleResult);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 222);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formulaIntegral);
            this.panel2.Controls.Add(this.lowerIntegral);
            this.panel2.Controls.Add(this.upperIntegral);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 226);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 251);
            this.panel2.TabIndex = 21;
            // 
            // rectangleCheckBox
            // 
            this.rectangleCheckBox.AutoSize = true;
            this.rectangleCheckBox.Checked = true;
            this.rectangleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rectangleCheckBox.Location = new System.Drawing.Point(278, 78);
            this.rectangleCheckBox.Name = "rectangleCheckBox";
            this.rectangleCheckBox.Size = new System.Drawing.Size(223, 24);
            this.rectangleCheckBox.TabIndex = 22;
            this.rectangleCheckBox.Text = "Метод прямоугольников";
            this.rectangleCheckBox.UseVisualStyleBackColor = true;
            this.rectangleCheckBox.CheckedChanged += new System.EventHandler(this.rectangleCheckBox_CheckedChanged);
            // 
            // trapeseCheckBox
            // 
            this.trapeseCheckBox.AutoSize = true;
            this.trapeseCheckBox.Checked = true;
            this.trapeseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trapeseCheckBox.Location = new System.Drawing.Point(278, 128);
            this.trapeseCheckBox.Name = "trapeseCheckBox";
            this.trapeseCheckBox.Size = new System.Drawing.Size(162, 24);
            this.trapeseCheckBox.TabIndex = 23;
            this.trapeseCheckBox.Text = "Метод трапеций";
            this.trapeseCheckBox.UseVisualStyleBackColor = true;
            // 
            // simpsonCheckBox
            // 
            this.simpsonCheckBox.AutoSize = true;
            this.simpsonCheckBox.Checked = true;
            this.simpsonCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simpsonCheckBox.Location = new System.Drawing.Point(278, 175);
            this.simpsonCheckBox.Name = "simpsonCheckBox";
            this.simpsonCheckBox.Size = new System.Drawing.Size(165, 24);
            this.simpsonCheckBox.TabIndex = 24;
            this.simpsonCheckBox.Text = "Метод Симпсона";
            this.simpsonCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(280, 835);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(720, 69);
            this.label3.TabIndex = 25;
            this.label3.Text = "КУДА ПАЛИШ, ЧУШПАН";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Integral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 769);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.simpsonCheckBox);
            this.Controls.Add(this.trapeseCheckBox);
            this.Controls.Add(this.rectangleCheckBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Точность);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.epsilonTextBox);
            this.Controls.Add(this.countOfSteps);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Integral";
            this.Text = "Integral methods";
            this.Load += new System.EventHandler(this.Integral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox upperIntegral;
        private System.Windows.Forms.TextBox lowerIntegral;
        private System.Windows.Forms.TextBox formulaIntegral;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateFiotstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateSecondTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TextBox countOfSteps;
        private System.Windows.Forms.TextBox epsilonTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Точность;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem otherTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathFunctionsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rectangleResult;
        private System.Windows.Forms.TextBox trapeseResult;
        private System.Windows.Forms.TextBox simpsonResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox rectangleCheckBox;
        private System.Windows.Forms.CheckBox trapeseCheckBox;
        private System.Windows.Forms.CheckBox simpsonCheckBox;
        private System.Windows.Forms.Label label3;
    }
}