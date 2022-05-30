using System.Collections.Generic;

namespace eticaretsitesi.Models
{
    public interface IRepository<T> where T : class
    {
        int Count { get; }
        IEnumerable<T> List(QueryOptions<T> options);
        T Get(QueryOptions<T> options);
        T Get(int id);
        T Get(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}