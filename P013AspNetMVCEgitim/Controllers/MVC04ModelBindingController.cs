using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult KullaniciDetay()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = "Admin";
            kullanici.Ad = "Utku";  
            kullanici.Soyad = "Cicek";
            kullanici.Sifre = "1234";
            kullanici.EMail = "Utku@Cicek.co";
            return View(kullanici); // View içerisinde model datası olarak kullanıcı nesnesini sayfaya gönderdik.
        }
        [HttpPost]
        public IActionResult KullaniciDetay(Kullanici kullanici) // post metodunda modelden gelen nesneyi bu şekilde parantez içinde yakalayabiliyoruz.
        {
            return View(kullanici); // gelen kullanici nesnesini tekrardan ekrana yolla
        }

        public IActionResult AdresDetay()
        {
            Adres adres = new()
            {
                Sehir = "Bursa", Ilce="Mudanya", AcikAdres="Güzelyalı ..."
            };
            return View(adres);
        }

        public IActionResult UyeSayfasi()
        {
            Adres adres = new()
            {
                Sehir = "Bursa",
                Ilce = "Mudanya",
                AcikAdres = "Güzelyalı ..."
            };
            return View(adres);
        }
    }
}
