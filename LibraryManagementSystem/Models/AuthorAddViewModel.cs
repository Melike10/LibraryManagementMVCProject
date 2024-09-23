using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AuthorAddViewModel
    {
        [Required(ErrorMessage ="Yazar Adı Girişi Zorunludur.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Yazar Soyadı Girişi Zorunludur.")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
