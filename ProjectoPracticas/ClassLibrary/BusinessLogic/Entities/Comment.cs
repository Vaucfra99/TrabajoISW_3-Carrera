using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Comment
    {
        public Comment()
        { 
        }

        public Comment(int id, string Text, DateTime WritingDate, Content content, Member writer)
        {
            this.Id = id;
            this.Text = Text;
            this.WritingDate = WritingDate;
            this.Content = content;
            this.Writer = writer;
        }
    }
}
