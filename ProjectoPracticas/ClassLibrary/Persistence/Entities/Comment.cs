using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Persistence.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime WritingDate { get; set; }
        public virtual Content Content { get; set; }
        public virtual Member Writer { get; set; }
    }
}
