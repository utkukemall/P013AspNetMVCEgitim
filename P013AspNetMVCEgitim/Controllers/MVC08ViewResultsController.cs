﻿using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC08ViewResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yonlendir(string arananDeger)
        {
            //return Redirect("/Home"); // Bu action tetiklendiğinde uygulama anasayfaya gitsin.
            //return Redirect($"/Home?kelime={arananDeger}"); // Burada soru işaretinden (?) sonraki kısım querystring yöntemiyle adres çubuğu üzerinden veri yollamak için kullanılır.
            return Redirect("https://getbootstrap.com/"); // Bu şekilde harici bir siteye de yönlendirme yapabiliyoruz.
        }

        public IActionResult ActionaYonlendir()
        {
            //return RedirectToAction("Index"); // metot çalıştığında aynı controllerdaki bir actiona yönlendirmemizi sağlar.
            return RedirectToAction("Index","Home"); // metot çalıştığında farklı bir controller dakii actiona bu şekilde yönlendirebiliriz.
        }

        public RedirectToRouteResult RouteYonlendir() // IActionResult da yapsak olurdu
        {
            return RedirectToRoute("Default", new { controller="Home", action="Index", id=18}); // Metot çalıştığı zaman route sistemiyle yönlendirme yapmamızı sağlar.
        }
        public PartialViewResult KategorileriGetirPartial() // IActionResult da yapsak olurdu
        {
            return PartialView("_KategorilerPartial");
        }
        public IActionResult XmlContentResult()
        {
            var xml = @"
                    <Kullanicilar>
                        <Kullanici>
                            <Adi>
                                Murat
                            </Adi>
                            <Soyadi>
                                Yılmaz
                            </Soyadi>
                        </Kullanici>
                        <Kullanici>
                            <Adi>
                                Utku
                            </Adi>
                            <Soyadi>
                                Çiçek
                            </Soyadi>
                        </Kullanici>
                    </Kullanicilar>
            ";
            return Content(xml,"application/xml"); // geriye xml içeriğini döndürdük
        }
        public IActionResult JsonDondur()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Utku", Soyad="Çiçek", KullaniciAdi="utkukemall"
            };
            return Json(kullanici);
        }
    }
}
