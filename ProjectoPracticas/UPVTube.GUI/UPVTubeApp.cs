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

        /// <summary>
        /// Método para abrir el formulario Loginal pulsar el botón correspondiente
        /// </summary>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        /// <summary>
        /// Método para abrir el formulario Register al pulsar el botón correspondiente
        /// </summary>
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            register.ShowDialog();
        }
        
        /// <summary>
        ///  Método para reiniciar la Base de Datos al pulsar el botón correspondiente
        /// </summary>
        private void buttonBD_Click(object sender, EventArgs e)
        {
            service.DBInitialization();
        }

        /// <summary>
        /// Método que al cerrar el formulario detendrá la aplicación
        /// </summary>
        private void UPVTubeApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
