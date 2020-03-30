using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpRepo.Repository.Contract.Core
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Modify(T entity);
        void Remove(T entity);
        IEnumerable<T> Find(Func<T, bool> predicate);
        IEnumerable<T> GetAll();
    }
}