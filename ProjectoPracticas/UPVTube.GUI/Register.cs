using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTube.GUI
{
    public partial class Register : Form 
    {
        private IUPVTubeService service;
        private Menu menu;
        public Register(IUPVTubeService service) 
        {
            InitializeComponent();
            this.service = service;

        }


        /// <summary>
        /// Método para registrarse en la aplicación al pulsar en el botón correspondiente. En caso de que alguna caja de texto esté vacía mostrará un mensaje de error.
        /// En caso contrario, registrará el usuario en la aplicacion teniendo en cuenta los datos introducidos en las cajas de texto, vaciará las cajas de texto y mostrará
        /// el formulario Menu. En el caso en el que los datos introducidos no sean correctos se mostrará un mensaje de error y se vaciarán las cajas de texto
        /// </summary>
        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == string.Empty || TextBoxFullName.Text == string.Empty || TextBoxNick.Text == string.Empty || TextBoxPassword.Text == string.Empty)
            {
                MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    service.Register(TextBoxEmail.Text, TextBoxFullName.Text, TextBoxNick.Text, TextBoxPassword.Text);
                    menu = new Menu(service);
                    TextBoxEmail.Clear();
                    TextBoxFullName.Clear();
                    TextBoxNick.Clear();
                    TextBoxPassword.Clear();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        /// <summary>
        /// Método que vacia la cajas de texto
        /// </summary>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Clear();
            TextBoxFullName.Clear();
            TextBoxNick.Clear();
            TextBoxPassword.Clear();
        }


        /// <summary>
        /// Método que al cerrar el formulario vacíe las cajas de texto
        /// </summary>
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBoxEmail.Clear();
            TextBoxFullName.Clear();
            TextBoxNick.Clear();
            TextBoxPassword.Clear();
        }
    }
}
