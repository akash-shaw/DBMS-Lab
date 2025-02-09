using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        String result;
        String num;
        String op;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateTB()
        {
            TB_RESULT.Text = result;
            TB_NUM.Text = num;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            num += button1.Text;
            updateTB();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            num += button2.Text;
            updateTB();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            num += button3.Text;
            updateTB();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            num += button4.Text;
            updateTB();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            num += button5.Text;
            updateTB();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            num += button6.Text;
            updateTB();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            num += button7.Text;
            updateTB();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            num += button8.Text;
            updateTB();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            num += button9.Text;
            updateTB();
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            num += button0.Text;
            updateTB();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            num += buttonDot.Text;
            updateTB();
        }

        private void add_Click(object sender, EventArgs e)
        {
            op = "+";
            if (result == null)
            {
                result = num;
                num = null;
            }
            else{
                double n1, n2;
                double.TryParse(result, out n1);
                double.TryParse(num, out n2);
                double r = n1 + n2;
                result = r.ToString();
                num = null;
            }
            updateTB();
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            op = "-";
            if (num == null)
            {
                num += "-";
            }
            else if (result == null)
            {
                result = num;
                num = null;
            }
            else
            {
                double n1, n2;
                double.TryParse(result, out n1);
                double.TryParse(num, out n2);
                double r = n1 - n2;
                result = r.ToString();
                num = null;
            }
            updateTB();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            op = "*";
            if (result == null)
            {
                result = num;
                num = null;
            }
            else
            {
                double n1, n2;
                double.TryParse(result, out n1);
                double.TryParse(num, out n2);
                double r = n1 * n2;
                result = r.ToString();
                num = null;
            }
            updateTB();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            op = "/";
            if (result == null)
            {
                result = num;
                num = null;
            }
            else
            {
                double n1, n2;
                double.TryParse(result, out n1);
                double.TryParse(num, out n2);
                double r = n1 / n2;
                result = r.ToString();
                num = null;
            }
            updateTB();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            double n1, n2;
            double res=0;
            double.TryParse(result, out n1);
            double.TryParse(num, out n2);
            switch (op)
            {
                case "+": res = n1 + n2; break;
                case "-": res = n1 - n2; break;
                case "*": res = n1 * n2; break;
                case "/": res = n1 / n2; break;
            }
            result = res.ToString();
            num = null;
            updateTB();
        }
    }
}
