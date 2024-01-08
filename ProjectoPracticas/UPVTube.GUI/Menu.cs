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
    public partial class Menu : Form
    {
        private IUPVTubeService service;
        public Menu(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
