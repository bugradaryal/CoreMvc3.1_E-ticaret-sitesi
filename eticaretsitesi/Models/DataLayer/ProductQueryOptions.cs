using eticaretsitesi.Models;

namespace eticaretsitesi.Models
{
    public class ProductQueryOptions : QueryOptions<Product>
    {
        public void SortFilter(ProductsGridBuilder builder)
        {
            if (builder.IsFilterByProductType)
            {
                Where = b => b.ProductTypeId == builder.CurrentRoute.ProductTypeFilter;
            }

            if (builder.IsSortByProductType)
            {
                OrderBy = b => b.Type.Name;
            }
            else if (builder.IsSortByPrice)
            {
                OrderBy = b => b.Price;
            }
            else
            {
                OrderBy = b => b.Name;
            }
        }
    }
}