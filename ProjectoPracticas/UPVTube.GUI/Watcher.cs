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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UPVTube.GUI
{
    public partial class Watcher : Form
    {
        private IUPVTubeService service;
        private Searcher search;
        public Watcher(IUPVTubeService service, int id)
        {
            InitializeComponent();
            this.service = service;
            search = new Searcher(service);
            Content c = service.Watch(id);
            titleField.Text = c.Title;
            CreatorNickField.Text = c.Owner.Nick;
            ContentIdField.Text = id.ToString();
            UploadDateField.Text = c.UploadDate.ToString();
            DescriptionField.Text = c.Description;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            search.ShowDialog();
            this.Close();
        }
    }
}
