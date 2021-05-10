using Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicApplication.Interfaces.Repositoryation
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<T> AddEntity(T obj);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task DeleteById(int id);
        Task Update(T entity);
        Task<IEnumerable<T>> GetWithFilter(Func<T, bool> p);

    }
}
