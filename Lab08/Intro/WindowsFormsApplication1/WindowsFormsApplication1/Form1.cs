using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // Click on Close button should close the complete application.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit the Application?", "Exit", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            //e.Cancel = true;
            Application.Exit();
        }
        //Connecting to the database through the connection string
        public void connect1()
        {
            String oradb = "DATA SOURCE=172.16.54.24:1521/ictorcl;USER ID=CCE230953254;Password=student";
            conn = new OracleConnection(oradb); // C# 
            conn.Open();
        }
        //On Button click connects to database and fetches the first tuple data
        private void button1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand(); comm.CommandText = "select * from car";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"]; int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox1.Text = dr["regno"].ToString();
            textBox2.Text = dr["model"].ToString(); 
            textBox3.Text = dr["year"].ToString(); 
            conn.Close();  
        }
        //On Next click it displays the next tuple in the database. And repeats in a loop once it reaches the last tuple.
        private void next_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count) i = 0;
            dr = dt.Rows[i];
            textBox1.Text = dr["regno"].ToString(); 
            textBox2.Text = dr["model"].ToString(); 
            textBox3.Text = dr["year"].ToString();
        }
        //Display previous tuple.
        private void prev_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = dt.Rows.Count - 1;
            }
            dr = dt.Rows[i];
            textBox1.Text = dr["regno"].ToString(); 
            textBox2.Text = dr["model"].ToString(); 
            textBox3.Text = dr["year"].ToString();
        }

        //Insert into the table
        private void Insert_Click(object sender, EventArgs e)
        {
            connect1();
            int year = int.Parse(textBox3.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into car values('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')"; 
            cm.CommandType = CommandType.Text;
            cm.ExecuteNonQuery();
            MessageBox.Show("Inserted!");
            conn.Close();
        }
        //Updates into a table
        private void Update_Click_1(object sender, EventArgs e)
        {
            connect1();
            int year = int.Parse(textBox3.Text);
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "update car set year=:pyear where regno=:pregno";
            cm.CommandType = CommandType.Text;
            //Uses OracleParameter to read the parameter from the GUI
            OracleParameter pa1 = new OracleParameter();
            pa1.ParameterName = "pyear";
            pa1.DbType = DbType.Int32;
            pa1.Value = year;
            OracleParameter pa2 = new OracleParameter();
            pa2.ParameterName = "pregno";
            pa2.DbType = DbType.String; 
            pa2.Value = textBox1.Text;
            cm.Parameters.Add(pa1);
            cm.Parameters.Add(pa2); 
            cm.ExecuteNonQuery(); 
            MessageBox.Show("updated"); 
            conn.Close();
        }
        //Below is the code snippet to illustrate the use of DataGridView. Have a button and
        //datagridview control on the form. On click of the button below code is called
        private void GetGrid_Click_1(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select * from car";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }
        //Following is the code snippet to populate a combo box from database.
        //Have a combobox on the form and call below code on form load.
        private void Form1_Load(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select model from car";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "model";
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Quo1_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select count(distinct pt.driver_id) as \"total people involved in accidents in 2008\" from accident a join participated pt on a.report_number=pt.report_number where extract(year from a.accd_date)=2008";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }

        private void Quo2_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select count(distinct p.report_number) as \"Accident count\" from participated pt join car c on pt.regno=c.regno where c.model='Honda Civic'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }

        private void Quo3_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select pr.name as owner_name, count(pt.report_number) as \"NO. of Accidents\", sum(pt.damage_amount) as \"Total_Damage\" from participated pt join person pr on pt.driver_id = pr.driver_id group by pr.name order by sum(pt.damage_amount) desc";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }

        private void Quo4_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select pr.name, pr.driver_id, count(pt.report_number) as accidents from person pr join participated pt on pr.driver_id = pt.driver_id join accident a on pt.report_number = a.report_number group by pr.driver_id, pr.name having count(pt.report_number)<2";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }

        private void Quo5_Click(object sender, EventArgs e)
        {
            connect1();
            comm = new OracleCommand();
            comm.CommandText = "select pr.name, pr.driver_id, count(pt.report_number) as accidents from person pr full join owns o on pr.driver_id=o.driver_id full join participated pt on pr.driver_id = pt.driver_id full join accident a on pt.report_number = a.report_number group by pr.driver_id, pr.name having count(pt.report_number)=0";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "car");
            dt = ds.Tables["car"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "car";
            conn.Close();
        }
    }
}
