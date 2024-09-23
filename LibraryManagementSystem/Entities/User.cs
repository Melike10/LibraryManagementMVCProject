namespace LibraryManagementSystem.Entities
{
    /*
     * User Modeli:

Id: (Benzersiz kimlik, int türünde)

FullName: (Üye adı ve soyadı, string türünde)

Email: (Üye e-posta adresi, string türünde)

Password: (Üye giriş parolası, string türünde)

PhoneNumber: (Üye telefon numarası, string türünde)

JoinDate: (Üye kayıt tarihi, DateTime türünde)
     */
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        
    }
}
