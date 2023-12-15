namespace DichtomyApp
{
    partial class SLAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLAE));
            this.label1 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.gaussCheckBox = new System.Windows.Forms.CheckBox();
            this.gaussJordanaCheckBox = new System.Windows.Forms.CheckBox();
            this.kramerCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mathFunktionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Gauss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaussJordano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cramer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.determinantTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "п - кол-во уравнений";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(33, 28);
            this.nTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(148, 26);
            this.nTextBox.TabIndex = 1;
            // 
            // gaussCheckBox
            // 
            this.gaussCheckBox.AutoSize = true;
            this.gaussCheckBox.Checked = true;
            this.gaussCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gaussCheckBox.Location = new System.Drawing.Point(33, 85);
            this.gaussCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gaussCheckBox.Name = "gaussCheckBox";
            this.gaussCheckBox.Size = new System.Drawing.Size(132, 24);
            this.gaussCheckBox.TabIndex = 2;
            this.gaussCheckBox.Text = "Метод Гауса";
            this.gaussCheckBox.UseVisualStyleBackColor = true;
            this.gaussCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gaussJordanaCheckBox
            // 
            this.gaussJordanaCheckBox.AutoSize = true;
            this.gaussJordanaCheckBox.Checked = true;
            this.gaussJordanaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gaussJordanaCheckBox.Location = new System.Drawing.Point(33, 126);
            this.gaussJordanaCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gaussJordanaCheckBox.Name = "gaussJordanaCheckBox";
            this.gaussJordanaCheckBox.Size = new System.Drawing.Size(214, 24);
            this.gaussJordanaCheckBox.TabIndex = 3;
            this.gaussJordanaCheckBox.Text = "Метод Гауса - Жордана";
            this.gaussJordanaCheckBox.UseVisualStyleBackColor = true;
            this.gaussJordanaCheckBox.CheckedChanged += new System.EventHandler(this.gaussJordanaCheckBox_CheckedChanged);
            // 
            // kramerCheckBox
            // 
            this.kramerCheckBox.AutoSize = true;
            this.kramerCheckBox.Checked = true;
            this.kramerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kramerCheckBox.Location = new System.Drawing.Point(33, 168);
            this.kramerCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kramerCheckBox.Name = "kramerCheckBox";
            this.kramerCheckBox.Size = new System.Drawing.Size(156, 24);
            this.kramerCheckBox.TabIndex = 4;
            this.kramerCheckBox.Text = "Метод Крамера";
            this.kramerCheckBox.UseVisualStyleBackColor = true;
            this.kramerCheckBox.CheckedChanged += new System.EventHandler(this.kramerCheckBox_CheckedChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearMenuToolStripMenuItem,
            this.importToolStripMenuItem,
            this.otherTasksToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1226, 33);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.calculateToolStripMenuItem.Text = "Calculate";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearMenuToolStripMenuItem
            // 
            this.clearMenuToolStripMenuItem.Name = "clearMenuToolStripMenuItem";
            this.clearMenuToolStripMenuItem.Size = new System.Drawing.Size(117, 29);
            this.clearMenuToolStripMenuItem.Text = "Clear menu";
            this.clearMenuToolStripMenuItem.Click += new System.EventHandler(this.clearMenuToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // otherTasksToolStripMenuItem
            // 
            this.otherTasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mathFunktionsToolStripMenuItem});
            this.otherTasksToolStripMenuItem.Name = "otherTasksToolStripMenuItem";
            this.otherTasksToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.otherTasksToolStripMenuItem.Text = "Other tasks";
            this.otherTasksToolStripMenuItem.Click += new System.EventHandler(this.otherTasksToolStripMenuItem_Click);
            // 
            // mathFunktionsToolStripMenuItem
            // 
            this.mathFunktionsToolStripMenuItem.Name = "mathFunktionsToolStripMenuItem";
            this.mathFunktionsToolStripMenuItem.Size = new System.Drawing.Size(233, 34);
            this.mathFunktionsToolStripMenuItem.Text = "Math functions";
            this.mathFunktionsToolStripMenuItem.Click += new System.EventHandler(this.mathFunktionsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.kramerCheckBox);
            this.panel1.Controls.Add(this.gaussJordanaCheckBox);
            this.panel1.Controls.Add(this.gaussCheckBox);
            this.panel1.Controls.Add(this.nTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 232);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Построить сетку ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(551, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(675, 710);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Gauss,
            this.GaussJordano,
            this.Cramer});
            this.dataGridView2.Location = new System.Drawing.Point(26, 374);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(477, 398);
            this.dataGridView2.TabIndex = 9;
            // 
            // Gauss
            // 
            this.Gauss.HeaderText = "Gauss";
            this.Gauss.MinimumWidth = 8;
            this.Gauss.Name = "Gauss";
            this.Gauss.Width = 150;
            // 
            // GaussJordano
            // 
            this.GaussJordano.HeaderText = "GaussJordano";
            this.GaussJordano.MinimumWidth = 8;
            this.GaussJordano.Name = "GaussJordano";
            this.GaussJordano.Width = 150;
            // 
            // Cramer
            // 
            this.Cramer.HeaderText = "Cramer";
            this.Cramer.MinimumWidth = 8;
            this.Cramer.Name = "Cramer";
            this.Cramer.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Определитель матрицы";
            // 
            // determinantTextBox
            // 
            this.determinantTextBox.Location = new System.Drawing.Point(238, 340);
            this.determinantTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.determinantTextBox.Name = "determinantTextBox";
            this.determinantTextBox.Size = new System.Drawing.Size(148, 26);
            this.determinantTextBox.TabIndex = 5;
            // 
            // SLAE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1226, 788);
            this.Controls.Add(this.determinantTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SLAE";
            this.Text = "SLAE";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.CheckBox gaussCheckBox;
        private System.Windows.Forms.CheckBox gaussJordanaCheckBox;
        private System.Windows.Forms.CheckBox kramerCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem otherTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mathFunktionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gauss;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaussJordano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cramer;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox determinantTextBox;
        private System.Windows.Forms.Button button1;
    }
}