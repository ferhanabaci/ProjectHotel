using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Surname Alanı Gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Alanı Gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı Gereklidir")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Alanı Gereklidir")]
        [Compare("Password",ErrorMessage ="Lütfen ilk şifre ile aynı şifreyi girin")]
        public string ConfirmPassword { get; set; }
    }
}
