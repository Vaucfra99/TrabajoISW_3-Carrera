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

namespace UPVTube.GUI
{
    public partial class Login : Form
    {
        private IUPVTubeService service;
        private String nick;
        private String password;
        public Login(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            TextBoxUser.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

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
            else { service.LogIn(nick, password); }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TextBoxPassword.Clear();
            TextBoxUser.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
