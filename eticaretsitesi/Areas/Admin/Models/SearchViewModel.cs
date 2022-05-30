using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eticaretsitesi.Models
{
    public class SearchViewModel
    {
        public IEnumerable<OfficeProduct> Products { get; set; }
        [Required(ErrorMessage = "Lütfen bir arama terimi girin.")]
        public string SearchTerm { get; set; }
        public string Type { get; set; }
        public string Header { get; set; }
    }
}