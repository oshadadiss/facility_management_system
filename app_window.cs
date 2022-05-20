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
    public partial class app_window : Form
    {
        string getname;
        public app_window(string name)
        {
            InitializeComponent();
            getname = name;
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
            string quary1 = "SELECT firstname FROM accounts WHERE username ='" + getname + "'";
            SqlCommand cmd1 = new SqlCommand(quary1, con1);
            con1.Open();
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            sdr1.Read();
            lblname.Text = sdr1["firstname"].ToString();
            con1.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Hide();
            F1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLTid ID = new SLTid();
            ID.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            emailrequest email = new emailrequest();
            email.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pool_vehicle pool = new pool_vehicle();
            pool.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vehicle_transfer vehicle = new vehicle_transfer();
            vehicle.Show();
        }
    }
}
