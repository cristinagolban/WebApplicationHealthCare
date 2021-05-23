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
        private readonly DatabaseContext _context;

        private IQueryable<T> _entities;

        public BaseRepository(DatabaseContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public virtual async Task<T> AddEntity(T obj)
        {
            await _context.AddAsync(obj);
            return obj;
        }

        public virtual async Task DeleteById(int id)
        {
            var objToDelete = await _entities.FirstAsync(o => o.Id == id);
            _context.Remove(objToDelete);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            var obj = await ((DbSet<T>)_entities).FindAsync(id);
            return  obj;
        }

        public virtual async Task Update(T entity)
        {
            //var objToUpdate = await _entities.FirstOrDefaultAsync(e => e.Id == entity.Id);
            //objToUpdate = entity;

            _context.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
        }

        public Task SaveChangesAsync() => _context.SaveChangesAsync();

        public async Task<IEnumerable<T>> GetWithFilter(Func<T, bool> p)
        {
            return _context.Set<T>().Where(p);
        }
    }
}