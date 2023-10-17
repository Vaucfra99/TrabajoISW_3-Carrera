using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Subject
    {
        public Subject()
        {
        }
        public Subject(int code, string fullName, string name)
        {
            this.Code = code;
            this.FullName = fullName;
            this.Name = name;
        }
    }
}
