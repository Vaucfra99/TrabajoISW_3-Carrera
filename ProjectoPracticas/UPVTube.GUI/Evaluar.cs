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
    public partial class Evaluar : Form
    {
        private IUPVTubeService service;
        private bool evaluacion;
        public Evaluar(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            ConfigurarListView();
            CargarDatosEnListView();
            Desactiva_Botones();
        }

        private void listaPendientes_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            int filas_seleccionadas = listaPendientes.SelectedItems.Count;
            if (filas_seleccionadas > 0)
            {
                Activa_Botones();
            }
            else 
            {
                Desactiva_Botones();
            }
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
            List<Content> contents = service.GetPendingContents();


            foreach (Content content in contents)
            {
                ListViewItem item = new ListViewItem(content.Id.ToString());
                item.SubItems.Add(content.Title);
                item.SubItems.Add(content.Owner.Nick);
                item.SubItems.Add(content.Description);
                item.SubItems.Add(content.ContentURI);
                item.SubItems.Add(string.Join(", ", content.Subjects.Select(s => s.Name)));
                item.SubItems.Add(content.UploadDate.ToString("dd-MM-yyyy"));
                item.SubItems.Add(content.Visualizations.Count.ToString());
                item.SubItems.Add(content.Comments.Count.ToString());

                listaPendientes.Items.Add(item);
            }
        }

  

        private void buttonAutorizar_Click(object sender, EventArgs e)
        {
            evaluacion = true;
            Desactiva_Botones();
            int id;
            int.TryParse(listaPendientes.SelectedItems[0].Text, out id);
            service.EvaluarContent(id, evaluacion, textBoxComentario.Text);
            listaPendientes.Items.Clear();
            CargarDatosEnListView();
        }

        private void buttonDenegar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxComentario.Text))
            {
                MessageBox.Show("No puedes dejar vacio el comentario");
                return;
            }
            evaluacion = false;
            Desactiva_Botones();
            int id;
            int.TryParse(listaPendientes.SelectedItems[0].Text, out id);
            service.EvaluarContent(id, evaluacion, textBoxComentario.Text);
            listaPendientes.Items.Clear();
            CargarDatosEnListView();
            textBoxComentario.Text = string.Empty;
        }

        private void Desactiva_Botones()
        {
            buttonAutorizar.Enabled = false;
            buttonDenegar.Enabled = false;
            textBoxComentario.Enabled = false;
        }

        private void Activa_Botones()
        {
            buttonAutorizar.Enabled = true;
            buttonDenegar.Enabled = true;
            textBoxComentario.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
