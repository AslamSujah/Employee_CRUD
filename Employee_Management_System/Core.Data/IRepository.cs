using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data
{
    public interface IRepository : IDisposable
    {
        IEnumerable<T> GetAll<T>() where T : class;

        IEnumerable<T> GetById<T>(int id) where T : class;

        IEnumerable<T> GetByName<T>(string name) where T : class;

        void Add<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;
    }
}
