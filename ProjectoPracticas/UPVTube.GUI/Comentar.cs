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

namespace UPVTube.GUI
{
    public partial class Comentar : Form
    {
        private IUPVTubeService service;
        private Content content;
        public Comentar(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
        }

        /// <summary>
        /// Método que vacia la caja de tecto de comentar al cerrarel formulario
        /// </summary>
        private void Comentar_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBoxComentar.Clear();
        }

        /// <summary>
        /// Método que al pulsar el botón guarda el comentario escrito en la caja de texto y muestra un mensaje de confirmación. En caso de error muestra
        /// un mensaje de error
        /// </summary>
        private void buttonComentar_Click(object sender, EventArgs e)
        {
            if (textBoxComentar.Text == string.Empty)
            {
                MessageBox.Show(this, "Debes escribir un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                Member autor = service.ReturnLoggedMember();
                Comment creado = new Comment(textBoxComentar.Text, DateTime.Now, content, autor);
                service.CrearComentario(creado);

                MessageBox.Show(this, "Tu comentario ha sido enviado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxComentar.Clear();
            }
        }
    }
}
