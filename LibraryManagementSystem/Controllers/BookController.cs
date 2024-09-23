using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Reflection;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
    public class BookController : Controller
    {
        static List<Book> books = new List<Book> (){
        new Book {BookId =1,Title="Refet",Genre="Yerli Roman",PublishDate=DateTime.Parse("01.01.1896"), ISBN="123",CopiesAvailable=500,AuthorId=1,ImageUrl = "/images/refet.jpg",Summary = "Türk edebiyatının ilk kadın romancısı Fatma Aliye'nin 1896 yılında yayımladığı, döneminin çok ilerisinde bir roman olan Refet, \r\nhenüz kadının adının olmadığı bir toplumda kadının öğrenim ve çalışma haklarını, sosyal hayattaki konumunun artırılmasını savunan güçlü bir eser."},
        new Book {BookId =2,Title="Fareler ve İnsanlar",Genre="Yabancı Roman",PublishDate=DateTime.Parse("01.01.1937"), ISBN="124",CopiesAvailable=300,AuthorId=2 ,ImageUrl = "/images/farelerveinsanlar.jpg",Summary="İlk defa 1937 yılında yayınlanan eser, iki gezgin çiftlik işçisi olan George Milton ve \r\nLennie Small'un büyük bunalım sırasında Kaliforniya'da yaşadıkları trajik olayları anlatır."},
        new Book {BookId =3,Title="Bir Ömür Nasıl Yaşanır",Genre="Deneme",PublishDate=DateTime.Parse("13.02.2019"), ISBN="125",CopiesAvailable=150,AuthorId=3 ,ImageUrl = "/images/biromurnasil.jpg",Summary ="İlber Ortaylı, yediden yetmişe herkesin faydalanacağı, bilge şahsiyetinden ve yaşam tecrübesinden süzülen tavsiyelerden oluşan bir eserle karşımızda. İlber Hoca bu kitapta, bir insanın, çocukluktan itibaren hayatın hemen her alanında ihtiyaç duyacağı çözümleri nasıl bulabileceğini örnekler vererek anlatıyor. “Herkes kendi talihinin mimarıdır” sözünü hatırlatarak, \r\nkendi yolunu çizmenin ne anlama geldiğini tüm kritik noktalarıyla yorumluyor."},
        new Book {BookId =4,Title="Kürk Mantolu Madonna",Genre="Yerli Roman",PublishDate=DateTime.Parse("18.12.1943"), ISBN="126",CopiesAvailable=300,AuthorId=4,ImageUrl = "/images/kurkmantolumadonna.jpg",Summary="Kitap, Maria Puder adında bir kadınla tanışana kadar amaçsız bir hayat yaşayan Raif'in hikayesini anlatıyor. \r\nBaşlangıçta kitap birçok eleştirmen tarafından \"sadece başka bir aşk hikayesi\" olduğu için eleştirildi,\r\n ancak zamanla en çok satanlar arasına girdi ve genellikle Türk edebiyatının en iyi eserleri arasında anılır."},
         new Book {BookId =5,Title="Saatleri Ayarlama Enstitüsü",Genre="Yerli Roman",PublishDate=DateTime.Parse("01.01.1954"), ISBN="127",CopiesAvailable=300,AuthorId=5,ImageUrl = "/images/saatleriayarlamaenstitüsü.jpg",Summary = "Saatleri Ayarlama Enstitüsü, içeriğini ve konusunu romanın karakterlerinden Nuri Efendi (saat ustası), \r\nMübarek (İngiliz yapımı, ayaklı ve yaşlı bir duvar saati), Halit Ayarcı ve saat-zaman-insan ilişkilerinden almaktadır.\r\nYapıt çocukluğu II. Abdülhamit döneminde geçen, Meşrutiyet ve Cumhuriyet dönemlerinde de yaşayan \r\nHayri İrdal'ın anıları şeklinde kurgulanmıştır. Osmanlıca ve Farsça kelimelere sıkça başvurulmuştur."},
         new Book {BookId =6,Title="Simyacı",Genre="Yabancı Roman",PublishDate=DateTime.Parse("01.01.1988"), ISBN="128",CopiesAvailable=500,AuthorId=6,ImageUrl = "/images/simyaci.jpg",Summary="Bir büyük Doğu klasiği olan Mevlânâ'nın ünlü Mesnevî'sinde yer alan bir küçük öyküden yola çıkarak yazılmıştır.\r\nSimyacı, İspanya'dan kalkıp Mısır Piramitleri'nin eteklerinde hazinesini aramaya giden Endülüslü çoban Santiago'nun masalsı yaşamının \r\nfelsefi öyküsüdür. Simyacı'nın dünya çapında bu kadar satmasının sebebi belki de kılavuzculuk ve nasihat verme niteliğinin ön planda olmasıdır."},

        };

        static List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, FirstName="Fatma Aliye" , LastName="Topuz",DateOfBirth=DateTime.Parse("9.10.1862") },
            new Author {AuthorId = 2, FirstName="John",LastName="Steinbeck", DateOfBirth = DateTime.Parse("27.02.1972") },
            new Author { AuthorId = 3,FirstName="İlber",LastName="Ortaylı",DateOfBirth=DateTime.Parse("21.05.1947") },
            new Author {AuthorId = 4,FirstName="Sabahhattin", LastName="Ali",DateOfBirth=DateTime.Parse("25.02.1907") },
            new Author {AuthorId = 5,FirstName="Ahmet Hamdi",LastName="Tanpınar",DateOfBirth=DateTime.Parse("23.06.1901") },
            new Author {AuthorId = 6,FirstName="Paulo",LastName="Coelho",DateOfBirth=DateTime.Parse("24.08.1947") }
        };

        public IActionResult List()
        {
            // View model oluşturup Modelin içindeki ihityacımız kadar bilgi içeren modeli çağırıp kullandık.
            var viewModel = books.Where(x => x.IsDeleted == false)
                .Select(x => new BookListViewModel
            {
                BookId = x.BookId,
                Title=x.Title,
                Genre=x.Genre,
                PublishDate=x.PublishDate,
                CopiesAvailable=x.CopiesAvailable,
                

            }).ToList();

            // sonra view'e viewModeli eklemeyi unutma
            return View(viewModel);

           
        }

        public IActionResult Details(int id)
        {
            var bookDetail = books.FirstOrDefault(x => x.BookId == id);
            return View(bookDetail);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors =  new SelectList(authors.Where(x => x.IsDeleted == false).Select(a => new
            {
                AuthorId = a.AuthorId,
                FullName = a.FirstName + " " + a.LastName
            }), "AuthorId", "FullName");

            return View();
        }

       
        [HttpPost]
        public async Task<IActionResult> Create(BookAddViewModel formData, IFormFile ImageFile) {


            if (ModelState.IsValid)
            {
                try
                {
                    if (formData.ImageFile != null && formData.ImageFile.Length > 0)
                    {
                        var fileName = Path.GetFileName(formData.ImageFile.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await formData.ImageFile.CopyToAsync(stream);
                        }

                        // Modelin ImageUrl alanını güncelle
                        formData.ImageUrl = "/images/" + fileName;
                    }
                    else
                    {
                        ModelState.AddModelError("ImageFile", "Lütfen bir resim dosyası seçiniz.");
                        return View(formData);
                    }



                    // şimdilik static listeden dolayı kaydımız var ama diyelim ki olmadı.
                    int maxId = books.Any() ? books.Max(x => x.BookId) : 0;

                    var newBook = new Book()
                    {
                        BookId = maxId + 1,
                        Title = formData.Title,
                        Genre = formData.Genre,
                        AuthorId = formData.AuthorId,
                        PublishDate = formData.PublishDate,
                        ImageUrl = formData.ImageUrl,
                        CopiesAvailable = formData.CopiesAvailable,
                        ISBN = formData.ISBN,
                        IsDeleted = false,
                        Summary = formData.Summary
                    };

                    books.Add(newBook);

                    return RedirectToAction("List","Book");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Bir hata oluştu: " + ex.Message);
                    return View(formData);
                }
                
            }
            else {
                foreach (var state in ModelState)
                {
                    foreach (var error in state.Value.Errors)
                    {
                       // ViewBag.Errors.Add(error.ErrorMessage);
                        Console.WriteLine($"Hata: {error.ErrorMessage}");
                    }
                }
                return View(formData);
            }



         
        }

        public IActionResult Edit(int id)
        {

            // Bu id ile eşleşen liste elemanını yakala.
            var book = books.Find(x => x.BookId == id);
            ViewBag.Authors = new SelectList(authors.Where(x => x.IsDeleted == false).Select(a => new
            {
                AuthorId = a.AuthorId,
                FullName = a.FirstName + " " + a.LastName
            }), "AuthorId", "FullName");

            // Gerekli özelliklerini view'e gönder.
            var viewModel = new BookEditViewModel()
            {
                BookId = book.BookId,
                Title = book.Title,
                Genre = book.Genre,
                AuthorId = book.AuthorId,
                PublishDate = book.PublishDate,
                Summary = book.Summary,
                CopiesAvailable= book.CopiesAvailable,
                ISBN = book.ISBN

            };

          
            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(BookEditViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }

            var book = books.Find(x => x.BookId == formData.BookId);

            book.Title = formData.Title;
            book.Genre = formData.Genre;
            book.CopiesAvailable = formData.CopiesAvailable;
            book.ISBN = formData.ISBN;
            book.AuthorId = formData.AuthorId;
            book.Summary = formData.Summary;
            book.PublishDate = formData.PublishDate;




            return RedirectToAction("List");
        }
        public IActionResult Delete(int id)
        {
            var book = books.Find(x => x.BookId == id);
            book.IsDeleted=true;
            return RedirectToAction("List");
        }
    }
}
