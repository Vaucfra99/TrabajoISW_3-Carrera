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
        private Content content;

        public Watcher(IUPVTubeService service, Content content)
        {
            InitializeComponent();
            this.service = service;
            this.content = content;
        }
        private void Watcher_Load(object sender, EventArgs e)
        {
            textBoxDate.Text = content.UploadDate.ToString();
            textBoxDate.Enabled = false;
            textBoxDescripcion.Text = content.Description;
            textBoxDescripcion.Enabled = false;
            textBoxUri.Text = content.ContentURI;
            textBoxUri.Enabled = false;
            textBoxTitle.Text = content.Title;
            textBoxTitle.Enabled = false;
            textBoxPropietario.Text = content.Owner.FullName;
            textBoxPropietario.Enabled = false;
            Visualization v = new Visualization(DateTime.Now, content, content.Owner);
            content.Visualizations.Add(v);
        }

        private void Watcher_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
