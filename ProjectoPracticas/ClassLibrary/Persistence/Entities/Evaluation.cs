﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Persistence.Entities
{
    public partial class Evaluation
    {
        public int Id { get; set; }
        public String RejectionReason { get; set; }
        public DateTime EvaluationDate { get; set; }
        public virtual Content Content { get; set; }
        public virtual Member Censor { get; set; }
    }
}
