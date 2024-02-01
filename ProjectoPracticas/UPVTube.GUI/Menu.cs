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
        private Subscripciones subscripciones;
        private Member member;
        public Menu(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            upload = new Upload(service);
            search = new Searcher(service);
            evaluar = new Evaluar(service);
            subscripciones = new Subscripciones(service);
        }


        /// <summary>
        /// Método que mostrará el formulario Upload cuando se presione el botón correspondiente
        /// </summary>
        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            upload.ShowDialog();
        }


        /// <summary>
        /// Método que mostrará el formulario Search cuando se presione el botón correspondiente
        /// </summary>
        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            search.ShowDialog();

        }


        /// <summary>
        /// Método que mostrará el formulario Evaluar cuando se presione el botón correspondiente
        /// </summary>
        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            evaluar.ShowDialog();
        }


        /// <summary>
        /// Método que mostrará el formulario Subscripciones cuando se presione el botón correspondiente
        /// </summary>
        private void buttonSubscription_Click(object sender, EventArgs e)
        {
            subscripciones.ShowDialog();
        }


        /// <summary>
        /// Método que activará los botones correspondientes dependiendo de si eres un usuario externo, un alumno o un profesor
        /// </summary>
        private void Menu_Load(object sender, EventArgs e)
        {
            member = service.ReturnLoggedMember();
            ButtonEvaluate.Enabled = false;
            ButtonSubir.Enabled = false;
            if (member.IsTeacher())
            {
                ButtonEvaluate.Enabled = true;
                ButtonSubir.Enabled = true;
            }
            if (member.IsStudent())
            {
                ButtonSubir.Enabled = true;
            }
        }


        /// <summary>
        /// Método que al cerrar el formulario cierre sesión
        /// </summary>
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            service.LogOut();
        }

    }
}
