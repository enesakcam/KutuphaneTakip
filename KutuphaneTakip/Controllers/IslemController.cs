using KutuphaneTakip.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneTakip.Controllers
{
    public class IslemController : Controller
    {
        [HttpGet]
        public IActionResult Ekle()
        {
            var db = new KutuphaneDbContext();
            ViewBag.Ogreciler = db.Ogrenciler.Select(x => new { x.OgrenciId, x.OgrenciAdSoyad }).
            ToList();
            ViewBag.Kitaplar = db.Kitaplar.Select(x=>new { x.KitapId, x.KitapAdi }).ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Islem model)
        {
            var db = new KutuphaneDbContext();
            db.Add(model);
            db.SaveChanges();
            return Content("İşlem Başarıyla Gerçekleşti.");
        }
    }
}
