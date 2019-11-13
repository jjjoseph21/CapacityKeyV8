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
    public partial class SDLCCalUserModule : Form
    {
        public SDLCCalUserModule()
        {
            InitializeComponent();
        }

        private void sdlcCalUExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
