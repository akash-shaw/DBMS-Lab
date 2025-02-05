namespace BankingApp
{
    partial class Form2
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.TBbalance = new System.Windows.Forms.TextBox();
            this.BTNtransaction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBtransactions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(13, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(145, 24);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome, User!";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(17, 51);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 1;
            this.labelBalance.Text = "Balance";
            // 
            // TBbalance
            // 
            this.TBbalance.Location = new System.Drawing.Point(69, 48);
            this.TBbalance.Name = "TBbalance";
            this.TBbalance.ReadOnly = true;
            this.TBbalance.Size = new System.Drawing.Size(202, 20);
            this.TBbalance.TabIndex = 2;
            this.TBbalance.TextChanged += new System.EventHandler(this.TBbalance_TextChanged);
            // 
            // BTNtransaction
            // 
            this.BTNtransaction.Location = new System.Drawing.Point(17, 83);
            this.BTNtransaction.Name = "BTNtransaction";
            this.BTNtransaction.Size = new System.Drawing.Size(117, 23);
            this.BTNtransaction.TabIndex = 3;
            this.BTNtransaction.Text = "New Transaction";
            this.BTNtransaction.UseVisualStyleBackColor = true;
            this.BTNtransaction.Click += new System.EventHandler(this.BTNtransaction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Recent Transactions";
            // 
            // TBtransactions
            // 
            this.TBtransactions.Location = new System.Drawing.Point(17, 146);
            this.TBtransactions.Name = "TBtransactions";
            this.TBtransactions.ReadOnly = true;
            this.TBtransactions.Size = new System.Drawing.Size(254, 153);
            this.TBtransactions.TabIndex = 5;
            this.TBtransactions.Text = "";
            this.TBtransactions.TextChanged += new System.EventHandler(this.TBtransactions_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.TBtransactions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNtransaction);
            this.Controls.Add(this.TBbalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelWelcome);
            this.Name = "Form2";
            this.Text = "Welcome, User!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox TBbalance;
        private System.Windows.Forms.Button BTNtransaction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TBtransactions;


    }
}