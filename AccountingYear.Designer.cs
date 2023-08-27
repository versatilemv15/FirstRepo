namespace BankApp1
{
    partial class AccountingYear
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
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SetYearBtn = new System.Windows.Forms.Button();
            this.YearTb = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CurrYearL = new System.Windows.Forms.Label();
            this.YearL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrYearCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(347, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.White;
            this.ExitBtn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.Location = new System.Drawing.Point(145, 377);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SetYearBtn
            // 
            this.SetYearBtn.BackColor = System.Drawing.Color.White;
            this.SetYearBtn.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetYearBtn.ForeColor = System.Drawing.Color.Black;
            this.SetYearBtn.Location = new System.Drawing.Point(50, 377);
            this.SetYearBtn.Name = "SetYearBtn";
            this.SetYearBtn.Size = new System.Drawing.Size(75, 23);
            this.SetYearBtn.TabIndex = 4;
            this.SetYearBtn.Text = "Set Year";
            this.SetYearBtn.UseVisualStyleBackColor = false;
            this.SetYearBtn.Click += new System.EventHandler(this.SetYearBtn_Click);
            // 
            // YearTb
            // 
            this.YearTb.Location = new System.Drawing.Point(89, 171);
            this.YearTb.Name = "YearTb";
            this.YearTb.Size = new System.Drawing.Size(100, 21);
            this.YearTb.TabIndex = 5;
            this.YearTb.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(396, 374);
            this.dataGridView1.TabIndex = 4;
            // 
            // CurrYearL
            // 
            this.CurrYearL.AutoSize = true;
            this.CurrYearL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrYearL.ForeColor = System.Drawing.Color.Black;
            this.CurrYearL.Location = new System.Drawing.Point(71, 268);
            this.CurrYearL.Name = "CurrYearL";
            this.CurrYearL.Size = new System.Drawing.Size(129, 19);
            this.CurrYearL.TabIndex = 1;
            this.CurrYearL.Text = "Set Current Year";
            // 
            // YearL
            // 
            this.YearL.AutoSize = true;
            this.YearL.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YearL.ForeColor = System.Drawing.Color.Black;
            this.YearL.Location = new System.Drawing.Point(84, 120);
            this.YearL.Name = "YearL";
            this.YearL.Size = new System.Drawing.Size(116, 19);
            this.YearL.TabIndex = 0;
            this.YearL.Text = "Add New Year:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CurrYearCB);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.YearTb);
            this.panel1.Controls.Add(this.SetYearBtn);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.YearL);
            this.panel1.Controls.Add(this.CurrYearL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 600);
            this.panel1.TabIndex = 3;
            // 
            // CurrYearCB
            // 
            this.CurrYearCB.FormattingEnabled = true;
            this.CurrYearCB.Items.AddRange(new object[] {
            "2001-2005",
            "2006-2010",
            "2011-2015",
            "2016-2020",
            "2021-2025",
            "2026-2030",
            "2031-2035",
            "2036-2040",
            "2041-2045",
            "2046-2050"});
            this.CurrYearCB.Location = new System.Drawing.Point(63, 315);
            this.CurrYearCB.Name = "CurrYearCB";
            this.CurrYearCB.Size = new System.Drawing.Size(146, 23);
            this.CurrYearCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(50, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "INSERT YEAR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(100, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AccountingYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountingYear";
            this.Text = "AccountingYear";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button ExitBtn;
        private Button SetYearBtn;
        private RichTextBox YearTb;
        private DataGridView dataGridView1;
        private Label CurrYearL;
        private Label YearL;
        private Panel panel1;
        private Label label4;
        private ComboBox CurrYearCB;
        private Button button1;
    }
}