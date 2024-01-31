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
        private Comentar comment;

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
            GridViewComentarios.Rows.Clear();
            RellenarGrid();
            GridViewComentarios.Refresh();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {



            this.comment = new Comentar(service, content);
            comment.ShowDialog();

        }




        public void RellenarGrid()
        {

            IEnumerable<Comment> commentList = service.GetComments();
            foreach (Comment c in commentList)
            {

                GridViewComentarios.Rows.Add(c.Writer.ToString(),c.Text);

            }


        }
    }
}
