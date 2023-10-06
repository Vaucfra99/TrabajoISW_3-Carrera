using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Persistence.Entities
{
    public partial class Member
    {
        public String Email { get; set; }
        public String FullName { get; set; }
        public DateTime LastAccessData { get; set; }
        public String Nick { get; set; }
        public String Password { get; set; }
        public List<String> StudentDomains { get; set; }
        public List<String> TeacherDomains { get; set; }
        public virtual Member member { get; set; }
        public virtual Content Owner { get; set; }
        public virtual Comment Writer { get; set; }
    }
}
