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
    public partial class pool_vehicle : Form
    {
        public pool_vehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fuel = "", type = "", section = "";

            if (txtvehicleno.Text == "")
            {
                MessageBox.Show("Please enter vehicle number");
            }
            else if (!rbpetrol.Checked && !rbdiesel.Checked && !rbelectric.Checked)
            {
                MessageBox.Show("Please select Fuel Type");
            }
            else if (!rbadmindept.Checked && !rbhrdept.Checked && !rbtransdept.Checked && !rbtechnical.Checked)
            {
                MessageBox.Show("Please select the department");
            }
            else
            {
                if (rbpetrol.Checked)
                {
                    fuel = "petrol";
                }
                else if (rbdiesel.Checked)
                {
                    fuel = "diesel";
                }
                else if (rbelectric.Checked)
                {
                    fuel = "electric";
                }

                if (rbcar.Checked)
                {
                    type = "car";
                }
                else if (rbvan.Checked)
                {
                    type = "van";
                }

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
                        MessageBox.Show("This vehicle is already registered");
                    }
                    else
                    {
                        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\C#Assignment\facility_management_system.mdf;Integrated Security=True;Connect Timeout=30");
                        string quary1 = "INSERT INTO pool_vehicle(vehicleno,vehicletype,fuel,department) VALUES('" + txtvehicleno.Text + "','" + type + "','" + fuel + "','" + section + "')";
                        SqlCommand cmd1 = new SqlCommand(quary1, con1);
                        try
                        {
                            con1.Open();
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Vehicle Added");
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
    }
}
