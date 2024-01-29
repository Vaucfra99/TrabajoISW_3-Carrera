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
        private Member member;
        public Login(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            
        }


        private void TextBoxUser_TextChanged(object sender, EventArgs e)
        {
            nick = TextBoxUser.Text;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            password = TextBoxPassword.Text;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(TextBoxPassword.Text == string.Empty || TextBoxUser.Text == string.Empty) {
                DialogResult error = MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxUser.Clear();
                TextBoxPassword.Clear();
            }
            else
            {
                try
                {
                    service.LogIn(nick, password);
                    this.Hide();
                    member = service.ReturnLoggedMember();
                    menu = new Menu(service, member);
                    menu.ShowDialog();
                    this.Close();

                }
                catch (ServiceException ex)
                {
                    DialogResult answer = MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TextBoxUser.Clear();
                    TextBoxPassword.Clear();
                }
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Clear();
            TextBoxUser.Clear();
        }

       private void BtnReturn_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
