using System.Collections.Generic;

namespace eticaretsitesi.Models
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductType> Types { get; set; }
    }
}