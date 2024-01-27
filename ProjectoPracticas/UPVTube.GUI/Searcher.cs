using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;


namespace UPVTube.GUI
{
    public partial class Searcher : Form
    {
        private IUPVTubeService service;
        private Watcher view;
        //private Menu menu;
        private int WatchId;
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            //menu = new Menu(service);
            // Eliminado Watcher porque WatchId no tiene valor aquí 
            // y genera excepción en constructor
            //view = new Watcher(service, WatchId);
            listBoxSearchRes.Sorted = true;
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Content> cList = service.Search(textBoxKeyWords.Text, textBoxUplNick.Text, textBoxSubject.Text, dateTimePickerEarly.Value, dateTimePickerLate.Value);
                foreach (Content c in cList)
                {
                    // Esto está mal, hay que tener un datagridview
                    // y meter en él la info a mostrar del content
                    // De momento meto sólo el Id para que se pueda mostrar 
                    // el Watcher
                    // TO DO ALUMNOS -----------------------------------

                    listBoxSearchRes.Items.Add(c.Id);
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

        private void ListBoxSearchRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Content c1 = (Content)listBoxSearchRes.SelectedItem;
            //WatchId = c1.Id;
            // Esto cambiará cuando se tenga un datagridview
            // TO DO Alumnos -----------------------------------
            WatchId = (int) listBoxSearchRes.SelectedItem;
            //this.Hide();  

            // Añadido, aquí WatchId sí tiene valor
            view = new Watcher(service, WatchId);
            view.ShowDialog();
            //this.Close();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //menu.ShowDialog();
            this.Close();
        }

    }
}
