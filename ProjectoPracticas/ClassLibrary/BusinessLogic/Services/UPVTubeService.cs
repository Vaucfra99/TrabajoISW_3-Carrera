﻿using UPVTube.Entities;
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
           



            // Añadir los 4 contenidos





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
        public void Register(String email, String fullName,String nick, String password)
        {
            Member user = dal.GetById<Member>(nick);
            if (user != null) { throw new ServiceException("El nick ya existe"); }
            // Para verificar que hay un member con ese email 
            // se tiene que hacer una nueva consulta al dal con GetWhere
            else
            if (dal.GetWhere<Member>(m => m.Email == email).Any()) throw new ServiceException("Ya existe un nick con ese email");
            
            else
            {
                user=new Member(email,fullName,DateTime.Now,nick, password);
                dal.Insert(user);
                dal.Commit();
            }
        }
        public void LogIn(string nick, String password)
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

        public void Upload(String title, String description, String contentUri, boolean isPublic) {
            if (true) { throw new ServiceException(""); }
            else
            {
                Content content = new Content(contentUri, description, isPublic, title);
                dal.Commit();
            }
        }


        public List<Content> Search(String keyWords, String creatorNick, Subject subject, DateTime earliest, DateTime latest)
        {
            cList = dal.GetWhere<Content>(c => c.Authorized == Authorized.Yes).Any();

            //Si no hay fecha inicial se pone por defecto una que asumimos mas antigua que el contenido mas antiguo
            if(earliest == null)
            {
                ealiest = new DateTime(1990, 0, 0, 0, 0, 0);
            }
            //Si no hay fecha final se pone por defecto la actual
            if (latest == null)
            {
                    latest = new DateTime.Now();
            }
            List<Content> cList = cList.Where<Content>(c => c.UploadDate.CompareTo(earliest) >= 0 && c.UploadDate.CompareTo(latest) <= 0);

            if (!(Logged.isStudent() || Logged.isTeacher()))
            {
                cList = cList.Where<Content>(c => c.isPublic());
            }
            if (!(creatorNick == null || creatorNick == ""))
            {
                cList = cList.Where<Content>(c => c.Owner.Nick == creatorNick);
            }
            if (Subject != null)
            {
                cList = cList.Where<Content>(c => c.Subject == subject);
            }
            if (!(keyWords == null || keyWords == ""))
            {
                cList = cList.Where<Content>(c => c.Title.Contains(keyWords));
            }
            return cList;
        }

        public Content Watch(int id)
        {
            return dal.GetById<Content>(id);
        }

        public void EvaluateContent()
        {
            //El profesor ha iniciado sesion en el sistema
            if (Logged == null || !(Logged.isTeacher()  ))
            {
                throw new ServiceException("Se requiere que un profesor haya iniciado sesión para evaluar contenido.");
            }

            //Busca contenidos pendientes de evaluacion
            IEnumerable<Content> pendingContent = dal.GetWhere<Content>(c => c.Authorized == Authorized.Pending)
                .OrderBy(c => c.UploadDate) //ordenado por fecha de subida
                .ToList();
        }
    }
}
