using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Facility_Management_System
{
    public partial class SH_window : Form
    {
        string getname;
        public SH_window(string name)
        {
            InitializeComponent();
            getname = name;
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
            string quary1 = "SELECT firstname FROM accounts WHERE username ='" + getname + "'";
            SqlCommand cmd1 = new SqlCommand(quary1, con1);
            con1.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            lblname1.Text = sdr1["firstname"].ToString();
            con1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30";
            string quary2 = "SELECT * FROM slt_id";
            SqlDataAdapter adapter1 = new SqlDataAdapter(quary2, constring);
            DataSet set1 = new DataSet();
            adapter1.Fill(set1, "slt_id");
            dgv1.DataSource = set1.Tables["slt_id"];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30";
            string quary2 = "SELECT * FROM slt_email";
            SqlDataAdapter adapter1 = new SqlDataAdapter(quary2, constring);
            DataSet set1 = new DataSet();
            adapter1.Fill(set1, "slt_email");
            dgv1.DataSource = set1.Tables["slt_email"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30";
            string quary2 = "SELECT * FROM pool_vehicle";
            SqlDataAdapter adapter1 = new SqlDataAdapter(quary2, constring);
            DataSet set1 = new DataSet();
            adapter1.Fill(set1, "pool_vehicle");
            dgv1.DataSource = set1.Tables["pool_vehicle"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30";
            string quary2 = "SELECT * FROM vehicle_transfer";
            SqlDataAdapter adapter1 = new SqlDataAdapter(quary2, constring);
            DataSet set1 = new DataSet();
            adapter1.Fill(set1, "vehicle_transfer");
            dgv1.DataSource = set1.Tables["vehicle_transfer"];
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Close();
            F1.Show();
        }
    }
}
