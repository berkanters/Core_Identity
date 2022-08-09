using System.ComponentModel.DataAnnotations;

namespace CoreIdentity102.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "{0} alanı zorunludur"), Display(Name = "Kullanıcı adı")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} alanı zorunludur"), Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
