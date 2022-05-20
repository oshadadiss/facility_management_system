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
    public partial class emailrequest : Form
    {
        public emailrequest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtemail.Text == "" || txtpass.Text == "" || txtcpass.Text == "")
            {
                MessageBox.Show("Please fill all the details");
            }
            else if (txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("Password doesn't match. Please try again");
                txtcpass.Text = "";
                txtpass.Text = "";
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
                        string quary2 = "SELECT * FROM slt_email WHERE sltusername = '" + txtemail.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(quary2, con2);
                        con2.Open();
                        SqlDataReader sdr2 = cmd2.ExecuteReader();
                        if (sdr2.Read())
                        {
                            MessageBox.Show("This email is already taken. Please enter a different email");
                            txtemail.Text = "";
                        }
                        else
                        {
                            SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                            string quary3 = "INSERT INTO slt_email(username,sltusername,password) VALUES('" + txtusername.Text + "','" + txtemail.Text + "','" + txtpass.Text + "')";
                            SqlCommand cmd3 = new SqlCommand(quary3, con3);
                            con3.Open();
                            cmd3.ExecuteNonQuery();
                            MessageBox.Show("Your request is recorded");
                            con3.Close();
                        }
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
