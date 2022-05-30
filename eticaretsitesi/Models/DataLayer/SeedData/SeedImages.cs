using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eticaretsitesi.Models
{
    public class SeedImages : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> entity)
        {
            //proje başlangıcında gözükmesi için buraya ekliyoruz   -- ürün resimleri
        }
    }
}