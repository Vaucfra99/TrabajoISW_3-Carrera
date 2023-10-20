﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public Evaluation() { }

        public Evaluation (DateTime EvaluationDate, String RejectionReason,  Member censor, Content content) 
        {
            
            this.EvaluationDate = EvaluationDate;
            this.Content = content;
            this.RejectionReason = RejectionReason;
            this.Censor = censor;
        
        }
    }
}
