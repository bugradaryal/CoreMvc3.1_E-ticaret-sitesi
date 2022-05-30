using System.ComponentModel.DataAnnotations;

namespace eticaretsitesi.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        [StringLength(255)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre girin.")]
        [StringLength(255)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }
}