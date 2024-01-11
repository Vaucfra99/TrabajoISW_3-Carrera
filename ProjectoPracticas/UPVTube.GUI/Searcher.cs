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
using UPVTube.GUI;
using System.Xml.Linq;

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
        }

        
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            List<Content> cList = service.Search(textBoxKeyWords.Text, textBoxUplNick.Text, textBoxSubject.Text, dateTimePickerEarly.Value, dateTimePickerLate.Value);
            foreach (Content c in cList)
            {
                listBoxSearchRes.Items.Add(c);
            }
        }
        
        private void ListBoxSearchRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Content c = (Content)listBoxSearchRes.SelectedItem;
            WatchId = c.Id;
            
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
    }
}
