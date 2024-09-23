namespace LibraryManagementSystem.Entities
{
    /*Author Modeli:

Id: (Benzersiz kimlik, int türünde)

FirstName: (Yazarın adı, string türünde)

LastName: (Yazarın soyadı, string türünde)

DateOfBirth: (Doğum tarihi, DateTime türünde)

*/
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
        public List<Book> Books { get; set; }
       

    }
}
