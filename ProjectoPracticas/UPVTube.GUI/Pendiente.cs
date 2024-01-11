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
using UPVTube.Entities;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace UPVTube.GUI
{
    public partial class Pendiente : Form
    {
        private IUPVTubeService service;
        public Pendiente(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            this.Load += Pendiente_Load;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
   
        private void Pendiente_Load(object sender, EventArgs e)
        {
            //Establecer las dimensiones de las ventanas horizontales grandes
            this.Size = new Size(805, 500);

            //Deshabilitar el control rectanguloFondo porque al ser un textbox si lo apretabas se podia seleccionar
            //rectanguloFondo.Enabled = false;

            //Ventana para que no sea redimensionable
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //dataGridView1.CellClick += DataGridView1_CellClick;

            //List<Content> contentList = UPVservice.EvaluateContent();
            //dataGridView1.DataSource = contentList;

            //Ajusta las columnas según el contenido
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //ocultar de la tabla
            dataGridView1.Columns["Authorized"].Visible = false;
            dataGridView1.Columns["Owner"].Visible = false;

            dataGridView1.Columns["Id"].HeaderText = "Uploaded By";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                //Obtener el contenido seleccionado
                Content selectedContent = (Content)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                //Abrir la ventana VerContenido con el contenido seleccionado
                Evaluar evaluationDetails =  new Evaluar(service, selectedContent);
                evaluationDetails.show();
                this.Close();
            }
        }
    }
}
