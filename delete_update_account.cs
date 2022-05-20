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
    public partial class delete_update_account : Form
    {
        string getname;
        public delete_update_account( string name)
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

            if(txtusername.Text == "")
            {
                MessageBox.Show("Please enter the username of the account");
            }
            else if (!rbsection.Checked && !rbstaff.Checked && !rbadmin.Checked)
            {
                MessageBox.Show("Please select users post");
            }
            else if (txtfname.Text == "" || txtlname.Text == "" || txtcontact.Text == "" || txtnic.Text == "" || txtemail.Text == "" || txtpass.Text == "" || txtcpass.Text == "")
            {
                MessageBox.Show("Please fill every field");
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

                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                string quary1 = "UPDATE accounts SET firstname = '"+txtfname.Text+"',lastname = '"+txtlname.Text+"',nic = '"+txtnic.Text+"',email = '"+txtemail.Text+"',contatc = '"+txtcontact.Text+"',password = '"+txtpass.Text+"',post = '"+post+"',department = '"+section+"' WHERE username = '"+txtusername.Text+"'";
                SqlCommand cmd1 = new SqlCommand(quary1, con1);
                try
                {
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Account Updated successfully");
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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
            string quary2 = "DELETE * FROM accounts WHERE username = '" + txtusername.Text + "'";
            SqlCommand cmd2 = new SqlCommand(quary2, con2);
            try
            {
                con2.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Account Deleted successfully");
            }
            catch (SqlException e1)
            {
                MessageBox.Show("Exception" + e1);
            }
            finally
            {
                con2.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "")
            {
                MessageBox.Show("Please enter username");
            }
            else
            {
                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30";
                string quary3 = "SELECT * FROM accounts WHERE username = '" + txtusername.Text + "'";
                SqlDataAdapter adapter1 = new SqlDataAdapter(quary3, constring);
                DataSet set1 = new DataSet();
                adapter1.Fill(set1, "accounts");
                dgv1.DataSource = set1.Tables["accounts"];
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_window admin = new admin_window(getname);
            this.Hide();
            admin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 F1 = new Form1();
            this.Close();
            F1.Show();
        }
    }
}
