using System.Collections.Generic;
using System.Linq;

namespace eticaretsitesi.Models
{
    public static class FilterPrefix
    {
        public const string ProductType = "type-";
    }
    public class RouteDictionary : Dictionary<string, string>
    {
        public int PageNumber
        {
            get => this.get(nameof(GridDTO.PageNumber)).ToInt();
            set => this[nameof(GridDTO.PageNumber)] = value.ToString();
        }
        public int PageSize
        {
            get => this.get(nameof(GridDTO.PageSize)).ToInt();
            set => this[nameof(GridDTO.PageSize)] = value.ToString();
        }
        public string SortField
        {
            get => this.get(nameof(GridDTO.SortField));
            set => this[nameof(GridDTO.SortField)] = value;
        }
        public string SortDirection
        {
            get => this.get(nameof(GridDTO.SortDirection));
            set => this[nameof(GridDTO.SortDirection)] = value;
        }
        public string ProductTypeFilter
        {
            get => this.get(nameof(ProductGridDTO.ProductType))?.Replace(FilterPrefix.ProductType, "");
            set => this[nameof(ProductGridDTO.ProductType)] = value;
        }
        public void SetSortAndDirection(string fieldName, RouteDictionary current)
        {
            this[nameof(GridDTO.SortField)] = fieldName;

            if (current.SortField.EqualsNoCase(fieldName) &&
                current.SortDirection == "asc")
            {
                this[nameof(GridDTO.SortDirection)] = "desc";
            }
            else
            {
                this[nameof(GridDTO.SortDirection)] = "asc";
            }
        }
        public void ClearFilters()
        {
            this.ProductTypeFilter = ProductGridDTO.DefaultFilter;
        }
        private string get(string key)
        {
            return Keys.Contains(key) ? this[key] : null;
        }
        public RouteDictionary Clone()
        {
            var clone = new RouteDictionary();
            foreach (var key in Keys)
            {
                clone.Add(key, this[key]);
            }

            return clone;
        }
    }
}