namespace eticaretsitesi.Models
{
    public class ProductUnitOfWork : IProductUnitOfWork
    {
        private Repository<OfficeProduct> productData;
        private Repository<ProductType> typeData;
        private Repository<Image> imageData;
        private ProductContext Context { get; }
        public Repository<OfficeProduct> Products
        {
            get
            {
                if (this.productData == null)
                {
                    this.productData = new Repository<OfficeProduct>(this.Context);
                }

                return this.productData;
            }
        }
        public Repository<ProductType> Types
        {
            get
            {
                if (this.typeData == null)
                {
                    this.typeData = new Repository<ProductType>(this.Context);
                }

                return this.typeData;
            }
        }
        public Repository<Image> Images
        {
            get
            {
                if (this.imageData == null)
                {
                    this.imageData = new Repository<Image>(this.Context);
                }

                return this.imageData;
            }
        }
        public ProductUnitOfWork(ProductContext ctx)
        {
            this.Context = ctx;
        }
        public void Save()
        {
            this.Context.SaveChanges();
        }
    }
}