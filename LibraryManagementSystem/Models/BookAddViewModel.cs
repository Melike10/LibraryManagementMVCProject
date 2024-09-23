using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class BookAddViewModel
    {
       
        [Required(ErrorMessage = "Başlığı doldurmak zorunludur!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Türünü doldurmak zorunludur!")]
        public string Genre { get; set; }
        [Required(ErrorMessage ="Yayın Tarihi girişi zorunludur!")]
        public DateTime PublishDate { get; set; }
        [Required(ErrorMessage = "Yazar seçimi zorunludur! Listede aradığınız yazar yoksa lütfen önce yazar bilgisini giriniz.")]
        public int AuthorId { get; set; }
        public int CopiesAvailable { get; set; }

        public string ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "ISBN kodunu doldurmak zorunludur!")]
        [MinLength(3, ErrorMessage = "En az 3 karakter içermelidir")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Özet alanı doldurmak zorunludur!")]
        [MinLength(100, ErrorMessage = "En az 100 karakter içermelidir")]
        public string Summary { get; set; }
    }
}
