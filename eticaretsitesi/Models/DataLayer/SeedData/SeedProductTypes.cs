using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaretsitesi.Models
{
    public class SeedProductTypes : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> entity)
        {
            //proje başlangıcında gözükmesi için buraya ekliyoruz -- ürün filtreleri
            entity.HasData(
                new ProductType { ProductTypeId = "Elektronik", Name = "Elektronik Eşyalar" },
                new ProductType { ProductTypeId = "Ofis", Name = "Ofis Eşyaları" },
                new ProductType { ProductTypeId = "Spor", Name = "Spor Eşyaları" },
                new ProductType { ProductTypeId = "Kozmetik", Name = "Kozmetik Eşyaları" },
                new ProductType { ProductTypeId = "Moda", Name = "Moda Eşyaları" }
            );
        }
    }
}