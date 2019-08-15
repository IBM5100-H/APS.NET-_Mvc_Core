using Core_web.Data;
using Core_web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_web.Services
{
    public class EfCoreRepository : IRepository<Student>
    {
        private readonly DataContext _context;

        public EfCoreRepository(DataContext context)
        {
            _context = context;
        }

        public Student Add(Student newModel)
        {
            _context.Students.Add(newModel);
            _context.SaveChanges();
            return newModel;
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }
    }
}
