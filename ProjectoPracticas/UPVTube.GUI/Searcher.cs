﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;


namespace UPVTube.GUI
{
    public partial class Searcher : Form
    {
        private IUPVTubeService service;
        private Watcher watcher;
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void CargarDatosEnGridView()
        {
            try
            {
                String selectedMember = ((Member) comboBoxMember.SelectedItem).Nick;
                if (selectedMember.Equals("     ")) { selectedMember = null; }
                Subject selectedSubject = (Subject) comboBoxSubject.SelectedItem;
                if (selectedSubject.Code == 0000) { selectedSubject = null; }

                IEnumerable<Content> cList = service.Search(textBoxTitle.Text, selectedMember, selectedSubject, dateTimePickerEarly.Value.Date, dateTimePickerLate.Value.Date);
                foreach (Content c in cList)
                {
                    ///Duda para la tutoria no sabemos como añadir los contenidos en el gridview y no sabemos porque no va. Parece que es problema del codigo
                    String sub = "";
                    foreach (Subject s in c.Subjects)
                    {
                        sub += s.Name + ", ";
                    }
                    String acceso = "Privado";
                    if (c.IsPublic) { acceso = "Público"; }
                    GridContents.Rows.Add(c.Title, c.Owner.Nick, c.Description, acceso, c.UploadDate, sub, c.UploadDate.ToShortDateString(), c.Id);
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


        private void Searcher_Load(object sender, EventArgs e)
        {

            GridContents.Enabled = false;

            List<Subject> subjects = new List<Subject>(service.getSubjects());
            Subject noSubject = new Subject(00000, "xxxxx", "     ");
            subjects.Add(noSubject);
            comboBoxSubject.DataSource = subjects;
            comboBoxSubject.SelectedItem = noSubject;
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.ValueMember = "Code";


            IList<Member> members = new List<Member>(service.getMembers());
            Member noMember = new Member("xxx@xxx.xxx", "     ", DateTime.Now, "     ", "0000");
            members.Add(noMember);
            comboBoxMember.DataSource = members;
            comboBoxMember.SelectedItem = noMember;
            comboBoxMember.DisplayMember = "Nick";
            comboBoxMember.ValueMember = "Nick";
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            GridContents.Rows.Clear();
            this.Close();
        }

        private void buttonVerCont_Click(object sender, EventArgs e)
        {
            if (GridContents.Enabled == true && GridContents.SelectedRows.Count == 1)
            {
                int id = (int)GridContents.SelectedRows[0].Cells[6].Value;
                Content c = service.getContent(id);
                watcher = new Watcher(service, c);
                watcher.ShowDialog();
            }
            else
            {
                DialogResult error = MessageBox.Show(this, "Selecciona un contenido", "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GridContents.Enabled = true;
            CargarDatosEnGridView();
        }
    }
}
