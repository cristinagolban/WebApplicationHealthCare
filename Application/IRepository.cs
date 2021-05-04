using Domain;
using System.Collections.Generic;

namespace Application
{
    public interface IRepository<T> where T : BaseEntity
    {
        T AddEntity(T obj);
        IEnumerable<T> GetAll();
        T GetById(int id);
        void DeleteById(int id);
        void Update(T entity);
    }
}
