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

namespace CapacityKeyV8
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            //Create connection to database.
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GTLH5CB\SQLEXPRESS;Initial Catalog=CKFSTdb;Integrated Security=True");
            //Query databae for UserID and Password Provided by User.
            SqlCommand cmd = new SqlCommand("Select * from user_table where userid='" +userNameLogInBox.Text+ "' and userpassword='" +passwordLogInBox.Text + "'", con);
            //Retrieve and save data to datatable.
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //instantiate variable for usertype
            string cmbUTvalue = null;

            //Confirm usertype is selected
            try
            {
                //Store selected role from user to compare.
                cmbUTvalue = userTypeComboBox.SelectedItem.ToString();
            }
            catch (Exception)
            {
                //Show system message if user fails to select from
                MessageBox.Show("Please Select User Type","User Type Not Specified", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            //Confirm userid and password
            try
            {
                //Cycle through data to find matches
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["usertype"].ToString() == cmbUTvalue)
                        {
                            //Find a match and confirm login success
                            MessageBox.Show("You are logged in as " + dt.Rows[i][2], "Log In Successful");
                            //Send admin user to Admin Module
                            if (userTypeComboBox.SelectedIndex == 0)
                            {
                                AdminModule ampage = new AdminModule();
                                ampage.Show();
                                this.Hide();
                            }
                            // Send regular user to User Module
                            else
                            {
                                UserModule umpage = new UserModule();
                                umpage.Show();
                                this.Hide();
                            }

                        }
                        //advise user the user type is a mismatch
                        else
                        {
                            MessageBox.Show("Incorrect User Type", "Login MisMatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                //Advise user that login data is incorrect
                else
                {
                    MessageBox.Show("Incorrect Username or Password.", "Login MisMatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //Show system message if failure occurs
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Something is amiss", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void logInExitButton_Click(object sender, EventArgs e)
        {
            //Exit program
            Application.Exit();
        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }
    }
}
