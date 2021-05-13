using ApplicApplication.Interfaces.Repositoryation;
using Application;
using Application.Interfaces.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _context = new DatabaseContext();

        private IQueryable<T> _entities;

        public BaseRepository(DatabaseContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public virtual async Task<T> AddEntity(T obj)
        {
            _context.Add(obj);
            return obj;
        }

        public virtual async Task DeleteById(int id)
        {
            var objToDelete = _entities.FirstOrDefault(o => o.Id == id);
            if (objToDelete != null)
            {
                _context.Remove(objToDelete);
            }
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return  _entities;
        }

        public virtual async Task<T> GetById(int id)
        {
            var obj = ((DbSet<T>)_entities).Find(id);
            return  obj;
        }

        public virtual async Task Update(T entity)
        {
            var objToUpdate = _entities.FirstOrDefault(e => e.Id == entity.Id);
            objToUpdate = entity;
        }

      

        public void SaveChanges() => _context.SaveChanges();

        public async Task<IEnumerable<T>> GetWithFilter(Func<T, bool> p)
        {
            return  _context.Set<T>().Where(p);

        }
    }
}