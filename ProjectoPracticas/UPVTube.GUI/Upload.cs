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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UPVTube.GUI
{
    public partial class Upload : Form
    {
        private IUPVTubeService service;
        private String tittle;
        private String description;
        private String contentURI;
        private Boolean isPublic = false;
        
        public Upload(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Upload_Load(object sender, EventArgs e)
        {
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            tittle = textBoxTitulo.Text;

        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            description = textBoxDescripcion.Text;
        }

        private void textBoxURI_TextChanged(object sender, EventArgs e)
        {
            contentURI = textBoxURI.Text;
        }

        private void checkBoxPublico_CheckedChanged(object sender, EventArgs e)
        {
            if (isPublic == true) { isPublic = false; }
            else { isPublic = true; }
        }

        private void buttonSubir_Click(object sender, EventArgs e)
        {
            if (textBoxTitulo.Text == string.Empty || textBoxDescripcion.Text == string.Empty || textBoxURI.Text == string.Empty)
            {
                DialogResult error = MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitulo.Clear();
                textBoxDescripcion.Clear();
                textBoxURI.Clear();
            }
            else
            {
            
                try
                {
                    service.Upload(tittle, description, contentURI, isPublic);
                }
                catch (ServiceException ex)
                {
                    DialogResult answer = MessageBox.Show(this, // Owner
                    ex.Message, // Message
                    "Error de Servicio", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Exclamation); // Icon
                }

            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {

        }
    }
}
