using System.Collections.Generic;

namespace eticaretsitesi.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<OfficeProduct> Products { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<ProductType> ProductTypes { get; set; }
        public IEnumerable<Image> Images { get; set; }
    }
}