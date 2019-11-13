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
    public partial class AdminModule : Form
    {
        SqlConnection connection;
        string connectionString;

        public AdminModule()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings[@"CapacityKeyV8.Properties.Settings.CKFSTdbConnectionString"].ConnectionString;

            PopulateReleaseDates();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void releaseCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseCycleModule rcpage = new ReleaseCycleModule();
            rcpage.Show();
        }

        private void sDLCCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SDLCCalAdminModule sdlcampage = new SDLCCalAdminModule();
            sdlcampage.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTeamModule mtmpage = new ManageTeamModule();
            mtmpage.Show();
        }

        private void AdminModule_Load(object sender, EventArgs e)
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
                    releasePickerDDBox.Items.Add(releaseTable.Rows[i]["releaseDate"]);
                }
            }
        }
    }
}
