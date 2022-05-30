using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaretsitesi.Models
{
    public class SeedProducts : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            //proje başlangıcında gözükmesi için buraya ekliyoruz   -- ürün isimleri ve bilgileri
        }
    }
}