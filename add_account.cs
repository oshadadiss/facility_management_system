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
    public partial class add_account : Form
    {
        string getname;
        public add_account(string name)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string post = "", section = "";

            if (txtfname.Text == "" || txtlname.Text == "" || txtcontact.Text == "" || txtnic.Text == "" || txtemail.Text == "" || txtusername.Text == "" || txtpass.Text == "" || txtcpass.Text == "")
            {
                MessageBox.Show("Please fill every field");
            }
            else if (!rbsection.Checked && !rbstaff.Checked && !rbadmin.Checked)
            {
                MessageBox.Show("Please select users post");
            }
            else if (txtpass.Text != txtcpass.Text)
            {
                MessageBox.Show("Password doesn't match. Please enter password correctly");
                txtcpass.Text = "";
                txtpass.Text = "";
            }
            else if (!rbadmindept.Checked && !rbhrdept.Checked && !rbtransdept.Checked && !rbtechnical.Checked)
            {
                MessageBox.Show("Please select the user's department");
            }
            else
            {
                if (rbadmin.Checked)
                {
                    post = "admin";
                }
                else if (rbsection.Checked)
                {
                    post = "SH";
                }
                else if (rbstaff.Checked)
                {
                    post = "staff";
                }

                if (rbadmindept.Checked)
                {
                    section = "admin";
                }
                else if (rbhrdept.Checked)
                {
                    section = "HR";
                }
                else if (rbtechnical.Checked)
                {
                    section = "technical";
                }
                else if (rbtransdept.Checked)
                {
                    section = "transport";
                }
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                string quary = "SELECT * FROM accounts WHERE username = '" + txtusername.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    if (sdr.Read())
                    {
                        MessageBox.Show("This username is already taken. Please enter a new one");
                        txtusername.Text = "";
                    }
                    else
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                        string quary1 = "INSERT INTO accounts(firstname,lastname,nic,email,contact,username,password,post,department) VALUES('" + txtfname.Text + "','" + txtlname.Text + "','" + txtnic.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtusername.Text + "','" + txtpass.Text + "','" + post + "','" + section + "')";
                        SqlCommand cmd1 = new SqlCommand(quary1, con1);
                        try
                        {
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Account created successfully");
                        }
                        catch (SqlException e1)
                        {
                            MessageBox.Show("Exception" + e1);
                        }
                        finally
                        {
                            con1.Close();
                        }
                    }


                }
                catch (SqlException e2)
                {
                    MessageBox.Show("Exception" + e2);
                }
                finally
                {
                    con.Close();
                }
            }   

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Close();
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_window admin = new admin_window(getname);
            this.Hide();
            admin.Show();
        }
    }
}
