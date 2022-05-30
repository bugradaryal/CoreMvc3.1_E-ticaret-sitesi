using System.ComponentModel.DataAnnotations;

namespace eticaretsitesi.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen bir kullanıcı adı giriniz.")]
        [StringLength(255)]
        public string Username { get; set; }


        [Required(ErrorMessage = "Lütfen bir şifre girin.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "'Şifre' ile 'Şifre Tekrar' uyuşmuyor.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi onaylayınız.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }



        [Required(ErrorMessage = "Lütfen bir ad girin.")]
        [StringLength(255)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen bir soyadı girin.")]
        [StringLength(255)]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Lütfen bir e-posta adresi giriniz.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}