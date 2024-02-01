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
using UPVTube.Entities;
using UPVTube.GUI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UPVTube.GUI
{
    public partial class Login : Form
    {
        private IUPVTubeService service;
        private String nick;
        private String password;
        private Menu menu;
        public Login(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }


        /// <summary>
        /// Método para iniciar sesión en la aplicación al pulsar en el botón correspondiente. En caso de que alguna caja de texto esté vacía mostrará un mensaje de error.
        /// En caso contrario, iniciará sesión en la aplicacion teniendo en cuenta los datos introducidos en las cajas de texto, vaciará las cajas de texto y mostrará
        /// el formulario Menu. En el caso en el que los datos introducidos no sean correctos se mostrará un mensaje de error y se vaciarán las cajas de texto
        /// </summary>

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == string.Empty || TextBoxUser.Text == string.Empty)
            {
                MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    service.LogIn(TextBoxUser.Text, TextBoxPassword.Text);
                    TextBoxPassword.Clear();
                    TextBoxUser.Clear();
                    menu = new Menu(service);
                    menu.ShowDialog();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextBoxUser.Clear();
                    TextBoxPassword.Clear();
                }
            }
        }


        /// <summary>
        /// Método para que se vacíen las cajas de texto al pulsar el botón correspondiente
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Clear();
            TextBoxUser.Clear();
        }
        
        
        /// <summary>
        /// Método para que al cerrar se vacíen las cajas de texto
        /// </summary>
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBoxPassword.Clear();
            TextBoxUser.Clear();
        }
    }
}
