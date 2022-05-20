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
    public partial class admin_window : Form
    {
        public string getname;
        public admin_window(string name)
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
            this.Close();
            F1.Show();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            app_window app = new app_window(getname);
            this.Hide();
            app.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_account add = new add_account(getname);
            this.Hide();
            add.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_update_account DU = new delete_update_account(getname);
            this.Hide();
            DU.Show();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
