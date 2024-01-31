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
                MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
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

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBoxEmail.Clear();
            TextBoxFullName.Clear();
            TextBoxNick.Clear();
            TextBoxPassword.Clear();
        }
    }
}
