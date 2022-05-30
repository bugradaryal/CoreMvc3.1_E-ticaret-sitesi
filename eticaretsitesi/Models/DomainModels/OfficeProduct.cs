using System.ComponentModel.DataAnnotations;

namespace eticaretsitesi.Models
{
    public class OfficeProduct
    {
        public int OfficeProductId { get; set; }
        [Required(ErrorMessage = "Lütfen bir isim belirtin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen bir fiyat belirtin")]
        [Range(double.Epsilon, double.MaxValue, ErrorMessage = "Fiyat 0'dan büyük olmalıdır")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Lütfen bir ürün türü belirtin")]
        public string ProductTypeId { get; set; }
        public ProductType Type { get; set; }
        public int ImageId { get; set; }
        public Image Image { get; set; }
    }
}