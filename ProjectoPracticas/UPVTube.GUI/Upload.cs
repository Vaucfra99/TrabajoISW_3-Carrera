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
        //private Menu menuu;

        public Upload(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            //menuu = new Menu(service);
        }

        private void TextBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            tittle = TextBoxTitulo.Text;

        }

        private void TextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            description = TextBoxDescripcion.Text;
        }

        private void TextBoxURI_TextChanged(object sender, EventArgs e)
        {
            contentURI = TextBoxURI.Text;
        }

        private void CheckBoxPublico_CheckedChanged(object sender, EventArgs e)
        {
            if (isPublic == true) { isPublic = false; }
            else { isPublic = true; }
        }

        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            if (TextBoxTitulo.Text == string.Empty || TextBoxDescripcion.Text == string.Empty || TextBoxURI.Text == string.Empty)
            {
                DialogResult error = MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxTitulo.Clear();
                TextBoxDescripcion.Clear();
                TextBoxURI.Clear();
            }
            else
            {
            
                try
                {
                    service.Upload(tittle, description, contentURI, isPublic);
                    DialogResult subido = MessageBox.Show(this, "¡El contenido se ha subido correctamente!", "Contenido Subido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Upload_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
