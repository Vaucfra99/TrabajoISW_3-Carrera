using Microsoft.Win32;
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
    public partial class Menu : Form
    {
        private IUPVTubeService service;
        private Upload upload;
        private Searcher search;
        private Evaluar evaluar;
        private Member member;
        public Menu(IUPVTubeService service,  Member member)
        {
            InitializeComponent();
            this.service = service;
            this.member = member;
            service.DBInitialization();//siempre que se ejecute, se resetea la base de datos.
            upload = new Upload(service);
            search = new Searcher(service);
            evaluar = new Evaluar(service);
            // El Menu debería mostrar si es un teacher el buscar pendientes de evaluar
            // Si es un externo sólo debe mostrar el buscar
            // To Do Alumnos -----------------------------------
        }
        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            upload.ShowDialog();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            search.ShowDialog();

        }
        
        // To Do Alumnos -------------------------------
        // Hay que enlazar en todos los formularios el evento Click
        // del botón volver a su función correspondiente
        // Esto se hace en el diseñador del formulario seleccionando 
        // el botón, yendo a la ventana de Propiedades -> Icono del rayo
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            evaluar.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            buttonEvaluate.Enabled = false;  
            ButtonSubir.Enabled = false;
            if (member.IsTeacher())
            {
                buttonEvaluate.Enabled = true;
                ButtonSubir.Enabled = true;
            }
            if (member.IsStudent())
            {
                ButtonSubir.Enabled = true;
            }
        }
    }
}
