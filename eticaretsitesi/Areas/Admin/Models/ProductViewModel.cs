using System.Collections.Generic;

namespace eticaretsitesi.Models
{
    public class ProductViewModel
    {
        public OfficeProduct Product { get; set; }
        public IEnumerable<ProductType> Types { get; set; }
    }
}