using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content

    {
        public string ContentUri { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public bool IsPublic { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public virtual Member owner { get; set; }

         //Añadir el Evaluation con virtual
         //ICollection

    }
}
