using CleanArchitecture.TaskManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.TaskManager.Domain.Repositories
{
    public interface IBaseRepository<E>
    {
        public Task<bool> Create(E e);

        public Task<bool> Update(E e);
        public Task<bool> Delete(E e);

        public Task<bool> FindById(Guid id, Expression<Func<E, bool>>? conditions = null);
        public Task<List<E>> Query(Expression<Func<E, bool>>? conditions = null);
    }
}
