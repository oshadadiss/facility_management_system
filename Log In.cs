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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUName.Text;
            password = txtPass.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
            string quary = "SELECT * FROM accounts WHERE username = '" +username+ "' AND password = '" +password+ "'";
            SqlCommand cmd = new SqlCommand(quary, con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            try
            {
                if (username == "" && password == "")
                {
                    MessageBox.Show("Please enter your Username and Password");
                }
                else if (sdr.Read())
                {
                    SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                    SqlConnection con3 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                    string quary2 = "SELECT * FROM accounts WHERE username = '" + username + "' AND post = 'admin'";
                    string quary3 = "SELECT * FROM accounts WHERE username = '" + username + "' AND post = 'SH'";
                    SqlCommand cmd2 = new SqlCommand(quary2, con2);
                    SqlCommand cmd3 = new SqlCommand(quary3, con3);
                    con2.Open();
                    con3.Open();
                    SqlDataReader sdr2 = cmd2.ExecuteReader();
                    SqlDataReader sdr3 = cmd3.ExecuteReader();

                    if (sdr2.Read())
                    {
                        admin_window admin = new admin_window(txtUName.Text);
                        this.Hide();
                        admin.Show();
                    }
                    else if (sdr3.Read())
                    {
                        SH_window SH = new SH_window(txtUName.Text);
                        this.Hide();
                        SH.Show();
                    }
                    else
                    {
                        app_window APP = new app_window(txtUName.Text);
                        this.Hide();
                        APP.Show();
                    }
                    con2.Close();
                    con3.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect Entry. Try again.");
                    txtUName.Text = "";
                    txtPass.Text = "";
                }
            }
            catch(SqlException e1)
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
