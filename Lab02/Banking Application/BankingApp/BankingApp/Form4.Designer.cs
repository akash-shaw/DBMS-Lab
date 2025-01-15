namespace BankingApp
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBamount = new System.Windows.Forms.TextBox();
            this.BTNcredit = new System.Windows.Forms.Button();
            this.BTNdebit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // TBamount
            // 
            this.TBamount.Location = new System.Drawing.Point(20, 69);
            this.TBamount.Name = "TBamount";
            this.TBamount.Size = new System.Drawing.Size(252, 20);
            this.TBamount.TabIndex = 2;
            // 
            // BTNcredit
            // 
            this.BTNcredit.Location = new System.Drawing.Point(20, 96);
            this.BTNcredit.Name = "BTNcredit";
            this.BTNcredit.Size = new System.Drawing.Size(75, 23);
            this.BTNcredit.TabIndex = 3;
            this.BTNcredit.Text = "Credit";
            this.BTNcredit.UseVisualStyleBackColor = true;
            this.BTNcredit.Click += new System.EventHandler(this.BTNcredit_Click);
            // 
            // BTNdebit
            // 
            this.BTNdebit.Location = new System.Drawing.Point(102, 96);
            this.BTNdebit.Name = "BTNdebit";
            this.BTNdebit.Size = new System.Drawing.Size(75, 23);
            this.BTNdebit.TabIndex = 4;
            this.BTNdebit.Text = "Debit";
            this.BTNdebit.UseVisualStyleBackColor = true;
            this.BTNdebit.Click += new System.EventHandler(this.BTNdebit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BTNdebit);
            this.Controls.Add(this.BTNcredit);
            this.Controls.Add(this.TBamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBamount;
        private System.Windows.Forms.Button BTNcredit;
        private System.Windows.Forms.Button BTNdebit;
    }
}