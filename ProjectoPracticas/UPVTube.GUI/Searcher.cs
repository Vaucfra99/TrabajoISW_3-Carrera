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
        private Menu menu;
        private int WatchId;
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
            menu = new Menu(service);
            view = new Watcher(service, WatchId);
            listBoxSearchRes.Sorted = true;
        }


        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Content> cList = service.Search(textBoxKeyWords.Text, textBoxUplNick.Text, textBoxSubject.Text, dateTimePickerEarly.Value, dateTimePickerLate.Value);
                foreach (Content c in cList)
                {
                    listBoxSearchRes.Items.Add(c);
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
            Content c1 = (Content)listBoxSearchRes.SelectedItem;
            WatchId = c1.Id;

            this.Hide();
            view.ShowDialog();
            this.Close();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void Searcher_Load(object sender, EventArgs e)
        {

        }
    }
}
