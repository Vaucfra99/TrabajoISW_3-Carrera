    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public String Email { get; set; }   
        public String FullName { get; set; }
        public DateTime LastAccessDate { get; set; }
        [Key]
        public String Nick { get; set; }
        public String Password { get; set; }
        public List<String> TeacherDomains = new List<String> {"@dsic.upv.es", "@dsica.upv.es"};
        public List<String> StudentDomains = new List<String> {"@inf.upv.es"};
        public virtual ICollection<Visualization> Visualizations { get; set; }
        public virtual ICollection<Content> Contents { get; set; }
        public virtual ICollection<Evaluation> Evaluations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Member> Subscriptors { get; set; }
        public virtual ICollection<Member> SubscribedTo { get; set; }
    }
}
