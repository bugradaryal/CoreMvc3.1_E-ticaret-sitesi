using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace eticaretsitesi.Models
{
    public class SearchData
    {
        private const string SearchKey = "search";
        private const string TypeKey = "searchtype";
        private ITempDataDictionary TempData { get; }
        public string SearchTerm
        {
            get => this.TempData.Peek(SearchKey)?.ToString();
            set => this.TempData[SearchKey] = value;
        }
        public string Type
        {
            get => this.TempData.Peek(TypeKey)?.ToString();
            set => this.TempData[TypeKey] = value;
        }
        public bool HasSearchTerm => !string.IsNullOrEmpty(this.SearchTerm);
        public bool IsProduct => this.Type.EqualsNoCase("product");
        public bool IsType => this.Type.EqualsNoCase("type");
        public SearchData(ITempDataDictionary temp)
        {
            this.TempData = temp;
        }
        public void Clear()
        {
            this.TempData.Remove(SearchKey);
            this.TempData.Remove(TypeKey);
        }
    }
}