namespace eticaretsitesi.Models
{
    public interface IProductUnitOfWork
    {
        Repository<OfficeProduct> Products { get; }
        Repository<ProductType> Types { get; }
        Repository<Image> Images { get; }
        void Save();
    }
}