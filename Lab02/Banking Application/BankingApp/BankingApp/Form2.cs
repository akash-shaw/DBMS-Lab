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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            labelWelcome.Text = "Welcome, " + User.username + "!";
            TBbalance.Text = User.balance.ToString();
            updateTransactions();
        }
        public void updateTransactions()
        {
            TBtransactions.Text = "";
            foreach(string transaction in User.transactions)
            {
                TBtransactions.Text += transaction + "\n";
            }
            TBbalance.Text = User.balance.ToString();
        }

        private void BTNtransaction_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void TBtransactions_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBbalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
