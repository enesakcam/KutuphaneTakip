using KutuphaneTakip.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneTakip.Controllers
{
    public class KitapTurController : Controller
    {
        [HttpGet]
        public IActionResult Ekle()
        {
            var db = new KutuphaneDbContext();
            ViewBag.KitapTurList = db.KitapTurler.OrderBy(x => x.KitapTurAdi).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KitapTur kitaptur)
        {
            if (ModelState.IsValid)
            {
                var db = new KutuphaneDbContext();
                db.Add(kitaptur);
                db.SaveChanges();
                return Content("Kitap Türü Eklendi.");
            }
            return View(kitaptur);
        }


       
    }
}
