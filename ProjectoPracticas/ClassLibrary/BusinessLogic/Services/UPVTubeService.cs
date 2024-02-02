using UPVTube.Entities;
using UPVTube.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

            //Crear asignaruras
            Subject s1 = new Subject(11555, "Ingeniería del software", "ISW");
            Subject s2 = new Subject(11553, "Arquitectura e ingeniería de computadores", "AIC");
            Subject s3 = new Subject(11548, "Bases de datos y sistemas de información", "BDA");
            Subject s4 = new Subject(11560, "Sistemas inteligentes", "SIN");
            Subject s5 = new Subject(11111, "Tecnología de sistemas de información en la red", "TSR");

            //Añadir asignaturas a la Base de Datos
            AddSubject(s1);
            AddSubject(s2);
            AddSubject(s3);
            AddSubject(s4);
            AddSubject(s5);

            //Crear los miembros
            Member m1 = new Member("isanromf@inf.upv.es", "Irene San Román Fuentes", DateTime.Now, "irene", "irene1");
            Member m2 = new Member("vaucfra@inf.upv.es", "Victor Aucejo Franco", DateTime.Now, "victor", "victor2");
            Member m3 = new Member("fjaen@dsic.upv.es", "Javier Jaen", DateTime.Now, "fjaen", "pitufo");
            Member m4 = new Member("mnoloriv@gmail.com", "Manolo Gonzalez Rivera", DateTime.Now, "manolo", "manolete");
            Member m5 = new Member("admin@dsica.upv.es", "Administrador", DateTime.Now, "Admin", "Admin");

            //Añadir los miembros a la Base de Datos
            AddMember(m1);
            AddMember(m2);
            AddMember(m3);
            AddMember(m4);
            AddMember(m5);

            //Crear los contenidos
            Content c1 = new Content("Teoría", "Contenidos de la primera sesión de teoría", true, "ISW Teoría 1", DateTime.Now, m3);
            Content c2 = new Content("Práctica", "Contenidos de la segunda sesión de prácticas", true, "ISW Práctica 2 ", DateTime.Now, m3);
            Content c3 = new Content("Gatos.com", "Video de 2 gatos bailando", true, "Video gatos", DateTime.Now, m1);
            Content c4 = new Content("PianoPies.net", "Tutorial avanzado de como tocar el piano con los pies", true, "Como tocar el piano con los pies", DateTime.Now, m1);
            Content c5 = new Content("Platón.es", "Disertacion sobre Platón para el examen de filosofía que suspendí en 2 de Bachiller y tuve que recuperar y casi me hace pegarme un tiro", true, "Disertacrón Platón", DateTime.Now, m2);

            //Añadir los contenidos a la Base de Datos
            dal.Insert(c1);
            dal.Insert(c2);
            dal.Insert(c3);
            dal.Insert(c4);
            dal.Insert(c5);

            //Crearlos comentarios
            Comment com1 = new Comment("Javier Jaen nos salva la vida", DateTime.Now, c2, m1);
            Comment com2 = new Comment("Javier Jaen nos salva la vida", DateTime.Now, c2, m2);
            Comment com3 = new Comment("Que monos los gatos", DateTime.Now, c3, m4);
            Comment com4 = new Comment("A mi también me cae mal Platón", DateTime.Now, c5, m3);
            Comment com5 = new Comment("Que asco tocar un piano con los pies", DateTime.Now, c4, m1);

            //Añadir los comentarios a la Base de Datos
            dal.Insert(com1);
            dal.Insert(com2);
            dal.Insert(com3);
            dal.Insert(com4);
            dal.Insert(com5);


            //Crear visualizaciones
            Visualization v1 = new Visualization(DateTime.Now, c2, m1);
            Visualization v2 = new Visualization(DateTime.Now, c2, m1);
            Visualization v3 = new Visualization(DateTime.Now, c3, m2);
            Visualization v4 = new Visualization(DateTime.Now, c4, m2);
            Visualization v5 = new Visualization(DateTime.Now, c1, m3);
            Visualization v6 = new Visualization(DateTime.Now, c5, m3);
            Visualization v7 = new Visualization(DateTime.Now, c3, m4);
            Visualization v8 = new Visualization(DateTime.Now, c5, m4);

            //Añadir las visualizaciones a la Base de Datos
            dal.Insert(v1);
            dal.Insert(v2);
            dal.Insert(v3);
            dal.Insert(v4);
            dal.Insert(v5);
            dal.Insert(v6);
            dal.Insert(v7);
            dal.Insert(v8);



            //Añadir los contenidos a cada Asignatura(Subject)
            s1.Contents.Add(c1);
            s1.Contents.Add(c2);
            s2.Contents.Add(c5);
            s3.Contents.Add(c2);
            s3.Contents.Add(c3);
            s3.Contents.Add(c4);
            s4.Contents.Add(c3);
            s5.Contents.Add(c5);

            //Añadir las visualizaciones a los miembros
            m1.Visualizations.Add(v1);
            m1.Visualizations.Add(v2);
            m2.Visualizations.Add(v3);
            m2.Visualizations.Add(v4);
            m3.Visualizations.Add(v5);
            m3.Visualizations.Add(v6);
            m4.Visualizations.Add(v7);
            m4.Visualizations.Add(v8);

            //Añadir los Contenidos a los Miembros
            m1.AddContent(c3);
            m1.AddContent(c4);
            m2.AddContent(c5);
            m3.AddContent(c2);
            m3.AddContent(c1);

            //Añadir losComentarios a los Miembros
            m1.Comments.Add(com1);
            m2.Comments.Add(com2);
            m4.Comments.Add(com3);
            m3.Comments.Add(com4);
            m1.Comments.Add(com5);

            //Añadir las Suscriptores a los Miembros
            m3.Subscriptors.Add(m1);
            m3.Subscriptors.Add(m2);
            m1.Subscriptors.Add(m4);

            //Añadir las Suscripciones a los Miembros
            m1.SubscribedTo.Add(m3);
            m2.SubscribedTo.Add(m3);
            m4.SubscribedTo.Add(m1);

            //Autorizar Contenidos
            c1.Authorized = Authorized.Yes;
            c2.Authorized = Authorized.Yes;
            c3.Authorized = Authorized.Pending;
            c4.Authorized = Authorized.Pending;
            c5.Authorized = Authorized.Pending;

            //Añadir los Comentarioslos Contenidos
            c2.Comments.Add(com1);
            c2.Comments.Add(com2);
            c3.Comments.Add(com3);
            c4.Comments.Add(com5);
            c5.Comments.Add(com4);

            //Añadir Asignaturas(Subjects) a los Contenidos
            c1.Subjects.Add(s1);
            c2.Subjects.Add(s1);
            c2.Subjects.Add(s3);
            c3.Subjects.Add(s3);
            c3.Subjects.Add(s4);
            c4.Subjects.Add(s3);
            c5.Subjects.Add(s2);
            c5.Subjects.Add(s5);

            //Añadir las Visualizaciones a los Contenidos
            c2.Visualizations.Add(v1);
            c2.Visualizations.Add(v2);
            c3.Visualizations.Add(v3);
            c4.Visualizations.Add(v4);
            c1.Visualizations.Add(v5);
            c5.Visualizations.Add(v6);
            c3.Visualizations.Add(v7);
            c5.Visualizations.Add(v8);

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
            else
            {
                throw new ServiceException("Member with nick " + member.Nick + " already exists.");
            }

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
                Logged = user;
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

        public void Upload(Content c)
        {
            if (Logged == null) { throw new ServiceException("El usuario no ha iniciado sesión"); }
            else if (dal.GetWhere<Content>(cont => cont.ContentURI == c.ContentURI).Any()) { throw new ServiceException("Ya existe un contenido con esa URI"); }
            else
            {
                dal.Insert<Content>(c);
                dal.Commit();
            }
        }


        public List<Content> Search(String title, String creatorNick, Subject subject, DateTime earliest, DateTime latest)
        {

            List<Content> cList = (List<Content>)dal.GetWhere<Content>(c => (c.Authorized == Authorized.Yes) || (c.Authorized == Authorized.Pending)).ToList();

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

            if (!(Logged.IsStudent() || Logged.IsTeacher()))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.IsPublic == true).ToList();
            }
            if (!(creatorNick == null || creatorNick == ""))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Owner.Nick == creatorNick).ToList();
            }
            if (!(subject == null))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Subjects.Where<Subject>(s => s.FullName.Equals(subject.FullName)).Any() == true).ToList();
            }
            if (!(title == null || title == ""))
            {
                cList = (List<Content>)cList.Where<Content>(c => c.Title.Contains(title)).ToList();
            }
            return cList;
        }

        public Content Watch(int id)
        {
            return dal.GetById<Content>(id);
        }

        public IEnumerable<Content> GetPendingContents()
        {
            IEnumerable<Content> pending = new List<Content>();
            IEnumerable<Content> all = dal.GetAll<Content>();

            foreach (Content c in all)
            {
                if (c.Authorized == Authorized.Pending)
                {
                    pending = pending.Append<Content>(c);
                }
            }
            return pending;
        }


        public List<Comment> GetComments(Content content)
        {

            List<Comment> comments = dal.GetAll<Comment>().ToList();
            List<Comment> red = new List<Comment>();
            foreach (Comment c in comments)
            {
                if (c.Content.Id == content.Id)
                {
                    red.Add(c);
                }
            }
            return red;

        }


        public void CrearComentario(Comment c)
        {

            dal.Insert(c);
            dal.Commit();

        }

        public Member ReturnLoggedMember()
        {
            return Logged;
        }

        public IEnumerable<Subject> getSubjects()
        {
            return dal.GetAll<Subject>();
        }

        public List<Member> getMembers()
        {
            List<Member> all = dal.GetAll<Member>().ToList();
            List<Member> res = new List<Member>();
            foreach (Member m in all)
            {
                if(m.IsStudent() || m.IsTeacher()){
                    res.Add(m);
                }
            }
            return res;
        }

        public List<Member> getNotSubscribedTo()
        {
            List<Member> subscribedTo = Logged.SubscribedTo.ToList();
            List<Member> notSubscribed = dal.GetAll<Member>().ToList();

            if (subscribedTo.Count() != 0)
            {
                foreach (Member m in subscribedTo)
                {
                    notSubscribed.Remove(m);
                }
            }

            notSubscribed.Remove(Logged);
            return notSubscribed;
        }
        public List<Member> getSubscribedTo()
        {
            return Logged.SubscribedTo.ToList();
        }

        public Member getMember(String id)
        {
            return dal.GetById<Member>(id);
        }

        public void EvaluarContent(Evaluation ev, Authorized a)
        {
            if (a == Authorized.Yes)
            {
                ev.Content.Authorized = Authorized.Yes;
            }
            else
            {
                if (ev.RejectionReason.Equals(""))
                {
                    throw new ServiceException("Es necesario añadir una razón de rechazo");
                }
                else
                {
                    ev.Content.Authorized = Authorized.No;
                }
            }
            dal.Insert<Evaluation>(ev);
            Logged.Evaluations.Add(ev);
            dal.Commit();
        }
    }
}
