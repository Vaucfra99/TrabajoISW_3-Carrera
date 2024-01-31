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
        private Watcher watcher;
        private Content content;
        public Comentar(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
        }


       

        private void Comentar_Load(object sender, EventArgs e)
        {
           buttonComentar.Enabled = true;
        }

        private void Comentar_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBoxComentar.Clear();
        }

        private void textBoxComentar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonComentar_Click(object sender, EventArgs e)
        {
            if (textBoxComentar.Text == string.Empty)
            {

                MessageBox.Show(this, "Debes escribir un comentario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else {


                Member autor = service.ReturnLoggedMember();
                Comment creado = new Comment(textBoxComentar.Text, DateTime.Now, content , autor);
                service.CrearComentario(creado);

             
                MessageBox.Show(this, "Tu comentario ha sido enviado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxComentar.Clear();


            }

        }
    }
}
