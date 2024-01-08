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
    public partial class Register : Form //UPVTubeFormbase (tiene que heredar de esta)
    {
        private IUPVTubeService service;
        private String nick;
        private String password;
        private String fullname;
        private String email;
        public Register(IUPVTubeService service) //:base (service) 
        {
            InitializeComponent();
            this.service = service;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxNick_TextChanged(object sender, EventArgs e)
        {
            nick = TextBoxNick.Text;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = TextBoxPassword.Text;
        }

        private void TextBoxFullName_TextChanged(object sender, EventArgs e)
        {
            fullname = TextBoxFullName.Text;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            email = TextBoxEmail.Text;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text == string.Empty || TextBoxFullName.Text == string.Empty || TextBoxNick.Text == string.Empty || TextBoxPassword.Text == string.Empty) 
            {
                DialogResult error = MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxEmail.Clear();
                TextBoxFullName.Clear();
                TextBoxNick.Clear();
                TextBoxPassword.Clear();
            }
            else {
                comprobarDominio();
                try
                {

                    service.Register(email, fullname, nick, password);
                }catch (ServiceException ex) {
                    DialogResult answer = MessageBox.Show(this, // Owner
                    ex.Message, // Message
                    "Error de Servicio", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Exclamation); // Icon
                   
                }

                }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxEmail.Clear();
            TextBoxFullName.Clear();
            TextBoxNick.Clear();
            TextBoxPassword.Clear();
        }

        public void comprobarDominio(){
            if (email.Contains("@alumno.upv.es"))
            {
                /* es student*/
            }
            else if (email.Contains("@profesor"))
            {
                /*es profesor*/
            }
        }
    }
}
