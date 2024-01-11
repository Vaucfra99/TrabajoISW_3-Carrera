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
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
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
            int id = c.Id;
            
            this.Hide();
            view.ShowDialog();//Falta pasarle de lguna forma la id
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
