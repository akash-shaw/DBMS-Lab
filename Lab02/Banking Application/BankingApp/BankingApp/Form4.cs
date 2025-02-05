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
            if (TBamount.Text == null) return;
            float amount = float.Parse(TBamount.Text);
            User.transaction(amount, "credit");
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void BTNdebit_Click(object sender, EventArgs e)
        {
            if (TBamount.Text == null) return;
            float amount = float.Parse(TBamount.Text);
            User.transaction(amount, "debit");
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
    }
}
