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

        public Evaluation(int Id, String RejectionReason, DateTime EvaluationDate, Content Content, Member Censor) 
        {
            this.Id = Id;
            this.EvaluationDate = EvaluationDate;
            this.Content = Content;
            this.RejectionReason = RejectionReason;
            this.Censor = Censor;
        
        }
    }
}
