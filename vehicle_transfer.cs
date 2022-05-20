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
    public partial class vehicle_transfer : Form
    {
        public vehicle_transfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string section = "";

            if (!rbadmindept.Checked && !rbhrdept.Checked && !rbtransdept.Checked && !rbtechnical.Checked)
            {
                MessageBox.Show("Please select the department");
            }
            else
            {
                if (rbhrdept.Checked)
                {
                    section = "HR";
                }
                else if (rbadmindept.Checked)
                {
                    section = "admin";
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
                string quary = "SELECT * FROM pool_vehicle WHERE vehicleno = '" + txtvehicleno.Text + "'";
                SqlCommand cmd = new SqlCommand(quary, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                try
                {
                    if (sdr.Read())
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                        string quary1 = "INSERT INTO vehicle_transfer(vehicleno,department) VALUES('" + txtvehicleno.Text + "','" + section + "')";
                        SqlCommand cmd1 = new SqlCommand(quary1, con1);
                        try
                        {
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Transfer details recorded");
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
                    else
                    {
                        MessageBox.Show("Vehicle is not registered.");
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
