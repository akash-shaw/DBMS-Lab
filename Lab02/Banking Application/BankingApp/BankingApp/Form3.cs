using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void BTNreset_Click(object sender, EventArgs e)
        {
            if (TBUsername.Text == User.username)
            {
                if (TBPass.Text == TBPassConfirm.Text)
                {
                    Form1 f1 = new Form1();
                    User.password = TBPass.Text;
                    this.Hide();
                    f1.Show();
                }
                else
                {
                    labelMessage.Text = "Password doesn't match!";
                }
            }
            else
            {
                labelMessage.Text = "Invalid Username!";
            }
        }
    }
}
