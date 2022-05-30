namespace eticaretsitesi.Models
{
    public interface IProductUnitOfWork
    {
        Repository<Product> Products { get; }
        Repository<ProductType> Types { get; }
        Repository<Image> Images { get; }
        void Save();
    }
}