namespace LibraryManagementSystem.Models
{
    public class BookEditViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string Summary { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public int AuthorId { get; set; }

    }
}
