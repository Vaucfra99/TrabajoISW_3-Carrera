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
        private Member logged;
        public Subscripciones(IUPVTubeService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Subscripciones_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Subscripciones_Load(object sender, EventArgs e)
        {
            logged = service.ReturnLoggedMember();

            IEnumerable<Member> subscribedTo = service.getSubscribedTo();
            foreach (Member m in subscribedTo)
            {
                GridViewSubscribedTo.Rows.Add(m.Nick);
            }

            List<Member> nonSubscribedTo = service.getNotSubscribedTo();
            foreach (Member m in nonSubscribedTo)
            {
                GridViewNonSubscribedTo.Rows.Add(m.Nick);
            }
        }

        private void buttonSuscribed_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNonSubscribed_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowContents_Click(object sender, EventArgs e)
        {

        }
    }
}
