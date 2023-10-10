﻿using System;
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
        public Authorized Authorized { get; set; }
        public virtual Member Owner { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Visualization> Visualizations { get; set; }

    }
}
