using System;

namespace eticaretsitesi.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public byte[] Data { get; set; }
        public string Url()
        {
            var imageBase64Data = Convert.ToBase64String(this.Data);
            var imageDataUrl = $"data:image/jpg;base64,{imageBase64Data}";
            return imageDataUrl;
        }
    }
}