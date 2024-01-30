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
        public Menu(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            upload = new Upload(service);
            search = new Searcher(service);
            evaluar = new Evaluar(service);
        }
        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            upload.ShowDialog();
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            search.ShowDialog();

        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            service.LogOut();
            this.Close();
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            evaluar.ShowDialog();
        }

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
    }
}
