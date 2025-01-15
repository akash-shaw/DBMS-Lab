namespace BankingApp
{
    partial class Form3
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
            this.TBUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TBPassConfirm = new System.Windows.Forms.TextBox();
            this.BTNreset = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // TBUsername
            // 
            this.TBUsername.Location = new System.Drawing.Point(15, 68);
            this.TBUsername.Name = "TBUsername";
            this.TBUsername.Size = new System.Drawing.Size(257, 20);
            this.TBUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password";
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(16, 108);
            this.TBPass.Name = "TBPass";
            this.TBPass.Size = new System.Drawing.Size(256, 20);
            this.TBPass.TabIndex = 4;
            this.TBPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Password";
            // 
            // TBPassConfirm
            // 
            this.TBPassConfirm.Location = new System.Drawing.Point(18, 152);
            this.TBPassConfirm.Name = "TBPassConfirm";
            this.TBPassConfirm.Size = new System.Drawing.Size(254, 20);
            this.TBPassConfirm.TabIndex = 6;
            this.TBPassConfirm.UseSystemPasswordChar = true;
            // 
            // BTNreset
            // 
            this.BTNreset.Location = new System.Drawing.Point(18, 179);
            this.BTNreset.Name = "BTNreset";
            this.BTNreset.Size = new System.Drawing.Size(75, 23);
            this.BTNreset.TabIndex = 7;
            this.BTNreset.Text = "Reset";
            this.BTNreset.UseVisualStyleBackColor = true;
            this.BTNreset.Click += new System.EventHandler(this.BTNreset_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(18, 209);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.BTNreset);
            this.Controls.Add(this.TBPassConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TBUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TBPassConfirm;
        private System.Windows.Forms.Button BTNreset;
        private System.Windows.Forms.Label labelMessage;
    }
}