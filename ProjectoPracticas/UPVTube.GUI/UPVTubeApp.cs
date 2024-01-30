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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            register.ShowDialog();
        }

        private void buttonBD_Click(object sender, EventArgs e)
        {
            service.DBInitialization();
        }

        private void UPVTubeApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
