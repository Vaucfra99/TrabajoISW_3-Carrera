using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Member
    {
        public Member()
        {
            this.Visualizations = new List<Visualization>();

            this.Contents = new List<Content>();
            
            this.Evaluations = new List<Evaluation>();

            this.Comments = new List<Comment>();

            List<String> StudentDomains = new List<String>();

            List<String> TeacherDomains = new List<String>();
        }

        public Member(String email, String fullName, DateTime lastAccessData, String nick, String password,
                      List<String> studentDomains, List<String> teacherDomains) : this()
        {
            this.Email = email;
            this.FullName = fullName;
            this.LastAccessData = lastAccessData;
            this.Nick = nick;
            this.Password = password;
            this.StudentDomains = studentDomains;
            this.TeacherDomains = teacherDomains;
        }

        public Boolean isStudent() { return false; }
        public Boolean isTeacher() { return false; }
    }
}

