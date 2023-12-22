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
        void Register(String email, String fullName, String nick, String password);
        void LogIn(string nick, String password);
        void LogOut();
        void Upload(String title, String description, String contentUri, Boolean isPublic);
        List<Content> Search(String keyWords, String creatorNick, Subject subject, DateTime earliest, DateTime latest);
        Content Watch(int id);
    }
}
