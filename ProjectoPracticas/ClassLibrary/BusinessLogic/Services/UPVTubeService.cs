using UPVTube.Entities;
using UPVTube.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UPVTube.Services
{
    public class UPVTubeService : IUPVTubeService
    {
        private readonly IDAL dal;
        private Member Logged;


        public UPVTubeService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            Subject s1 = new Subject(11555, "Ingeniería del software", "ISW");
            AddSubject(s1);
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
            AddSubject(s2);
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
            AddSubject(s3);
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            AddSubject(s4);

            // Añadir los 3 miembros

            Member m1 = new Member("irene@inf.upv.es", "Irene San Román Fuentes", DateTime.Now, "irene", "irene1");
            AddMember(m1);
            Member m2 = new Member("victor@inf.upv.es", "Victor Aucejo Franco", DateTime.Now, "victor", "victor2");
            AddMember(m2);
            Member m3 = new Member("fjaen@dsic.upv.es", "Javier Jaen", DateTime.Now, "fjaen", "pitufo");
            AddMember(m3);
           


            // Añadir los 4 contenidos

            Content c1 = new Content("teoría", "Práctica 1 ISW", true, "ISW Práctica 1 Contenidos", DateTime.Now, m1);
            AddContent(c1);
            Content c2 = new Content("práctica", "Práctica 2 ISW", true, "ISW Práctica 2 Contenidos", DateTime.Now, m2);
            AddContent(c2);
            Content c3 = new Content("teoría 1", "Teoría 1 ISW", false, "ISW Teoría 1 Contenidos", DateTime.Now, m3);
            AddContent(c3);
            Content c4 = new Content("teoría 2", "Teoría 2 ISW", false, "ISW Teoría 2 Contenidos", DateTime.Now, m3);
            AddContent(c4);

            dal.Commit();
        }

        public void AddSubject(Subject subject)
        {
            // Restricción: No puede haber dos asignaturas con el mismo code
            if (dal.GetById<Subject>(subject.Code) == null)
            {
                // Restricción: No puede haber dos asignaturas con el mismo name
                if (!dal.GetWhere<Subject>(x => x.Name == subject.Name).Any())
                {
                    // Sólo se salva si no hay Code ni email duplicado
                    dal.Insert<Subject>(subject);
                    dal.Commit();
                }
                else
                    throw new ServiceException("Subject with name " + subject.Name + " already exists.");
            }
            else
                throw new ServiceException("Subject with code " + subject.Code + " already exists.");
        }

        // A partir de aquí los métodos para implementar los CU
        //FullName del Member como parámetro

        public void AddMember(Member member)
        {
                
                if (!dal.GetWhere<Member>(x => x.Nick == member.Nick).Any())
                {
                    
                    dal.Insert<Member>(member);
                    dal.Commit();
                }
            else { 
                    throw new ServiceException("Member with nick " + member.Nick + " already exists.");
            }
           
        }

        public void AddContent(Content content)
        {
                dal.Insert<Content>(content);
                dal.Commit();
            }
           



        public void Register(String email, String fullName, String nick, String password)
        {
            IComparable a = nick;

            Member user = dal.GetById<Member>(a);
            if (user != null) { throw new ServiceException("El nick ya existe"); }
            // Para verificar que hay un member con ese email 
            // se tiene que hacer una nueva consulta al dal con GetWhere
            else
            if (dal.GetWhere<Member>(m => m.Email == email).Any()) throw new ServiceException("Ya existe un nick con ese email");

            else
            {
                user = new Member(email, fullName, DateTime.Now, nick, password);
                dal.Insert(user);
                dal.Commit();
            }
        }
        public void LogIn(String nick, String password)
        {
            Member user = dal.GetById<Member>(nick);
            if (user == null) { throw new ServiceException("El nick no existe"); }
            else if (password == user.Password)
            {
                Logged = user;
            }
            else { throw new ServiceException("La contraseña es incorrecta"); }
        }

        public void LogOut()
        {
            if (Logged == null) { throw new ServiceException("No ha iniciado sesión"); }
            else
            {
                Logged.LastAccessDate = DateTime.Now;
                dal.Commit();
                Logged = null;
            }
        }

        public void Upload(String title, String description, String contentUri, Boolean isPublic)
        {
            if (Logged == null) { throw new ServiceException("El usuario no ha iniciado sesión"); }
            else
            {
                DateTime uploadTime = DateTime.Now;
                Content content = new Content(contentUri, description, isPublic, title, uploadTime, Logged);
               
                    dal.Commit();
    
               //para saber si puedes subirlo o no haces Logged.Authroeised == Yes o lo q sea para ver si el profesor te ha dadp permisos 
                
               
               
               
               
            }
        }


        public List<Content> Search(String keyWords, String creatorNick, String subject, DateTime earliest, DateTime latest)
        {
            // To Do Alumnos ------------------------------------
            // Da excepción (añadir .ToList();)
            // Ocurrirá en todos los .Where(...)
            List<Content> cList = (List<Content>)dal.GetWhere<Content>(c => c.Authorized == Authorized.Yes).ToList();

            //Si no hay fecha inicial se pone por defecto una que asumimos mas antigua que el contenido mas antiguo
            if (earliest == null)
            {
                earliest = new DateTime(1990, 0, 0, 0, 0, 0); 
            }
            //Si no hay fecha final se pone por defecto la actual
            if (latest == null)
            {
                latest = DateTime.Now;
            }
            
            cList = (List<Content>)cList.Where<Content>(c => c.UploadDate.CompareTo(earliest) >= 0 && c.UploadDate.CompareTo(latest) <= 0).ToList();

            if (!(Logged.isStudent() || Logged.isTeacher()))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.IsPublic == true);
            }
            if (!(creatorNick == null || creatorNick == ""))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Owner.Nick == creatorNick);
            }
            if (!(subject == null || subject == ""))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Subjects.Where<Subject>(s => s.FullName == subject).Any() == true);
            }
            if (!(keyWords == null || keyWords == ""))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Title.Contains(keyWords));
            }
            return cList;
        }

        public Content Watch(int id)
        {
            return dal.GetById<Content>(id);
        }

        public List<Content> GetPendingContents()
        {
            //El profesor ha iniciado sesion en el sistema
            if (Logged == null || !(Logged.isTeacher()))
            {
                throw new ServiceException("Se requiere que un profesor haya iniciado sesión para evaluar contenido.");
            }

            //Devuelve lista de pending contents
                 return dal.GetWhere<Content>(c => c.Authorized == Authorized.Pending)
                .OrderBy(c => c.UploadDate) //ordenado por fecha de subida
                .ToList();
            //Lo llamará el formulario

        }

        public void EvaluarContent(int contentId, bool evaluacion, string motivoRechazo) {
           
            if (Logged == null || !(Logged.isTeacher()))
            {
                throw new ServiceException("Se requiere que un profesor haya iniciado sesión para evaluar contenido.");
            }
            Content c = dal.GetById<Content>(contentId);
            if (evaluacion) { c.Authorized = Authorized.Yes; }
            else { c.Authorized = Authorized.No;}
            Evaluation evaluation = new Evaluation(DateTime.Now, motivoRechazo, Logged, c);
            dal.Insert(evaluation);
            dal.Commit();
        }
    }
}
