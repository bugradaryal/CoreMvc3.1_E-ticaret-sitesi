using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaretsitesi.Models
{
    public class SeedProducts : IEntityTypeConfiguration<OfficeProduct>
    {
        public void Configure(EntityTypeBuilder<OfficeProduct> entity)
        {
            //proje başlangıcında gözükmesi için buraya ekliyoruz   -- ürün isimleri ve bilgileri
        }
    }
}