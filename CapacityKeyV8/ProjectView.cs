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
    public partial class ProjectView : Form
    {
        SqlConnection connection;
        string connectionString;

        public ProjectView()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings[@"CapacityKeyV8.Properties.Settings.CKFSTdbConnectionString"].ConnectionString;

            PopulateProjects();


        }

        private void exitPVbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void ProjectView_Load(object sender, EventArgs e)
        {

            
        }

        private void PopulateProjects()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM project_table", connection))
            {

                DataTable projectTable = new DataTable();
                adapter.Fill(projectTable);
                
                for(int i = 0; i < projectTable.Rows.Count; i++)
                {

                    projectsViewListBox.Items.Add(projectTable.Rows[i]["projectID"]);
                    projectsViewListBox.Items.Add(projectTable.Rows[i]["projectName"]);
                }

                /*projectsViewListBox.DisplayMember = "System ID";
                projectsViewListBox.ValueMember = "sysprojId";
                projectsViewListBox.DisplayMember = "ProjectID";
                projectsViewListBox.ValueMember = "projectID";
                projectsViewListBox.DisplayMember = "Name";
                projectsViewListBox.ValueMember = "projectName";
                projectsViewListBox.DisplayMember = "Hours";
                projectsViewListBox.ValueMember = "projectHours";
                projectsViewListBox.DisplayMember = "Notes";
                projectsViewListBox.ValueMember = "projectNotes";
                projectsViewListBox.DataSource = projectTable;*/
            }
        }
    }
}
