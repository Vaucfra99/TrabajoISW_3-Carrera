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

        public Upload(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }


        /// <summary>
        /// Método que, al pulsar el boton correspondiente, añade un contenido a la Base de Datos. En el caso de que falte algún elemento por rellenar, muestra un mensaje de error. En caso contrario
        /// obtiene todos los datos necesarios(Subjects, Owner...) y añade el método junto con todos los datos obtenidos, muestra un mensaje de confirmación y vacía todas las cajas de introducción
        /// de información para una introducción posterior. En caso de error muestra el mensaje correspondiente.
        /// </summary>
        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            if (TextBoxTitulo.Text == string.Empty || TextBoxDescripcion.Text == string.Empty || TextBoxURI.Text == string.Empty)
            {
                MessageBox.Show(this, "Complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);        
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
                    logged.AddContent(c);
                    foreach (Subject s in lSub)
                    {
                        s.Contents.Add(c);
                    }

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

        /// <summary>
        /// Método que al abrir el formulario crea una lista con las asignaturas que existen y rellena la caja de selección de asiganturas con todas ellas
        /// </summary>
        private void Upload_Load(object sender, EventArgs e)
        {
            List<Subject> subs = new List<Subject>(service.getSubjects());
            checkedListBoxSubjects.DataSource = subs;
            checkedListBoxSubjects.ValueMember = "Code";
            checkedListBoxSubjects.DisplayMember = "Name";
        }

        /// <summary>
        /// Método que al cerrar el formulario vacía las cajas de texto y las selecciones de la caja de seleccion de asiganturas y pone por defecto el conteido a falso.
        /// </summary>
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
