using Microsoft.AspNetCore.Http;

namespace eticaretsitesi.Models
{
    public class ProductsGridBuilder : GridBuilder
    {
        private const string Def = ProductGridDTO.DefaultFilter;
        public bool IsFilterByProductType => Routes.ProductTypeFilter != Def;
        public bool IsSortByProductType =>
            Routes.SortField.EqualsNoCase(nameof(ProductType));
        public bool IsSortByPrice =>
            Routes.SortField.EqualsNoCase(nameof(OfficeProduct.Price));
        public ProductsGridBuilder(ISession sess) : base(sess)
        {
        }
        public ProductsGridBuilder(ISession sess, ProductGridDTO values,
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            var isInitial = values.ProductType.IndexOf(FilterPrefix.ProductType) == -1;
            Routes.ProductTypeFilter = isInitial ? FilterPrefix.ProductType + values.ProductType : values.ProductType;
        }
        public void LoadFilterSegments(string[] filter)
        {
            Routes.ProductTypeFilter = FilterPrefix.ProductType + filter[0];
        }
        public void ClearFilterSegments()
        {
            Routes.ClearFilters();
        }
    }
}