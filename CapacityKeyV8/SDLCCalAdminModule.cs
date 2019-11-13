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
    public partial class SDLCCalAdminModule : Form
    {
        public SDLCCalAdminModule()
        {
            InitializeComponent();
        }

        private void releaseExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
