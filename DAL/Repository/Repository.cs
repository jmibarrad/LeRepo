using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ShopContext _shopContext;

        public Repository(ShopContext shopContext)
        {
            _shopContext = shopContext;
        }

        public IEnumerable<T> Get()
        {
            return _shopContext.Set<T>();
        }

        public void Update(T entity)
        {
            _shopContext.Set<T>().Attach(entity);
            _shopContext.Entry(entity).State = EntityState.Modified;     
        }

        public void Delete(T entity)
        {
            if (_shopContext.Entry(entity).State == EntityState.Detached)
                _shopContext.Set<T>().Attach(entity);
            _shopContext.Set<T>().Remove(entity);

        }

        public void Create(T entity)
        {
            _shopContext.Set<T>().Add(entity);
        }
    }
}
