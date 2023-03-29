using P013AspNetMVCEgitim.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<UyeContext>(); // Bu sat�r� sanal veritaban� kullanabilmek i�in ekledik.

builder.Services.AddSession(); // uygulamada session kullanabilmek i�in bu sat�r� ekliyoruz.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // uygulama http isteklerini hettps ile g�venli ba�lant�ya y�nlendirmeyi desteklesin.
app.UseStaticFiles(); // uygulama statik dosyalar�(wwwroot klas�r�ndekiler) desteklesin

app.UseRouting(); // uygulama routing ile y�nlendirmeyi kullans�n.

app.UseSession(); // uygulamada session kullanabilmek i�in bu sat�r� ekliyoruz.

app.UseAuthentication(); // uygulama kullan�c� giri� sistemini aktif etsin
app.UseAuthorization();  // uygulama kullan�c� yetkilendirme(admin, user v.b) sistemini aktif etsin.

app.MapControllerRoute( // area n�n �al��mas� i�in bu route ayar�n� buraya ekledik.
            name: "admin",
            pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
          );

app.MapControllerRoute( // uygulaman�n kullanaca�� routing y�nlendirme ayar�
    name: "default", // route ad�
    pattern: "{controller=Home}/{action=Index}/{id?}"); // e�er adres �ubu�undan uygulamaya bir controller ad� ve action ad� g�nderilmezse varsay�lan olarak Home controller � ve i�indeki Index isimli action � �al��t�r�rs�n. id de�eri ise ? ile parametrik yani iste�e ba�l� belirtilmi�.

app.Run(); // uygulamay� yukar�daki ayarlar� kullanarak �al��t�r.
