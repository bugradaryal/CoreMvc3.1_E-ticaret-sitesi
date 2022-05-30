namespace eticaretsitesi.Models
{
    public class ProductDTO : GridDTO
    {
        public int OfficeProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public void Load(OfficeProduct product)
        {
            this.OfficeProductId = product.OfficeProductId;
            this.Name = product.Name;
            this.Price = product.Price;
        }
    }
}