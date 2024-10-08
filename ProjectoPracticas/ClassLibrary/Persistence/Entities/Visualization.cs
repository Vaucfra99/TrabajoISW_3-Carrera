﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Visualization
    {
        public int Id { get; set; }
        public DateTime VisualizationDate { get; set; }
        public virtual Member Member { get; set; }
        public virtual Content Content { get; set; }
    }
}