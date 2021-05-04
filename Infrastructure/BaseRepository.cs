using Application;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DatabaseContext _context = null;

        public IQueryable<T> Table => _context.Set<T>();

        public BaseRepository(DatabaseContext context)
        {
            _context = context;
        }

        public virtual T AddEntity(T obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public virtual void DeleteById(int id)
        {
            var objToDelete = Table.ToList().FirstOrDefault(o => o.Id == id);
            _context.Remove(objToDelete);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return Table.ToList();
        }

        public virtual T GetById(int id)
        {
            var obj = ((DbSet<T>)Table).Find(id);
            return obj;
        }

        public virtual void Update(T entity)
        {
            _context.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
