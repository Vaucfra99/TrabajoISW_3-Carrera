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
            service.DBInitialization();//siempre que se ejecute, se resetea la base de datos.
            login = new Login(service);
            register = new Register(service);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.ShowDialog();
            this.Close();
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
