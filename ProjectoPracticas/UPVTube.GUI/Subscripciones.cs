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

        private void Subscripciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            listViewSubscribed.Items.Clear();
            listViewSubscribed.SelectedItems.Clear();
            listViewNotSubscribed.Items.Clear();
            listViewNotSubscribed.SelectedItems.Clear();
        }

        private void ListSubscribers()
        {
            List<Member> subscribedTo = service.getSubscribedTo();
            foreach (Member m in subscribedTo)
            {
                listViewSubscribed.Items.Add(m.Nick);
            }
        }

        private void ListNotSubscribers()
        {
            List<Member> notSubscribedTo = service.getNotSubscribedTo();
            foreach (Member m in notSubscribedTo)
            {
                listViewNotSubscribed.Items.Add(m.Nick);
            }
        }

        private void Subscripciones_Load(object sender, EventArgs e)
        {
            user = service.ReturnLoggedMember();

            ListSubscribers();
            ListNotSubscribers();
        }
            
        private void buttonSuscribe_Click(object sender, EventArgs e)/// el que hace desde la derecha hacia la izquierda
        {
            if(listViewNotSubscribed.SelectedItems.Count > 0)
            {
                String id = listViewNotSubscribed.SelectedItems[0].Text;
                Member SelectedMember = service.getMember(id);

                service.AddSubscribedToUser(SelectedMember);
                service.AddSubscriptorUser(SelectedMember);

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

        private void buttonUnSubscribe_Click(object sender, EventArgs e)/// el que hace desde la izquierda hasta la izquierda
        {
            if(listViewSubscribed.SelectedItems.Count > 0)
            {
                String id = listViewSubscribed.SelectedItems[0].Text;
                Member SelectedMember = service.getMember(id);

                service.RemoveSubscriptionFromUser(SelectedMember);
                service.RemoveSubscriberFromSelectedMember(SelectedMember);

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
