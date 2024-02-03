using Microsoft.Win32;
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

namespace UPVTube.GUI
{
    public partial class Subscripciones : Form

    {
        private IUPVTubeService service;
        private Member user;
        public Subscripciones(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        /// <summary>
        /// Método que al cerrar el formulario vacía las listas y quita la seleccion de los elementos
        /// </summary>
        private void Subscripciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            listViewSubscribed.Items.Clear();
            listViewSubscribed.SelectedItems.Clear();
            listViewNotSubscribed.Items.Clear();
            listViewNotSubscribed.SelectedItems.Clear();
        }

        /// <summary>
        /// Método que añade los miembros a los que esta suscrito el usuario a su lista correspondiente
        /// </summary>
        private void ListSubscribers()
        {
            List<Member> subscribedTo = service.getSubscribedTo();
            foreach (Member m in subscribedTo)
            {
                listViewSubscribed.Items.Add(m.Nick);
            }
        }

        /// <summary>
        /// Método que añade los suscriptores del usuario a su lista correspondiente
        /// </summary>
        private void ListNotSubscribers()
        {
            List<Member> notSubscribedTo = service.getNotSubscribedTo();
            foreach (Member m in notSubscribedTo)
            {
                listViewNotSubscribed.Items.Add(m.Nick);
            }
        }

        /// <summary>
        /// Método que al abrirse el formulario obtiene el usuario y carga ejecuta los método que cargan las listas
        /// </summary>
        private void Subscripciones_Load(object sender, EventArgs e)
        {
            user = service.ReturnLoggedMember();

            ListSubscribers();
            ListNotSubscribers();
        }

        /// <summary>
        /// Método que al pulsar el botón correspondiente, si se ha seleccionado un miembro en la lista de miembros a los q no estas suscrito lo cambia a la lista 
        /// de miembros a los q estas suscrito, actualizando los valores correspondientes y recargangando las listas. En caso de pulsar y no haber elegido 
        /// un miembro muestra un error
        /// </summary>
        private void buttonSuscribe_Click(object sender, EventArgs e)
        {
            if (listViewNotSubscribed.SelectedItems.Count > 0)
            {
                String id = listViewNotSubscribed.SelectedItems[0].Text;
                Member SelectedMember = service.getMember(id);

                user.SubscribedTo.Add(SelectedMember);
                SelectedMember.Subscriptors.Add(user);

                listViewSubscribed.Items.Clear();
                listViewSubscribed.SelectedItems.Clear();
                ListSubscribers();

                listViewNotSubscribed.Items.Clear();
                listViewNotSubscribed.SelectedItems.Clear();
                ListNotSubscribers();
            }
            else
            {
                MessageBox.Show(this, "Selecciona un miembro de la lista de los miembros a los que no estas suscrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Método que al pulsar el botón correspondiente, si se ha seleccionado un miembro en la lista de miembros a los q estas suscrito lo cambia a la lista 
        /// de miembros a los que no estas suscrito, actualizando los valores correspondientes y recargangando las listas. En caso de pulsar y no haber elegido 
        /// un miembro muestra un error
        /// </summary>
        private void buttonUnSubscribe_Click(object sender, EventArgs e)
        {
            if (listViewSubscribed.SelectedItems.Count > 0)
            {
                String id = listViewSubscribed.SelectedItems[0].Text;
                Member SelectedMember = service.getMember(id);

                user.SubscribedTo.Remove(SelectedMember);
                SelectedMember.Subscriptors.Remove(user);

                listViewSubscribed.Items.Clear();
                listViewSubscribed.SelectedItems.Clear();
                ListSubscribers();

                listViewNotSubscribed.Items.Clear();
                listViewNotSubscribed.SelectedItems.Clear();
                ListNotSubscribers();
            }
            else
            {
                MessageBox.Show(this, "Selecciona un miembro de la lista de los miembros a los que estas suscrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
    }
}
