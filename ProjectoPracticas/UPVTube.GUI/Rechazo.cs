using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Services;

namespace UPVTube.GUI
{
    public partial class Rechazo : Form
    {
        public Rechazo(IUPVTubeService service)
        {
            InitializeComponent();
        }

        private void Rechazo_Load(object sender, EventArgs e)
        {

        }
    }
}
