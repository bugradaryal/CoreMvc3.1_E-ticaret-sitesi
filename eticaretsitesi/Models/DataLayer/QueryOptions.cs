using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace eticaretsitesi.Models
{
    public class QueryOptions<T>
    {
        private string[] includes;
        public Expression<Func<T, object>> OrderBy { get; set; }
        public string OrderByDirection { get; set; } = "asc";
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public WhereClauses<T> WhereClauses { get; set; }
        public Expression<Func<T, bool>> Where
        {
            set
            {
                this.WhereClauses ??= new WhereClauses<T>();

                this.WhereClauses.Add(value);
            }
        }
        public string Include
        {
            set => this.includes = value.Replace(" ", "").Split(',');
        }
        public bool HasWhere => this.WhereClauses != null;
        public bool HasOrderBy => this.OrderBy != null;
        public bool HasPaging => this.PageNumber > 0 && this.PageSize > 0;
        public string[] GetIncludes()
        {
            return this.includes ?? new string[0];
        }
    }
    public class WhereClauses<T> : List<Expression<Func<T, bool>>>
    {
    }
}