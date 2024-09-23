using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    // listeleme için kullanacağımız modelimiz de ihtiyaç duyduğumuz değişkenleri alıyoruz.
    public class BookListViewModel
    {

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public int CopiesAvailable { get; set; }

    }
}
