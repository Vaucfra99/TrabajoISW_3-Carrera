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
        private void CheckBoxPublico_CheckedChanged(object sender, EventArgs e)
        {
            if (isPublic == true) { isPublic = false; }
            else { isPublic = true; }
        }

        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            if (TextBoxTitulo.Text == string.Empty || TextBoxDescripcion.Text == string.Empty || TextBoxURI.Text == string.Empty)
            {
                DialogResult error = MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxTitulo.Clear();
                TextBoxDescripcion.Clear();
                TextBoxURI.Clear();
            }
            else
            {
                try
                {
                    List<Subject> lSub= new List<Subject>();
                    foreach (object item in checkedListBoxSubjects.CheckedItems)
                    {
                        lSub.Add((Subject)item);
                    }

                    Member logged = service.ReturnLoggedMember();

                    Boolean pub = false;
                    if (CheckBoxPublico.Checked) { pub = true; }

                    Content c = new Content(TextBoxURI.Text, TextBoxDescripcion.Text, pub, TextBoxTitulo.Text, DateTime.Now, logged);
                    c.Subjects = lSub;
                    c.Authorized = Authorized.Pending;
                    service.Upload(c);
                    
                    DialogResult subido = MessageBox.Show(this, "¡El contenido se ha subido correctamente!", "Contenido Subido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
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
                    DialogResult answer = MessageBox.Show(this, // Owner
                    ex.Message, // Message
                    "Error de Servicio", // Title
                    MessageBoxButtons.OK, // Buttons included
                    MessageBoxIcon.Exclamation); // Icon
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

        private void ButtonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
