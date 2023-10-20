﻿using System;
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

        public Boolean isStudent() { return false; }
        public Boolean isTeacher() { return false; }
    }
}

