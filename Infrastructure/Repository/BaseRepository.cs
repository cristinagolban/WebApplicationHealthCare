using Application;
using Application.Interfaces.Repository;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _context;

        private IQueryable<T> _entities;

        public BaseRepository(DatabaseContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public virtual T AddEntity(T obj)
        {
            _context.Add(obj);
            return obj;
        }

        public virtual void DeleteById(int id)
        {
            var objToDelete = _entities.FirstOrDefault(o => o.Id == id);
            if(objToDelete != null)
            {
                _context.Remove(objToDelete);
            }
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _entities;
        }

        public virtual T GetById(int id)
        {
            var obj = ((DbSet<T>)_entities).Find(id);
            return obj;
        }

        public virtual void Update(T entity)
        {
            //_context.Attach(entity);
            //var entry = _context.Entry(entity);
            //entry.State = EntityState.Modified;

            var objToUpdate = _entities.FirstOrDefault(e => e.Id == entity.Id);
            objToUpdate = entity;
        }
        
        //TODO filter

        public void SaveChanges() => _context.SaveChanges();
    }
}
