using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Demo.Domain.Entities;

namespace Demo.Aplication.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T Get(Func<T, bool> predicate);
        List<T> GetAll(Expression<Func<T, bool>>? predicate = null);
        void Add(T entity);
        void Remove(int id);
        void Update(int id, T entity);
    }

}
