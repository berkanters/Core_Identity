using System.ComponentModel.DataAnnotations;

namespace CoreIdentity102.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "{0} alanı zorunludur"),Display(Name="Kullanıcı adı")]
        public string UserName { get; set; }
        
        [Display(Name = "Telefon No")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        
        
        [Required(ErrorMessage = "{0} alanı zorunludur"),Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "{0} alanı zorunludur"),Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
      
    }
}
