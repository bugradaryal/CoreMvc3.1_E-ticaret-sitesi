﻿using System.Collections.Generic;
using System.Linq;

namespace eticaretsitesi.Models
{
    public static class CartItemListExtensions
    {
        public static List<CartItemDTO> ToDTO(this List<CartItem> list)
        {
            return list.Select(ci => new CartItemDTO {
                OfficeProductId = ci.Product.OfficeProductId,
                Quantity = ci.Quantity
            }).ToList();
        }
    }
}