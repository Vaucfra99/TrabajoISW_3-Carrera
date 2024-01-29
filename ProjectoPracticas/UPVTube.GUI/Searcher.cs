using System;
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
        private Watcher view;
        private int WatchId;
        private string acceso;
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            // Eliminado Watcher porque WatchId no tiene valor aquí 
            // y genera excepción en constructor
            //view = new Watcher(service, WatchId);
            GridContents.Visible = false;
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            GridContents.Visible = true;
            try
            {
                IEnumerable<Content> cList = service.Search(textBoxTitle.Text, textBoxUplNick.Text, textBoxSubject.Text, dateTimePickerEarly.Value, dateTimePickerLate.Value);
                foreach (Content c in cList)
                {
                    acceso = "prueba";
                    GridContents.Rows.Add(c.Title, c.Owner, c.Description, acceso, c.UploadDate, c.Subjects);
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

            //                cList = cList.OrderBy(c => c.UploadDate);
            //                if (c.IsPublic) { acceso = "Público"; }
            //                else { acceso = "Privado"; }
        }




        private void Searcher_Load(object sender, EventArgs e)
        {

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
