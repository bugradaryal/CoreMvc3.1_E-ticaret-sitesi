namespace eticaretsitesi.Models
{
    public class ProductDTO : GridDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void Load(Product product)
        {
            this.ProductId = product.ProductId;
            this.Name = product.Name;
            this.Price = product.Price;
        }
    }
}