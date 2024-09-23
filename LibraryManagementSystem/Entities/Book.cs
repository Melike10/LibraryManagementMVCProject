namespace LibraryManagementSystem.Entities
{
    
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }
        public bool IsDeleted { get; set; }
        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        public string Summary { get; set; }
    }
}
/*Book Modeli:

Id: (Benzersiz kimlik, int türünde)

Title: (Kitap başlığı, string türünde)

AuthorId: (Yazar kimliği, int türünde, Author modeline referans)

Genre: (Kitap türü, string türünde)

PublishDate: (Yayın tarihi, DateTime türünde)

ISBN: (ISBN numarası, string türünde)

CopiesAvailable: (Mevcut kopya sayısı, int türünde)


*/
