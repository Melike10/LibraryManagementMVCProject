using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Features;
 void ConfigureServices(IServiceCollection services)
{
    services.Configure<FormOptions>(options =>
    {
        options.MultipartBodyLengthLimit = 104857600; // Maksimum dosya boyutu 100 MB
    });
}

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options=>
{
    options.LoginPath = new PathString("/");
    options.LogoutPath = new PathString("/");
    options.AccessDeniedPath = new PathString("/");

});
var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.UseAuthentication();
app.Run();
