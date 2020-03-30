using EmpRepo.Repository.Contract.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpRepo.Repository.Contract
{
    public class Repository<T> : IRepository<T> where T : class
    {
        EmpContext context = null;
        public Repository(EmpContext context)
        {
            this.context = context;
        }
        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return context.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().AsEnumerable();
        }

        public void Modify(T entity)
        {
            context.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }
    }
}