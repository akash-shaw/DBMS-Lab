using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UN_Click(object sender, EventArgs e)
        {

        }

        private void PW_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_UN.Text == "Akash")
                MessageBox.Show("Welcome!");
            else
                MessageBox.Show("Invalid Credentials!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BT_RESET_Click(object sender, EventArgs e)
        {
            TB_UN.Text = "";
            TB_PW.Text = "";
        }
    }
}
