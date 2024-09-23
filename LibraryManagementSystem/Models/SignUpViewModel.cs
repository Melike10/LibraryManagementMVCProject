using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "İsim bilgisini doldurmak zorunludur!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email bilgisi zorunludur.")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "parola bilgisi zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"\d{11}", ErrorMessage = "Lütfen 11 haneli giriş yapınız! Örneğin: 05** *** ****")]
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public SignUpViewModel() { JoinDate = DateTime.Now; }
    }
}
