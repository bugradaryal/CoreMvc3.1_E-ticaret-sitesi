using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eticaretsitesi.Models
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private int? count;
        protected ProductContext Context { get; set; }
        private DbSet<T> Dbset { get; }
        public int Count => this.count ?? this.Dbset.Count();
        public Repository(ProductContext ctx)
        {
            this.Context = ctx;
            this.Dbset = this.Context.Set<T>();
        }
        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            var query = this.buildQuery(options);
            return query.ToList();
        }
        public virtual T Get(int id)
        {
            return this.Dbset.Find(id);
        }
        public virtual T Get(string id)
        {
            return this.Dbset.Find(id);
        }
        public virtual T Get(QueryOptions<T> options)
        {
            var query = this.buildQuery(options);
            return query.FirstOrDefault();
        }
        public virtual void Insert(T entity)
        {
            this.Dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            this.Dbset.Update(entity);
        }
        public virtual void Delete(T entity)
        {
            this.Dbset.Remove(entity);
        }
        public virtual void Save()
        {
            this.Context.SaveChanges();
        }
        private IQueryable<T> buildQuery(QueryOptions<T> options)
        {
            IQueryable<T> query = this.Dbset;
            foreach (var include in options.GetIncludes())
            {
                query = query.Include(include);
            }

            if (options.HasWhere)
            {
                foreach (var clause in options.WhereClauses)
                {
                    query = query.Where(clause);
                }

                this.count = query.Count();
            }

            if (options.HasOrderBy)
            {
                if (options.OrderByDirection == "asc")
                {
                    query = query.OrderBy(options.OrderBy);
                }
                else
                {
                    query = query.OrderByDescending(options.OrderBy);
                }
            }

            if (options.HasPaging)
            {
                query = query.PageBy(options.PageNumber, options.PageSize);
            }

            return query;
        }
    }
}