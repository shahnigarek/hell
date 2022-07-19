using Core.Entities;
using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Implementations
{
    public class StudentRepository : IRepository<Student>
    {
        public void Create(Student entity)
        {
            Dbcontexts.Groups.Add(entity);
        }

        public void Delete(Student entity)
        {
            Dbcontexts.Groups.Remove(entity);
        }

        public void Update(Student entity)
        {
            var student = Dbcontexts.Student.Find(g => g.ID == entity.ID);
            if (student != null)
            {
                group.Name = entity.Name;
                group.MaxSize = entity.MaxSize;
                group.ID = entity.ID;
            }

        }
        public Student Get(Predicate<Student> filter = null)
        {
            if (filter == null)
            {
                return Dbcontexts.Students[0];

            }
            else
            {
                return Dbcontexts.Students.Find(filter);
            }

        }

        public List<Group> GetAll(Predicate<Group> filter = null)
        {
            if (filter == null)
            {
                return Dbcontexts.Students;
            }

            else
            {
                return Dbcontexts.Students.FindAll(filter);
            }



        }
    }
}
