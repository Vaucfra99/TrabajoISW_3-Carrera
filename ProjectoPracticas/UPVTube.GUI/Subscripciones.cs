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
        /// 
        /// </summary>
        private void Subscripciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            listViewSubscribed.Items.Clear();
            listViewSubscribed.SelectedItems.Clear();
            listViewNotSubscribed.Items.Clear();
            listViewNotSubscribed.SelectedItems.Clear();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        private void Subscripciones_Load(object sender, EventArgs e)
        {
            user = service.ReturnLoggedMember();

            ListSubscribers();
            ListNotSubscribers();
        }

        /// <summary>
        /// 
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
        /// 
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
