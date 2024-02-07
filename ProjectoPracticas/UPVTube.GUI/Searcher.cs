using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using UPVTube.Entities;
using UPVTube.Services;


namespace UPVTube.GUI
{
    public partial class Searcher : Form
    {
        private IUPVTubeService service;
        private Watcher watcher;
        private Member user;
        public Searcher(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        /// <summary>
        /// Método que rellena la tabla. Primero comprueba si se ha seleccionado un miembro y asignatura diferente del que está por defecto y, en caso afirmativo establece esos valores
        /// a nulo. Posteriormente, obtiene una lista con los contenidos que coinciden con los datos proporcionados y la muestra en la tabla. En caso de que ocurra algún error mustra
        /// el mensaje de error correspondiente
        /// </summary>
        private void CargarDatosEnGridView()
        {
            try
            {
                String selectedMember = ((Member) comboBoxMember.SelectedItem).Nick;
                if (selectedMember.Equals("     ")) { selectedMember = null; }
                Subject selectedSubject = (Subject) comboBoxSubject.SelectedItem;
                if (selectedSubject.Code == 0000) { selectedSubject = null; }

                List<Content> cList = service.Search(textBoxTitle.Text, selectedMember, selectedSubject, dateTimePickerEarly.Value.Date, dateTimePickerLate.Value.Date);
                if(cList.Count > 0)
                {
                    foreach (Content c in cList)
                    {
                        String sub = "";
                        foreach (Subject s in c.Subjects)
                        {
                            sub += s.Name + ", ";
                        }
                        String acceso = "Privado";
                        if (c.IsPublic) { acceso = "Público"; }


                        Boolean visto = false;
                        DateTime date;
                        
                        List<Visualization> vList = user.Visualizations.ToList();

                        vList = vList.OrderByDescending(vi => vi.VisualizationDate).ToList();
                        foreach (Visualization v in vList)
                        {
                            if (v.Content.Id == c.Id)
                            {
                                date = v.VisualizationDate;
                                GridContents.Rows.Add(c.Title, c.Owner.Nick, c.Description, acceso, c.UploadDate, sub, date, c.Id);
                                visto = true;
                                break;
                            }
                        }
                        if (!visto)
                        {
                            GridContents.Rows.Add(c.Title, c.Owner.Nick, c.Description, acceso, c.UploadDate, sub, "Contenido no visualizado", c.Id);
                        }


                        GridContents.Sort(GridContents.Columns[4], ListSortDirection.Ascending);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se ha encontrado ningún contenido que coincida con los datos introducidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (ServiceException ex)
            {
                MessageBox.Show(this, ex.Message, "Error de Servicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        /// <summary>
        /// Método que, al abrir el formulario, establece unas fechas por defecto, obtiene las listas con los miembros y asignaturas que hay y rellena las cajas de elección con ellos, añadiendo 
        /// un miembro y una asignatura 'vacio'
        /// </summary>
        private void Searcher_Load(object sender, EventArgs e)
        {
            user = service.ReturnLoggedMember();
            DateTime early = new DateTime(1999, 1, 1);
            DateTime late = new DateTime(2199, 1, 1);
            dateTimePickerEarly.Value = early;
            dateTimePickerLate.Value = late;
            GridContents.Enabled = false;

            List<Subject> subjects = new List<Subject>(service.getSubjects());
            Subject noSubject = new Subject(00000, "xxxxx", "     ");
            subjects.Add(noSubject);
            comboBoxSubject.DataSource = subjects;
            comboBoxSubject.SelectedItem = noSubject;
            comboBoxSubject.DisplayMember = "Name";
            comboBoxSubject.ValueMember = "Code";


            List<Member> members = new List<Member>(service.getMembers());
            Member noMember = new Member("xxx@xxx.xxx", "     ", DateTime.Now, "     ", "0000");
            members.Add(noMember);
            comboBoxMember.DataSource = members;
            comboBoxMember.SelectedItem = noMember;
            comboBoxMember.DisplayMember = "Nick";
            comboBoxMember.ValueMember = "Nick";
        }

        /// <summmary>
        /// Método que, al pulsar el botón correspondiente, muestra el contenido seleccionado. En caso de no haber seleccionado ninguno muestra un mensaje de error
        /// </summary>
        private void buttonVerCont_Click(object sender, EventArgs e)
        {
            if (GridContents.Enabled == true && GridContents.SelectedRows != null)
            {
                int id = (int)GridContents.SelectedRows[0].Cells[7].Value;
                Content c = service.Watch(id);
                watcher = new Watcher(service, c);
                watcher.ShowDialog();

                
                
                GridContents.Rows.Clear();
                GridContents.Refresh();
                CargarDatosEnGridView();
            }
            else
            {
                MessageBox.Show(this, "Selecciona un contenido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Método que, al pulsar el botón correspondiente, vacía la tabla para evitar repeticiones y ejecuta el método para rellenar la tabla
        /// </summary>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            GridContents.Enabled = true;
            GridContents.Rows.Clear();
            GridContents.Refresh();
            CargarDatosEnGridView();
        }

        /// <summary>
        /// Método que al cerrar el formulario vacía la tabla y la desactiva
        /// </summary>
        private void Searcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            GridContents.Rows.Clear();
            GridContents.Refresh();
            GridContents.Enabled = false;
        }
    }
}
