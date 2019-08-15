using Core_web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_web.Services
{
    public class InMemoryRepository : IRepository<Student>
    {
        private List<Student> _students;

        public InMemoryRepository()
        {
            _students= new List<Student>
            {
                new Student
            {
                Id=1,
                FirstName="Nick",
                LastName="Carter",
                BirthDate=new DateTime(1980,3,4)
            },
                new Student
            {
                Id=2,
                FirstName="huang",
                LastName="yang",
                BirthDate=new DateTime(1983,4,5)

            },
                new Student
            {
                Id=3,
                FirstName="zhang",
                LastName="qing",
                BirthDate=new DateTime(1990,8,8)
            }
            };
        }

        public Student Add(Student newModel)
        {
            var maxId = _students.Max(x => x.Id);
            newModel.Id = maxId + 1;
            _students.Add(newModel);
            return newModel;
        }

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(x => x.Id == id);
        }
    }
}
