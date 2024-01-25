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
    public partial class Rechazo : Form
    {
        private IUPVTubeService service;
        //private Evaluar eevaluar;
        private int id;
        private string email;
        public Rechazo(IUPVTubeService service, int id, string email)
        {
            InitializeComponent();
            this.service = service;
            //eevaluar = new Evaluar(service);

        }

        private void BotonEv_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //eevaluar.ShowDialog();
            this.Close();
        }

        private void BotonEmail_Click(object sender, EventArgs e)
        {
            DialogResult noPermitido = MessageBox.Show(this, "Email : " + email + "\n" + "Asunto : Rechazo Contenido \n Mensaje: " + TextBoxMotivo.Text, "Contenido No Autorizado Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            service.EvaluarContent(id, false, TextBoxMotivo.Text);
            //this.Hide();
            //eevaluar.ShowDialog();
            this.Close();
        }
    }
}
