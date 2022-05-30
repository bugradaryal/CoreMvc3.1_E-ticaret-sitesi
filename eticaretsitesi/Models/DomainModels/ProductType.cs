﻿using System.Collections.Generic;

namespace eticaretsitesi.Models
{
    public class ProductType
    {
        public string ProductTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<OfficeProduct> Products { get; set; }
    }
}