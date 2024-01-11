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
        private Evaluacion evaluacion;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            meenu = new Menu(service);
            evaluacion = new Evaluar.evaluacion(service);
            ConfigurarListView();
            CargarDatosEnListView();
        }


        private void ConfigurarListView()
        {
            listaPendientes.View = View.Details;
            listaPendientes.Columns.Add("ID", -2);
            listaPendientes.Columns.Add("Título", -2);
            listaPendientes.Columns.Add("Creador", -2);
            listaPendientes.Columns.Add("Descripción", 300);
            listaPendientes.Columns.Add("URI", 300);
            listaPendientes.Columns.Add("Asignaturas", -2);
            listaPendientes.Columns.Add("Fecha de Subida", -2);
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

        private void listaPendientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Content c1 = (Content)listaPendientes.SelectedItem;

            this.Hide();
            evaluacion.ShowDialog();
            this.Close();
        }
    }

}

