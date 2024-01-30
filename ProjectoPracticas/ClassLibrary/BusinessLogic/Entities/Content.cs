using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content() {

            this.Comments = new List<Comment>();

            this.Subjects = new List<Subject>();

            this.Visualizations = new List<Visualization>();

        }
        public Content(string contentUri, string description, bool isPublic, string title, DateTime uploadDate, Member owner ):this()

        {
            this.ContentURI = contentUri;
            this.Description = description; 
            this.IsPublic = isPublic;
            this.Title = title;
            this.UploadDate = uploadDate;
            this.Owner = owner;
            this.Authorized = Authorized.Yes;
            if (this.Owner.IsStudent()){ this.Authorized = Authorized.Pending;}

        }
    }
}
