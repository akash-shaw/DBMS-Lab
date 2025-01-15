namespace BankingApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBusername = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.BTNsignin = new System.Windows.Forms.Button();
            this.BTNsignup = new System.Windows.Forms.Button();
            this.linkForgotPass = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "State Bank of Ohio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // TBusername
            // 
            this.TBusername.Location = new System.Drawing.Point(16, 65);
            this.TBusername.Name = "TBusername";
            this.TBusername.Size = new System.Drawing.Size(256, 20);
            this.TBusername.TabIndex = 3;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(16, 105);
            this.TBpass.Name = "TBpass";
            this.TBpass.PasswordChar = '1';
            this.TBpass.Size = new System.Drawing.Size(256, 20);
            this.TBpass.TabIndex = 4;
            this.TBpass.UseSystemPasswordChar = true;
            // 
            // BTNsignin
            // 
            this.BTNsignin.Location = new System.Drawing.Point(16, 132);
            this.BTNsignin.Name = "BTNsignin";
            this.BTNsignin.Size = new System.Drawing.Size(75, 23);
            this.BTNsignin.TabIndex = 5;
            this.BTNsignin.Text = "Sign In";
            this.BTNsignin.UseVisualStyleBackColor = true;
            this.BTNsignin.Click += new System.EventHandler(this.BTNsignin_Click);
            // 
            // BTNsignup
            // 
            this.BTNsignup.Location = new System.Drawing.Point(97, 132);
            this.BTNsignup.Name = "BTNsignup";
            this.BTNsignup.Size = new System.Drawing.Size(75, 23);
            this.BTNsignup.TabIndex = 6;
            this.BTNsignup.Text = "Sign Up";
            this.BTNsignup.UseVisualStyleBackColor = true;
            this.BTNsignup.Click += new System.EventHandler(this.BTNsignup_Click);
            // 
            // linkForgotPass
            // 
            this.linkForgotPass.AutoSize = true;
            this.linkForgotPass.Location = new System.Drawing.Point(180, 88);
            this.linkForgotPass.Name = "linkForgotPass";
            this.linkForgotPass.Size = new System.Drawing.Size(92, 13);
            this.linkForgotPass.TabIndex = 7;
            this.linkForgotPass.TabStop = true;
            this.linkForgotPass.Text = "Forgot Password?";
            this.linkForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgotPass_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkForgotPass);
            this.Controls.Add(this.BTNsignup);
            this.Controls.Add(this.BTNsignin);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBusername;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Button BTNsignin;
        private System.Windows.Forms.Button BTNsignup;
        private System.Windows.Forms.LinkLabel linkForgotPass;
        private System.Windows.Forms.Label label4;
    }
}

