using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CapacityKeyV8
{
    public partial class ReleaseCycleModule : Form
    {

        SqlConnection connection;
        string connectionString;

        public ReleaseCycleModule()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings[@"CapacityKeyV8.Properties.Settings.CKFSTdbConnectionString"].ConnectionString;

            PopulateReleaseDates();
        }

        private void releaseExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewProjectsVRButton_Click(object sender, EventArgs e)
        {
            ProjectView pvpage = new ProjectView();
            pvpage.Show();
        }

        private void ReleaseCycleModule_Load(object sender, EventArgs e)
        {

        }

        private void PopulateReleaseDates()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM release_table Order by releaseDate", connection))
            {

                DataTable releaseTable = new DataTable();
                adapter.Fill(releaseTable);

                for (int i = 0; i < releaseTable.Rows.Count; i++)
                {
                    releaseVRPickerBox.Items.Add(releaseTable.Rows[i]["releaseDate"]);
                }
            }
        }
    }
}
