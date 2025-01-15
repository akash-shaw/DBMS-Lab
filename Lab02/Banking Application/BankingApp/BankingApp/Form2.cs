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
            foreach(string transaction in User.transactions)
            {
                TBtransactions.Text += transaction + "\n";
            }
        }
    }
}
