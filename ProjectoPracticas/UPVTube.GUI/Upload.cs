using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UPVTube.GUI
{
    public partial class Upload : Form
    {
        private IUPVTubeService service;
        private Boolean isPublic = false;

        public Upload(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CheckBoxPublico_CheckedChanged(object sender, EventArgs e)
        {
            if (isPublic == true) { isPublic = false; }
            else { isPublic = true; }
        }
        /// <summary>
        /// 
        /// </summary>

        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            if (TextBoxTitulo.Text == string.Empty || TextBoxDescripcion.Text == string.Empty || TextBoxURI.Text == string.Empty)
            {
                MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxTitulo.Clear();
                TextBoxDescripcion.Clear();
                TextBoxURI.Clear();
                CheckBoxPublico.Checked = false;
                for (int i = 0; i < checkedListBoxSubjects.Items.Count; i++)
                {
                    checkedListBoxSubjects.SetSelected(i, false);
                    checkedListBoxSubjects.SetItemChecked(i, false);
                }
            }
            else
            {
                try
                {
                    List<Subject> lSub = new List<Subject>();
                    foreach (object item in checkedListBoxSubjects.CheckedItems)
                    {
                        lSub.Add((Subject)item);
                    }

                    Member logged = service.ReturnLoggedMember();

                    Boolean pub = false;
                    if (CheckBoxPublico.Checked) { pub = true; }

                    Content c = new Content(TextBoxURI.Text, TextBoxDescripcion.Text, pub, TextBoxTitulo.Text, DateTime.Now, logged);
                    c.Subjects = lSub;
                    service.Upload(c);

                    MessageBox.Show(this, "¡El contenido se ha subido correctamente!", "Contenido Subido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TextBoxDescripcion.Clear();
                    TextBoxTitulo.Clear();
                    TextBoxURI.Clear();
                    CheckBoxPublico.Checked = false;
                    for (int i = 0; i < checkedListBoxSubjects.Items.Count; i++)
                    {
                        checkedListBoxSubjects.SetSelected(i, false);
                        checkedListBoxSubjects.SetItemChecked(i, false);
                    }
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void Upload_Load(object sender, EventArgs e)
        {
            List<Subject> subs = new List<Subject>(service.getSubjects());
            checkedListBoxSubjects.DataSource = subs;
            checkedListBoxSubjects.ValueMember = "Code";
            checkedListBoxSubjects.DisplayMember = "Name";
        }

        private void Upload_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBoxTitulo.Clear();
            TextBoxDescripcion.Clear();
            TextBoxURI.Clear();
            CheckBoxPublico.Checked = false;
            for (int i = 0; i < checkedListBoxSubjects.Items.Count; i++)
            {
                checkedListBoxSubjects.SetSelected(i, false);
                checkedListBoxSubjects.SetItemChecked(i, false);
            }
        }
    }
}
