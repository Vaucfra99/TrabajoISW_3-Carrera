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
using UPVTube.Persistence;
using UPVTube.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTube.GUI
{
    public partial class Evaluar : Form
    {
        private IUPVTubeService service;
        private Watcher watcher;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            
        }

        private void CargarDatosEnGridView()
        {
            try
            {
                IEnumerable<Content> cList = service.GetPendingContents();
                foreach (Content c in cList)
                {
                    String sub = "";
                    foreach (Subject s in c.Subjects)
                    {
                        sub += s.Name + ", "; 
                    }
                    String acceso = "Privado";
                    if (c.IsPublic) { acceso = "Público"; }
                    GridPending.Rows.Add(c.Title, c.Owner.Nick, c.Description, acceso, c.UploadDate.ToShortDateString(), sub, c.Id);
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

        private void BotonPer_Click(object sender, EventArgs e)
        {
            if (GridPending.SelectedRows == null)
            {
                DialogResult error = MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = (int)GridPending.SelectedRows[0].Cells[6].Value;
                    Content c = service.getContent(id);
                    //Dudita
                    c.Authorized = Authorized.Yes;
                    Evaluation ev = new Evaluation(DateTime.Now, textBoxMotivo.Text, service.ReturnLoggedMember(), c);
                    service.EvaluarContent(ev, Authorized.Yes);
                    
                    String msgEmail = "Email: " + c.Owner.Email + "\n" + "Asunto: Evaluación del contenido: " + c.Title + "\n" + "Valoración: Aprobado\n" + "Información adicional: " + textBoxMotivo.Text;
                    DialogResult per = MessageBox.Show(this, msgEmail, "Contenido Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPending.Rows.RemoveAt(GridPending.SelectedRows[0].Index);
                    textBoxMotivo.Clear();
                }
                catch (ServiceException ex)
                {
                    DialogResult error = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BotonRec_Click(object sender, EventArgs e)
        {
            if (GridPending.SelectedRows == null)
            {
                DialogResult error = MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = (int) GridPending.SelectedRows[0].Cells[6].Value;
                    Content c = service.getContent(id);
                    //Dudita v2
                    c.Authorized = Authorized.No;
                  
                    Evaluation ev = new Evaluation(DateTime.Now, textBoxMotivo.Text, service.ReturnLoggedMember(), c);
                    service.EvaluarContent(ev, Authorized.No);

                    String msgEmail = "Email: " + c.Owner.Email + "\n" + "Asunto: Evaluación del contenido: " + c.Title + "\n" + "Valoración: Rechazado\n" + "Motivo: " + textBoxMotivo.Text;
                    DialogResult per = MessageBox.Show(this, msgEmail, "Contenido Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPending.Rows.RemoveAt(GridPending.SelectedRows[0].Index);
                    textBoxMotivo.Clear();
                }
                catch (ServiceException ex)
                {
                    DialogResult error = MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            GridPending.Rows.Clear();
            this.Close();
        }

        private void buttonShowPending_Click(object sender, EventArgs e)
        {
            GridPending.Enabled = true;
            CargarDatosEnGridView();
            buttonShowPending.Enabled = false;
        }

        private void Evaluar_Load(object sender, EventArgs e)
        {
            GridPending.Enabled = false;
            buttonShowPending.Enabled = true;
        }

        private void buttonVerCont_Click(object sender, EventArgs e)
        {
            if (GridPending.Enabled == true && GridPending.SelectedRows.Count == 1)
            {
                int id = (int)GridPending.SelectedRows[0].Cells[6].Value;
                Content c = service.getContent(id);
                watcher = new Watcher(service, c);
                watcher.ShowDialog();
            }
            else
            {
                DialogResult error = MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }

}

