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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void BTNcredit_Click(object sender, EventArgs e)
        {
            float amount = float.Parse(TBamount.Text);
            User.transaction(amount, "credit");
        }

        private void BTNdebit_Click(object sender, EventArgs e)
        {
            float amount = float.Parse(TBamount.Text);
            User.transaction(amount, "debit");
        }
    }
}
