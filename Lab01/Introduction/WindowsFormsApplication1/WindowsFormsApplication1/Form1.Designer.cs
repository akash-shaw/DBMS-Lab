namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.UN = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.Label();
            this.TB_UN = new System.Windows.Forms.TextBox();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LB_COL = new System.Windows.Forms.Label();
            this.RB_MALE = new System.Windows.Forms.RadioButton();
            this.RB_FEMALE = new System.Windows.Forms.RadioButton();
            this.GENDER = new System.Windows.Forms.Label();
            this.BT_RESET = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UN
            // 
            this.UN.AutoSize = true;
            this.UN.Location = new System.Drawing.Point(16, 11);
            this.UN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UN.Name = "UN";
            this.UN.Size = new System.Drawing.Size(70, 16);
            this.UN.TabIndex = 1;
            this.UN.Text = "Username";
            this.UN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UN.Click += new System.EventHandler(this.UN_Click);
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Location = new System.Drawing.Point(16, 44);
            this.PW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(67, 16);
            this.PW.TabIndex = 2;
            this.PW.Text = "Password";
            this.PW.Click += new System.EventHandler(this.PW_Click);
            // 
            // TB_UN
            // 
            this.TB_UN.Location = new System.Drawing.Point(97, 7);
            this.TB_UN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_UN.Name = "TB_UN";
            this.TB_UN.Size = new System.Drawing.Size(132, 22);
            this.TB_UN.TabIndex = 3;
            // 
            // TB_PW
            // 
            this.TB_PW.Location = new System.Drawing.Point(97, 41);
            this.TB_PW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.Size = new System.Drawing.Size(132, 22);
            this.TB_PW.TabIndex = 4;
            this.TB_PW.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 132);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboBox1.Location = new System.Drawing.Point(97, 98);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LB_COL
            // 
            this.LB_COL.AutoSize = true;
            this.LB_COL.Location = new System.Drawing.Point(16, 102);
            this.LB_COL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_COL.Name = "LB_COL";
            this.LB_COL.Size = new System.Drawing.Size(46, 16);
            this.LB_COL.TabIndex = 7;
            this.LB_COL.Text = "Colour";
            // 
            // RB_MALE
            // 
            this.RB_MALE.AutoSize = true;
            this.RB_MALE.Location = new System.Drawing.Point(97, 74);
            this.RB_MALE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_MALE.Name = "RB_MALE";
            this.RB_MALE.Size = new System.Drawing.Size(58, 20);
            this.RB_MALE.TabIndex = 8;
            this.RB_MALE.TabStop = true;
            this.RB_MALE.Text = "Male";
            this.RB_MALE.UseVisualStyleBackColor = true;
            // 
            // RB_FEMALE
            // 
            this.RB_FEMALE.AutoSize = true;
            this.RB_FEMALE.Location = new System.Drawing.Point(171, 74);
            this.RB_FEMALE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RB_FEMALE.Name = "RB_FEMALE";
            this.RB_FEMALE.Size = new System.Drawing.Size(74, 20);
            this.RB_FEMALE.TabIndex = 9;
            this.RB_FEMALE.TabStop = true;
            this.RB_FEMALE.Text = "Female";
            this.RB_FEMALE.UseVisualStyleBackColor = true;
            // 
            // GENDER
            // 
            this.GENDER.AutoSize = true;
            this.GENDER.Location = new System.Drawing.Point(16, 76);
            this.GENDER.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GENDER.Name = "GENDER";
            this.GENDER.Size = new System.Drawing.Size(52, 16);
            this.GENDER.TabIndex = 10;
            this.GENDER.Text = "Gender";
            // 
            // BT_RESET
            // 
            this.BT_RESET.Location = new System.Drawing.Point(205, 132);
            this.BT_RESET.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_RESET.Name = "BT_RESET";
            this.BT_RESET.Size = new System.Drawing.Size(100, 28);
            this.BT_RESET.TabIndex = 11;
            this.BT_RESET.Text = "Reset";
            this.BT_RESET.UseVisualStyleBackColor = true;
            this.BT_RESET.Click += new System.EventHandler(this.BT_RESET_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox2.Location = new System.Drawing.Point(265, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 222);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.BT_RESET);
            this.Controls.Add(this.GENDER);
            this.Controls.Add(this.RB_FEMALE);
            this.Controls.Add(this.RB_MALE);
            this.Controls.Add(this.LB_COL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_PW);
            this.Controls.Add(this.TB_UN);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.UN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MyForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UN;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.TextBox TB_UN;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LB_COL;
        private System.Windows.Forms.RadioButton RB_MALE;
        private System.Windows.Forms.RadioButton RB_FEMALE;
        private System.Windows.Forms.Label GENDER;
        private System.Windows.Forms.Button BT_RESET;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

