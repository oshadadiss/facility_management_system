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
    public partial class SLTid : Form
    {
        public SLTid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "" || txtfname.Text == "" || txtdesignation.Text == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else
            {
                string username;
                username = txtusername.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                string quary = "SELECT * FROM accounts WHERE username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    if (sdr.Read())
                    {
                        SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                        string quary2 = "INSERT INTO slt_id(username,fullname,designation) VALUES('"+txtusername.Text+"','"+txtfname.Text+"','"+txtdesignation.Text+"')";
                        SqlCommand cmd2 = new SqlCommand(quary2, con2);
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Your request is recorded");
                        con2.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username does not exist. Please inform system admin");
                    }
                }
                catch (SqlException e1)
                {
                    MessageBox.Show("Exception" + e1);
                }
                finally
                {
                    con.Close();
                }
                
            }
            
        }
    }
}
