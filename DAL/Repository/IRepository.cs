using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);
    }
}
