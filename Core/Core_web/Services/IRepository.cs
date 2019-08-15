using System.Collections.Generic;
using Core_web.Model;

namespace Core_web.Services
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T newModel);
    }
}
