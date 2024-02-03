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
        private Boolean check = false;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;

        }
        /// <summary>
        /// Método que carga los datos en la tabla y muestra un mensaje de error en caso de que ocurra alguno
        /// </summary>
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
                    GridPending.Sort(GridPending.Columns[4], ListSortDirection.Ascending);
                    check = true;
                }

            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Método que rechaza un contenido al pulsar el botón correspondiente, actualiza los datos correspondientes y muestra un mensaje de error en caso 
        /// de que ocurra uno 
        /// </summary>
        private void BotonPer_Click(object sender, EventArgs e)
        {
            if (GridPending.SelectedRows == null)
            {
                MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = (int)GridPending.SelectedRows[0].Cells[6].Value;
                    Content c = service.Watch(id);
                    c.Authorized = Authorized.Yes;
                    Evaluation ev = new Evaluation(DateTime.Now, textBoxMotivo.Text, service.ReturnLoggedMember(), c);
                    service.EvaluarContent(ev, Authorized.Yes);

                    String msgEmail = "Email: " + c.Owner.Email + "\n" + "Asunto: Evaluación del contenido: " + c.Title + "\n" + 
                        "Valoración: Aprobado\n" + "Información adicional: " + textBoxMotivo.Text;
                    MessageBox.Show(this, msgEmail, "Contenido Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GridPending.Rows.RemoveAt(GridPending.SelectedRows[0].Index);
                    textBoxMotivo.Clear();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método que rechaza un contenido al pulsar el botón correspondiente, actualiza los datos correspondientes y muestra un mensaje de error en caso 
        /// de que ocurra uno o en caso de que no se haya escrito una razón de rechazo
        /// </summary>
        private void BotonRec_Click(object sender, EventArgs e)
        {
            if (GridPending.SelectedRows == null)
            {
                MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = (int)GridPending.SelectedRows[0].Cells[6].Value;
                    Content c = service.Watch(id);
                    c.Authorized = Authorized.No;

                    Evaluation ev = new Evaluation(DateTime.Now, textBoxMotivo.Text, service.ReturnLoggedMember(), c);
                    service.EvaluarContent(ev, Authorized.No);

                    String msgEmail = "Email: " + c.Owner.Email + "\n" + "Asunto: Evaluación del contenido: " + c.Title + "\n" 
                        + "Valoración: Rechazado\n" + "Motivo: " + textBoxMotivo.Text;
                    MessageBox.Show(this, msgEmail, "Contenido Rechazado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPending.Rows.RemoveAt(GridPending.SelectedRows[0].Index);
                    textBoxMotivo.Clear();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Método que al abrir el formulario carga los datos en la tabla, y si antes ya ha generado la tabla la vacia previamente a volver a generarla
        /// </summary>
        private void Evaluar_Load(object sender, EventArgs e)
        {
            if (check)
            {
                GridPending.Rows.Clear();
            }
            CargarDatosEnGridView();
        }

        /// <summary>
        /// Método que muestra un contenido al pulsar el botón correspondiente siempre que hayas seleccionado uno
        /// </summary>
        private void buttonVerCont_Click(object sender, EventArgs e)
        {
            if (GridPending.Enabled == true && GridPending.SelectedRows != null)
            {
                int id = (int)GridPending.SelectedRows[0].Cells[6].Value;
                Content c = service.Watch(id);
                watcher = new Watcher(service, c);
                watcher.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        /// <summary>
        /// Método que al cerrar el formulario vacía la tabla, la recarga y la desabilita
        /// </summary>
        private void Evaluar_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridPending.Rows.Clear();
            GridPending.Refresh();
            GridPending.Enabled = false;
        }
    }

}

