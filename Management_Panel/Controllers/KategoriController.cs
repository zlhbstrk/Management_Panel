using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Management_Panel.Models;

namespace Management_Panel.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult KategoriListele()
        {
            var kategori = new List<Kategori>()
            {
                new Kategori(){id=1, name="Reçel", refName=""},
                new Kategori(){id=2, name="Tarhana", refName="Unlu Mamüller"},
                new Kategori(){id=3, name="Salça", refName=""},
            };

            return View(kategori);
        }

        [HttpGet]
        public IActionResult KategoriEkle()
        {
            @ViewBag.S = "";
            return View();
        }

        [HttpPost]
        public IActionResult KategoriEkle(Kategori eklenenKategori)
        {
            //eklenenKategori nesnesi servise gönderilir.
            ViewBag.S = eklenenKategori.name + " Kategori eklendi.";
            return View();
        }
    }
}
