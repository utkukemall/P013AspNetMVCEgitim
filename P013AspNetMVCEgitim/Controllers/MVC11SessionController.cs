using Microsoft.AspNetCore.Mvc;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC11SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SessionOluştur(string kullaniciAdi, string sifre)
        {
            if (kullaniciAdi == "Admin" && sifre == "123")
            {

            }
            return View();
        }
    }
}
