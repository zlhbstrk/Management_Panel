using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Management_Panel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Management_Panel.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult UrunListele()
        {
            var urun = new List<Urun>()
            {
                new Urun(){id=1, name="Kuru İncir Reçeli", price=20.9, image="local/img", isStock=true, quantity=5, status=true},
                new Urun(){id=2, name="Ceviz Reçeli", price=29.9, image="local/img", isStock=true, quantity=2, status=true},
                new Urun(){id=3, name="Domates Salçası", price=15.0, image="local/img", isStock=false, quantity=0, status=true},
                new Urun(){id=4, name="Biber Salçası", price=30.9, image="local/img", isStock=true, quantity=10, status=false}
            };
            return View(urun);
        }
        
        [HttpGet]
        public IActionResult UrunEkle()
        {
            @ViewBag.Sonuc = "";
            return View();
        }

        [HttpPost]
        public IActionResult UrunEkle(Urun eklenenUrun)
        {
            //eklenenUrun nesnesi servise gönderilir.
            ViewBag.Sonuc = eklenenUrun.name;
            return View();
        }

        public IActionResult UrunSil(int id)
        {
            //id servisteki ürün silme fonksiyonuna gönderilir.
            bool sonuc = true;

            if (sonuc)
            {

            }
            else
            {

            }



            return RedirectToAction("UrunListele");
        }

        public IActionResult AskiyaAl(int id)
        {
            return RedirectToAction("UrunListele");
        }

        public IActionResult UrunGuncelle(int id)
        {
            //id ile ürün bilgileri servise gönderilir
            //apiden model alınır ve view gönderilir
            
            return View(new Urun() { id = 1, name = "Kuru İncir Reçeli", price = 20.9, image = "local/img", isStock = true, quantity = 5, status = true });
        }
    }
}
