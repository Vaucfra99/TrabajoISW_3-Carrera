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
        private Login login;
        private UPVTubeApp upvtubeapp;
        
        public Menu(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            service.DBInitialization();//siempre que se ejecute, se resetea la base de datos.
            upload = new Upload(service);
            search = new Searcher(service);
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSubir_Click(object sender, EventArgs e)
        {
            this.Hide();
            upload.ShowDialog();
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            search.ShowDialog();
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            upvtubeapp.ShowDialog();
            this.Close();
        }
    }
}
