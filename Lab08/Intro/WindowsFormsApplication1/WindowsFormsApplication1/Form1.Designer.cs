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
            this.connect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GetGrid = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Quo1 = new System.Windows.Forms.Button();
            this.Quo2 = new System.Windows.Forms.Button();
            this.Quo3 = new System.Windows.Forms.Button();
            this.Quo4 = new System.Windows.Forms.Button();
            this.Quo5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(104, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(66, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(66, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(206, 20);
            this.textBox3.TabIndex = 3;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(23, 12);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 23);
            this.prev.TabIndex = 4;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(186, 11);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 5;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(23, 42);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 23);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "REGNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "MODEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "YEAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(355, 249);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GetGrid
            // 
            this.GetGrid.Location = new System.Drawing.Point(186, 41);
            this.GetGrid.Name = "GetGrid";
            this.GetGrid.Size = new System.Drawing.Size(75, 23);
            this.GetGrid.TabIndex = 11;
            this.GetGrid.Text = "Get Grid";
            this.GetGrid.UseVisualStyleBackColor = true;
            this.GetGrid.Click += new System.EventHandler(this.GetGrid_Click_1);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(104, 42);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 12;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Car";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Lab4 Queries";
            // 
            // Quo1
            // 
            this.Quo1.Location = new System.Drawing.Point(18, 471);
            this.Quo1.Name = "Quo1";
            this.Quo1.Size = new System.Drawing.Size(75, 23);
            this.Quo1.TabIndex = 16;
            this.Quo1.Text = "Quo1";
            this.Quo1.UseVisualStyleBackColor = true;
            this.Quo1.Click += new System.EventHandler(this.Quo1_Click);
            // 
            // Quo2
            // 
            this.Quo2.Location = new System.Drawing.Point(100, 470);
            this.Quo2.Name = "Quo2";
            this.Quo2.Size = new System.Drawing.Size(75, 23);
            this.Quo2.TabIndex = 17;
            this.Quo2.Text = "Quo2";
            this.Quo2.UseVisualStyleBackColor = true;
            this.Quo2.Click += new System.EventHandler(this.Quo2_Click);
            // 
            // Quo3
            // 
            this.Quo3.Location = new System.Drawing.Point(186, 469);
            this.Quo3.Name = "Quo3";
            this.Quo3.Size = new System.Drawing.Size(75, 23);
            this.Quo3.TabIndex = 18;
            this.Quo3.Text = "Quo3";
            this.Quo3.UseVisualStyleBackColor = true;
            this.Quo3.Click += new System.EventHandler(this.Quo3_Click);
            // 
            // Quo4
            // 
            this.Quo4.Location = new System.Drawing.Point(268, 471);
            this.Quo4.Name = "Quo4";
            this.Quo4.Size = new System.Drawing.Size(75, 23);
            this.Quo4.TabIndex = 19;
            this.Quo4.Text = "Quo4";
            this.Quo4.UseVisualStyleBackColor = true;
            this.Quo4.Click += new System.EventHandler(this.Quo4_Click);
            // 
            // Quo5
            // 
            this.Quo5.Location = new System.Drawing.Point(350, 471);
            this.Quo5.Name = "Quo5";
            this.Quo5.Size = new System.Drawing.Size(75, 23);
            this.Quo5.TabIndex = 20;
            this.Quo5.Text = "Quo5";
            this.Quo5.UseVisualStyleBackColor = true;
            this.Quo5.Click += new System.EventHandler(this.Quo5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 585);
            this.Controls.Add(this.Quo5);
            this.Controls.Add(this.Quo4);
            this.Controls.Add(this.Quo3);
            this.Controls.Add(this.Quo2);
            this.Controls.Add(this.Quo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.GetGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.next);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button GetGrid;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Quo1;
        private System.Windows.Forms.Button Quo2;
        private System.Windows.Forms.Button Quo3;
        private System.Windows.Forms.Button Quo4;
        private System.Windows.Forms.Button Quo5;
    }
}

