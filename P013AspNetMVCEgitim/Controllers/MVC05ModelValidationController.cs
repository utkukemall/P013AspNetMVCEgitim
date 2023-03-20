using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        UyeContext context = new UyeContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            var model = context.Uyes.ToList(); // Context içinde yer alan Uyes tablosundaki verileri listele ve model isimli değişkene aktar.
            return View(model); // View sayfasına model bu şekilde gönderiliyor. 
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // eğer parantez içerisinde gönderilen uye nesnesi validasyon kurallarına uygunsa 
            {
                // Bu bloktaki kodları çalıştır. Mesela gönderilen uye nesnesini veritabanına ekle.
                context.Uyes.Add(uye); // View'dan gönderilen uye nesnesini context üzerindeki Uyes tablosuna ekle
                context.SaveChanges(); // üst satırdaki ekleme işlemini kaydet.
                return RedirectToAction("UyeListesi");
            } 
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!"); 
            }
            return View();
        }
    }
}
