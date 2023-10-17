using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public Visualization()
        {
        }
        public Visualization(int id, DateTime visualizationDate, Member member)
        {
            this.Id = id;
            this.VisualizationDate = visualizationDate;
            this.Member = member;
        }
    }
}