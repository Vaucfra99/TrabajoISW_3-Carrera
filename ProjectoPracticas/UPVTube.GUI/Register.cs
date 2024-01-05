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
    public partial class Register : Form
    {
        private IUPVTubeService service;
        public Register(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
