﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public int Id { get; set; }
        public String RejectionReason { get; set; }
        public DateTime EvaluationDate { get; set; }
        [Required]
        public virtual Content Content { get; set; }
        public virtual Member Censor { get; set; }
    }
}
