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
    public partial class Register : Form //UPVTubeFormbase (tiene que heredar de esta)
    {
        private IUPVTubeService service;
        private Menu menu;
        public Register(IUPVTubeService service) //:base (service) 
        {
            InitializeComponent();
            this.service = service;
            
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
                catch (ServiceException ex) {
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

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
