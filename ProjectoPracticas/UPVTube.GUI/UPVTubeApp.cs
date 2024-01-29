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
            //this.Hide();
            login.ShowDialog();
            //this.Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //this.Hide();
            register.ShowDialog();
            //this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UPVTubeApp_Load(object sender, EventArgs e)
        {

        }

        private void buttonBD_Click(object sender, EventArgs e)
        {
            service.DBInitialization();
        }
    }
}
