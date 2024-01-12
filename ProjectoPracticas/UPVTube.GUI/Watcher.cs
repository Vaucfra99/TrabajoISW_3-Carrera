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
        private int id;

        public Watcher(IUPVTubeService service, int id)
        {
            InitializeComponent();
            this.service = service;
            search = new Searcher(service);
            try
            {
                Content c = service.Watch(id);
                TitleTextBox.Text = c.Title;
                CreatorTextBox.Text = c.Owner.Nick;
                ContentTextBox.Text = c.ContentURI;
                UploadTextBox.Text = c.UploadDate.ToString();
                DescripcionTextBox.Text = c.Description;
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

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            search.ShowDialog();
            this.Close();
        }

        private void Watcher_Load(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }
    }
}
