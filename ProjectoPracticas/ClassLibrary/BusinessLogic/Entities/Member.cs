using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Persistence.Entities;

namespace UPVTube.BusinessLogic.Entities
{
    public partial class Member
    {
        public Member() 
        { 
            List<String> StudentDomains = new List<String>();

            List<String> TeacherDomains = new List<String>();
        }

        public Member(String email, String fullName, DateTime lastAccessData, String nick, String password, 
                      List<String> studentDomains, List<String> teacherDomains, Member member, Content owner, 
                      Comment writer):this() 
        {
            this.Email = email;
            this.Fullname = fullName;
            this.LastAccessData = lastAccessData;
            this.Nick = nick;
            this.Password = password;
            this.StudentDomains = studentDomains;
            this.TeacherDomains = teacherDomains;
            this.member = member;
            this.Owner = owner;
            this.Writer = writer;
        
        }
        

        private Boolean isStudent() { return false; }
        private  Boolean isTeacher() { return false; }
        }
    }
}
