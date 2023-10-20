using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Evaluation
    {
        public Evaluation() { }

        public Evaluation (int Id, String RejectionReason, DateTime EvaluationDate, Member censor, Content content) 
        {
            this.Id = Id;
            this.EvaluationDate = EvaluationDate;
            this.Content = content;
            this.RejectionReason = RejectionReason;
            this.Censor = censor;
        
        }
    }
}
