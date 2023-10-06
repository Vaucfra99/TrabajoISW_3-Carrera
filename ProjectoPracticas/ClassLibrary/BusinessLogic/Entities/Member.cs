using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.BusinessLogic.Entities
{
    public partial class Member
    {
        public Member() { 
            List<String> StudentDonains = new List<String>();

            List<String> TeacherDomains = new List<String>();
        }

        public Member(String email, String fullName, DateTime lastAccessData, String nick, String password, List<String> StudentDomains, List<String> TeacherDomains, Member member, Content owner, Comment writer):this() { 
        
        }
        

        public Boolean isStudent() { }
        public Boolean isTeacher() { }
    }
}
