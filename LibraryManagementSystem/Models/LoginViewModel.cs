using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class LoginViewModel
    {
        //[Required(ErrorMessage = "Email bilgisi zorunludur.")]
        //[RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "parola bilgisi zorunludur.")]
        //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
