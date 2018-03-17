using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Repo
{
    public interface IRepository<T> where T: class
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        int Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
