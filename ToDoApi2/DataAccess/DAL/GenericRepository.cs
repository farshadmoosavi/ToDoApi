using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Models
{
    public class GenericRepository<T> : IRepository<T> where T : EntityBase
    {
        internal ToDoAPIDbContext context;
        internal DbSet<T> dbset;
        public GenericRepository(ToDoAPIDbContext context)
        {
            this.context = context;
            this.dbset = context.Set<T>();
        }
        public void Add(T entity)
        {
            context.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Add(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {            
            return dbset.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
           IEnumerable<T> Entityset = new List<T>();
            foreach (T entity in dbset)
                Entityset.Append(entity);
            return Entityset;
        }

        public void Remove(T entity)
        {
            context.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.RemoveRange(entities);
        }
    }


}
