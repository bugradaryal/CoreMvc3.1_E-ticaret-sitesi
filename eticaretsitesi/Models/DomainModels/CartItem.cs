using System.Text.Json.Serialization;

namespace eticaretsitesi.Models
{
    public class CartItem
    {
        public ProductDTO Product { get; set; }
        public int Quantity { get; set; }
        [JsonIgnore]
        public double Subtotal => this.Product.Price * this.Quantity;
    }
}