﻿using Microsoft.AspNetCore.Mvc;
using P013AspNetMVCEgitim.Models;

namespace P013AspNetMVCEgitim.Controllers
{
    public class MVC05ModelValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UyeListesi()
        {
            return View();
        }
        public IActionResult YeniUye()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniUye(Uye uye)
        {
            if (ModelState.IsValid) // eğer parantez içerisinde gönderilen üye nesnesi validasyon kurallarına uygunsa 
            {
                // Bu bloktaki kodları çalıştır. Mesela gönderilen üye nesnesini veritabanına ekle.
                
            }
            else
            {
                ModelState.AddModelError("", "Lütfen Zorunlu Alanları Doldurunuz!"); 
            }
            return View();
        }
    }
}
