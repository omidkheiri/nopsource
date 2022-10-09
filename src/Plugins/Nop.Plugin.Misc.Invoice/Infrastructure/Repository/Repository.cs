using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nop.Plugin.Misc.Invoice.Domain;

namespace Nop.Plugin.Misc.Invoice.Infrastructure.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected Nop_dbContext Nop_DbContext { get; set; }
        public RepositoryBase(Nop_dbContext repositoryContext)
        {
            Nop_DbContext = repositoryContext;
        }
        public IQueryable<T> FindAll() => Nop_DbContext.Set<T>().AsNoTracking();
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
            Nop_DbContext.Set<T>().Where(expression).AsNoTracking();
        public void Create(T entity) => Nop_DbContext.Set<T>().Add(entity);
        public void Update(T entity) => Nop_DbContext.Set<T>().Update(entity);
        public void Delete(T entity) => Nop_DbContext.Set<T>().Remove(entity);
    }
}
