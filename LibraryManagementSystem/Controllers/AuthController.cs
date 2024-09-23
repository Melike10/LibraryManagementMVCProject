using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LibraryManagementSystem.Controllers
{
    public class AuthController : Controller
    {
        public static List<User> users = new List<User>()
        {
            new User {UserId= 1 , FullName="Melike Göz",Password=".",PhoneNumber="01234567890" ,Email = "mdg@gmail.com"}
        };

        private IDataProtector _dataProtector;

        public AuthController(IDataProtectionProvider dataProtectionProvider)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("security");
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(SignUpViewModel formData)
        {
            if (!ModelState.IsValid) { return View(formData); }

            var user = users.FirstOrDefault(x=> x.Email.ToLower() == formData.Email.ToLower());
            if (user is not null) {
                ViewBag.Error = "Kullanıcı Mevcut";
                return View(formData); 
            }

            var newUser = new User
            {
                UserId = users.Max(x => x.UserId),
                Email = formData.Email,
                FullName = formData.FullName,
                PhoneNumber = formData.PhoneNumber,
                Password = _dataProtector.Protect(formData.Password)
            };
            users.Add(newUser);
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginViewModel formData)
        {
            var user = users.FirstOrDefault(x=> x.Email.ToLower() == formData.Email.ToLower());

            if (user is null) {
                ViewBag.Error("Kullanıcı adı veya şifre hatalı!");
                return View(formData);
            }

            if (_dataProtector.Unprotect(user.Password) != formData.Password) {
                ViewBag.Error("Kullanıcı adı veya şifre hatalı!");
                return View(formData);
            }

            var claims = new List<Claim>();
            claims.Add(new Claim("userId",user.UserId.ToString()));
            claims.Add(new Claim("email",user.Email.ToString()));
            claims.Add(new Claim("fullName",user.FullName));

            var claimIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
            //claims içersindeki verilerle bir oturum açılacağı için identy nesnesi tanımlandı.

            var authPropersties = new AuthenticationProperties {
            AllowRefresh = true,// yenilenebilir oturum
            ExpiresUtc = new DateTimeOffset(DateTime.Now.AddHours(48)),// oturum açıldıktan sonra 48 saat açık kalır
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), authPropersties);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
