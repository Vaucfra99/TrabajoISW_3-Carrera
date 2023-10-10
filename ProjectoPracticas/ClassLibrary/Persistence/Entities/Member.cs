using System;
using System.Collections.Generic;
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
        public DateTime LastAccessData { get; set; }
        public String Nick { get; set; }
        public String Password { get; set; }
        public List<String> StudentDomains { get; set; }
        public List<String> TeacherDomains { get; set; }
        public ICollection<Visualization> Visualizations { get; set; }
        public ICollection<Content> Contents { get; set; }
        public ICollection<Evaluation> Evaluations { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
