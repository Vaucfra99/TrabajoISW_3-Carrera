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
    public partial class UPVTubeApp : Form
    {
        private IUPVTubeService service;
        private Login login;
        private Register register;
        public UPVTubeApp(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            login = new Login(service);
            register = new Register(service);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            register.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UPVTubeApp_Load(object sender, EventArgs e)
        {

        }
    }
}
