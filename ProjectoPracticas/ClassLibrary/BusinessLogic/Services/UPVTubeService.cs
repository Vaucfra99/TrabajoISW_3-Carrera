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
    public class UPVTubeService: IUPVTubeService
    {
        private readonly IDAL dal;

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

    }
}
