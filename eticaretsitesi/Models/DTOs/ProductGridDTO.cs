using Newtonsoft.Json;

namespace eticaretsitesi.Models
{
    public class ProductGridDTO : GridDTO
    {
        [JsonIgnore] public const string DefaultFilter = "all";
        public string ProductType { get; set; } = DefaultFilter;
    }
}