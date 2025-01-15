using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNsignin_Click(object sender, EventArgs e)
        {
            if (TBusername.Text == User.username && TBpass.Text == User.password)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
            {
                label4.Text = "Invalid Credentials";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTNsignup_Click(object sender, EventArgs e)
        {
            User.username = TBusername.Text;
            User.password = TBpass.Text;
        }

        private void linkForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }
    }
    public static class User{
        public static string username = "Akash";
        public static string password = "1234";
        public static float balance = 500;
        public static Queue<string> transactions = new Queue<string>();

        public static bool transaction(float amount, string type)
        {
            if(type == "credit")
            {
                balance += amount;
                string newTransacMessage = "Credited "+amount + " on " + DateTime.Now.ToShortDateString();
                transactions.Enqueue(newTransacMessage);
                if(transactions.Count > 5)
                    transactions.Dequeue();
                return true;
            }
            else if(type == "debit")
            {
                if(amount>balance)  return false;
                
                balance -= amount;
                string newTransacMessage = "Debited "+amount + " on " + DateTime.Now.ToShortDateString();
                transactions.Enqueue(newTransacMessage);
                if(transactions.Count>5)
                    transactions.Dequeue();
                return true;
            }
            return false;
        }
    }
}
