using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPVTube.Entities;


namespace UPVTube.Services
{
    public interface IUPVTubeService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddSubject(Subject subject);

        //
        // A partir de aquí los necesarios para los CU solicitados
        //

        void EvaluateContent();
    }
}
