using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class AuthorListViewModel
    {
        public int AuthorId { get; set; }
       
        public string FirstName { get; set; }

        public string LastName { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public List<BookListViewModel> Books { get; set; }
    }
}
