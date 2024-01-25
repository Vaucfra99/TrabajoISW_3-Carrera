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
using UPVTube.Services;

namespace UPVTube.GUI
{
    public partial class Menu : Form
    {
        private IUPVTubeService service;
        private Upload upload;
        private Searcher search;
        //private UPVTubeApp upvtubeapp;
        
        public Menu(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            service.DBInitialization();//siempre que se ejecute, se resetea la base de datos.
            upload = new Upload(service);
            search = new Searcher(service);
            //upvtubeapp = new UPVTubeApp(service);
            // El Menu debería mostrar si es un teacher el buscar pendientes de evaluar
            // Si es un externo sólo debe mostrar el buscar
            // To Do Alumnos -----------------------------------
        }
        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            //this.Hide();
            upload.ShowDialog();
            //this.Close();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            search.ShowDialog();
            //this.Close();

        }
        
        // To Do Alumnos -------------------------------
        // Hay que enlazar en todos los formularios el evento Click
        // del botón volver a su función correspondiente
        // Esto se hace en el diseñador del formulario seleccionando 
        // el botón, yendo a la ventana de Propiedades -> Icono del rayo
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //upvtubeapp.ShowDialog();
            this.Close();
        }
    }
}
