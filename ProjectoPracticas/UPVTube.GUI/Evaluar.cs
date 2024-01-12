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
    public partial class Evaluar : Form
    {
        private IUPVTubeService service;
        private bool evaluacion;
        private Menu meenu;
        private Rechazo rechazo;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            botonPer.Enabled = false;
            botonRec.Enabled = false;
            meenu = new Menu(service);
            rechazo = new Rechazo(service);
            CargarDatosEnListView();
        }

        private void CargarDatosEnListView()
        {
            try
            {
                List<Content> cList = service.GetPendingContents();
                foreach (Content c in cList)
                { 

                    listaPendientes.Items.Add(c);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            meenu.ShowDialog();
            this.Close();
        }
        private void listaPendientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Content c1 = (Content)listaPendientes.SelectedItem;
            botonPer.Enabled = true; 
            botonPer.Enabled = true;
        }

        private void botonPer_Click(object sender, EventArgs e)
        {
            DialogResult permitido = MessageBox.Show(this, "¡El contenido ha sido autorizado correctamente!", "Contenido Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            service.EvaluarContent(c.id, true, null);
        }

        private void botonRec_Click(object sender, EventArgs e)
        {
            this.Hide();
            rechazo.ShowDialog();
            this.Close();
        }

        private void Evaluar_Load(object sender, EventArgs e)
        {

        }
    }

}

