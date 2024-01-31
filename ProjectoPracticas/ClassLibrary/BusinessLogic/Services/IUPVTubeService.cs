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
        void AddMember(Member member);
        void Register(String email, String fullName, String nick, String password);
        void LogIn(string nick, String password);
        void LogOut();
        void Upload(Content content);
        List<Content> Search(String title, String creatorNick, Subject subject, DateTime earliest, DateTime latest);
        Content Watch(int id);
        Member ReturnLoggedMember();
        IEnumerable<Subject> getSubjects();
        IEnumerable<Member> getMembers();
        Member getMember(String id);
        List<Member> getNotSubscribedTo();
        List<Member> getSubscribedTo();
        void EvaluarContent(Evaluation evaluation, Authorized aut);
        IEnumerable<Content> GetPendingContents();
        List<Comment> GetComments(Content c);

        void CrearComentario(Comment c);
    }
}
