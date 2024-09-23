using Microsoft.AspNetCore.Mvc;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Models;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {

        static List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, FirstName="Fatma Aliye" , LastName="Topuz",DateOfBirth=DateTime.Parse("9.10.1862") },
            new Author {AuthorId = 2, FirstName="John",LastName="Steinbeck", DateOfBirth = DateTime.Parse("27.02.1972") },
            new Author { AuthorId = 3,FirstName="İlber",LastName="Ortaylı",DateOfBirth=DateTime.Parse("21.05.1947") },
            new Author {AuthorId = 4,FirstName="Sabahhattin", LastName="Ali",DateOfBirth=DateTime.Parse("25.02.1907") },
            new Author {AuthorId = 5,FirstName="Ahmet Hamdi",LastName="Tanpınar",DateOfBirth=DateTime.Parse("23.06.1901") },
            new Author {AuthorId = 6,FirstName="Paulo",LastName="Coelho",DateOfBirth=DateTime.Parse("24.08.1947") }
        };
        public List<Book> books = new List<Book>(){
        new Book {BookId =1,Title="Refet",Genre="Yerli Roman",PublishDate=DateTime.Parse("01.01.1896"), ISBN="123",CopiesAvailable=500,AuthorId=1,ImageUrl = "/images/refet.jpg",Summary = "Türk edebiyatının ilk kadın romancısı Fatma Aliye'nin 1896 yılında yayımladığı, döneminin çok ilerisinde bir roman olan Refet, \r\nhenüz kadının adının olmadığı bir toplumda kadının öğrenim ve çalışma haklarını, sosyal hayattaki konumunun artırılmasını savunan güçlü bir eser."},
        new Book {BookId =2,Title="Fareler ve İnsanlar",Genre="Yabancı Roman",PublishDate=DateTime.Parse("01.01.1937"), ISBN="124",CopiesAvailable=300,AuthorId=2 ,ImageUrl = "/images/farelerveinsanlar.jpg",Summary="İlk defa 1937 yılında yayınlanan eser, iki gezgin çiftlik işçisi olan George Milton ve \r\nLennie Small'un büyük bunalım sırasında Kaliforniya'da yaşadıkları trajik olayları anlatır."},
        new Book {BookId =3,Title="Bir Ömür Nasıl Yaşanır",Genre="Deneme",PublishDate=DateTime.Parse("13.02.2019"), ISBN="125",CopiesAvailable=150,AuthorId=3 ,ImageUrl = "/images/biromurnasil.jpg",Summary ="İlber Ortaylı, yediden yetmişe herkesin faydalanacağı, bilge şahsiyetinden ve yaşam tecrübesinden süzülen tavsiyelerden oluşan bir eserle karşımızda. İlber Hoca bu kitapta, bir insanın, çocukluktan itibaren hayatın hemen her alanında ihtiyaç duyacağı çözümleri nasıl bulabileceğini örnekler vererek anlatıyor. “Herkes kendi talihinin mimarıdır” sözünü hatırlatarak, \r\nkendi yolunu çizmenin ne anlama geldiğini tüm kritik noktalarıyla yorumluyor."},
        new Book {BookId =4,Title="Kürk Mantolu Madonna",Genre="Yerli Roman",PublishDate=DateTime.Parse("18.12.1943"), ISBN="126",CopiesAvailable=300,AuthorId=4,ImageUrl = "/images/kurkmantolumadonna.jpg",Summary="Kitap, Maria Puder adında bir kadınla tanışana kadar amaçsız bir hayat yaşayan Raif'in hikayesini anlatıyor. \r\nBaşlangıçta kitap birçok eleştirmen tarafından \"sadece başka bir aşk hikayesi\" olduğu için eleştirildi,\r\n ancak zamanla en çok satanlar arasına girdi ve genellikle Türk edebiyatının en iyi eserleri arasında anılır."},
         new Book {BookId =5,Title="Saatleri Ayarlama Enstitüsü",Genre="Yerli Roman",PublishDate=DateTime.Parse("01.01.1954"), ISBN="127",CopiesAvailable=300,AuthorId=5,ImageUrl = "/images/saatleriayarlamaenstitüsü.jpg",Summary = "Saatleri Ayarlama Enstitüsü, içeriğini ve konusunu romanın karakterlerinden Nuri Efendi (saat ustası), \r\nMübarek (İngiliz yapımı, ayaklı ve yaşlı bir duvar saati), Halit Ayarcı ve saat-zaman-insan ilişkilerinden almaktadır.\r\nYapıt çocukluğu II. Abdülhamit döneminde geçen, Meşrutiyet ve Cumhuriyet dönemlerinde de yaşayan \r\nHayri İrdal'ın anıları şeklinde kurgulanmıştır. Osmanlıca ve Farsça kelimelere sıkça başvurulmuştur."},
         new Book {BookId =6,Title="Simyacı",Genre="Yabancı Roman",PublishDate=DateTime.Parse("01.01.1988"), ISBN="128",CopiesAvailable=500,AuthorId=6,ImageUrl = "/images/simyaci.jpg",Summary="Bir büyük Doğu klasiği olan Mevlânâ'nın ünlü Mesnevî'sinde yer alan bir küçük öyküden yola çıkarak yazılmıştır.\r\nSimyacı, İspanya'dan kalkıp Mısır Piramitleri'nin eteklerinde hazinesini aramaya giden Endülüslü çoban Santiago'nun masalsı yaşamının \r\nfelsefi öyküsüdür. Simyacı'nın dünya çapında bu kadar satmasının sebebi belki de kılavuzculuk ve nasihat verme niteliğinin ön planda olmasıdır."},

        };

        public IActionResult List()
        {
            var viewModel = authors.Where(x=> x.IsDeleted== false).Select(
                x=> new AuthorListViewModel
                {
                  AuthorId = x.AuthorId,
                  FirstName = x.FirstName,
                  LastName = x.LastName
                }).ToList();  
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var author = authors.FirstOrDefault(x => x.IsDeleted == false && x.AuthorId == id);
            if (author == null) // Yazar bulunamazsa
            {
                return NotFound(); // 404 hata sayfası
            }

            var bookTitles = books
                .Where(book => book.AuthorId == author.AuthorId)
                .Select(book => book.Title)
                .ToList();

            var viewModel = new AuthorDetailsViewModel
            {
                AuthorName = $"{author.FirstName} {author.LastName}",
                Books = bookTitles
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AuthorAddViewModel formData)
        {

            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            int maxId= authors.Max(x=> x.AuthorId);
            var newAuthor = new Author()
            {
                AuthorId = maxId + 1,
                FirstName= formData.FirstName,
                LastName= formData.LastName,
                DateOfBirth= formData.DateOfBirth
            };

            authors.Add(newAuthor);

            return RedirectToAction("List");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = authors.Find(x=> x.AuthorId == id);
            var viewModel = new AuthorEditViewModel {
             AuthorId =author.AuthorId, 
             FirstName=author.FirstName,
             LastName = author.LastName,
             DateOfBirth= author.DateOfBirth
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(AuthorEditViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }

            var bookEdit = authors.Find(x => x.AuthorId == formData.AuthorId);
            bookEdit.FirstName = formData.FirstName;
            bookEdit.LastName = formData.LastName;
            bookEdit.DateOfBirth = formData.DateOfBirth;

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var author = authors.Find(x => x.AuthorId == id);
            author.IsDeleted = true;
            return RedirectToAction("List");
        }
    }
}
