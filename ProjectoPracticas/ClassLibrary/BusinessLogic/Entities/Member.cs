using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            this.Subscriptors = new List<Member>();

            this.SubscribedTo = new List<Member>();

        }

        public Member(String email, String fullName, DateTime lastAccessDate, String nick, String password) : this()
        {
            this.Email = email;
            this.FullName = fullName;
            this.LastAccessDate = lastAccessDate;
            this.Nick = nick;
            this.Password = password;
        }

        public bool IsStudent()
        {
            foreach (String alias in StudentDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }
        public bool IsTeacher()
        {
            foreach (String alias in TeacherDomains)
                if (Email.Contains(alias)) return true;
            return false;
        }
        public void AddContent(Content c) {
            Contents.Add(c);
    }
}
}

