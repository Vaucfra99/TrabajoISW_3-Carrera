using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Entities
{
    public partial class Content
    {
        public Content() { 
        // Inicializar new List<xxx>();
        //
        }
        public Content( string ContentUri , string Description,   bool sPublic, string Title ,DateTime UploadDate,Member owner ):this()
        {
             //Inicializar todos los miembros
             //this.Authorized=Authorized.Yes
             //if Authorizedf.Pending
        }



    }
}
