using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapacityKeyV8
{
    public partial class UserModule : Form
    {
        public UserModule()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sDLCCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SDLCCalUserModule sdlccumpage = new SDLCCalUserModule();
            sdlccumpage.Show();
        }
    }
}
