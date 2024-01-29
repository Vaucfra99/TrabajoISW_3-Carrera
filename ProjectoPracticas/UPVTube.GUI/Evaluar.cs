using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTube.GUI
{
    public partial class Evaluar : Form
    {
        private IUPVTubeService service;
        private bool evaluacion;
        //private Menu meenu;
        private Rechazo rechazo;
        private int EvId;
        private string EvEmail;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            BotonPer.Enabled = false;
            BotonRec.Enabled = false;
            //meenu = new Menu(service);
            rechazo = new Rechazo(service, EvId, EvEmail);
            
        }

        private void CargarDatosEnListView()
        {
            try
            {
                List<Content> cList = service.GetPendingContents();
                foreach (Content c in cList)
                {
                    ListaPendientes.Items.Add(c);
                }

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

        private void ListaPendientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Content c1 = (Content)ListaPendientes.SelectedItem;
            int id = c1.Id;
            BotonPer.Enabled = true; 
            BotonPer.Enabled = true;
        }

        private void BotonPer_Click(object sender, EventArgs e)
        {
            DialogResult permitido = MessageBox.Show(this, "¡El contenido ha sido autorizado correctamente!", "Contenido Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Content c1 = (Content)ListaPendientes.SelectedItem;
            int id = c1.Id;
            service.EvaluarContent(id, true, null);
        }

        private void BotonRec_Click(object sender, EventArgs e)
        {
            Content c1 = (Content)ListaPendientes.SelectedItem;
            EvId = c1.Id;
            EvEmail = c1.Owner.Email;
            //this.Hide();
            rechazo.ShowDialog();
            //this.Close();
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            CargarDatosEnListView();
        }
    }

}

