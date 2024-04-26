using KutuphaneTakip.Models;
using Microsoft.AspNetCore.Mvc;

namespace KutuphaneTakip.Controllers
{
    public class OgrenciController : Controller
    {
        KutuphaneDbContext db = new KutuphaneDbContext();
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(Ogrenci ogrenci)
        {
            if (ModelState.IsValid)
            {
                db.Ogrenciler.Add(ogrenci);
                db.SaveChanges();
                return RedirectToAction("Liste");
            }
            return View(ogrenci);
        }

        [HttpGet]
        public IActionResult Liste()
        {
            var ogrenciler = db.Ogrenciler.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public IActionResult AdresEkle(int id)
        {
            var ogrenci = db.Ogrenciler.Find(id);
            ViewBag.Ogrenci = ogrenci;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdresEkle(Adres adres)
        {
            db.Adresler.Add(adres);
            db.SaveChanges();
            return RedirectToAction("Liste");
        }
    }
}
