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
                new Urun(){id=1, name="Kuru İncir Reçeli", description="Doğal yollarla kurutulmuş bahçe incirlerimiz odun ateşinde kaynatılarak yapılmıştır",
                            price=20.9, image="local/img", isStock=true, quantity=5},
                new Urun(){id=2, name="Ceviz Reçeli", description="Bahçe cevizlerimiz odun ateşinde kaynatılarak yapılmıştır",
                            price=29.9, image="local/img", isStock=true, quantity=2},
                new Urun(){id=3, name="Domates Salçası", description="Bahçe domateslerimiz odun ateşinde kaynatılarak yapılmıştır",
                            price=15.0, image="local/img", isStock=false, quantity=0},
                new Urun(){id=4, name="Biber Salçası", description="Bahçe biberlerimiz odun ateşinde kaynatılarak yapılmıştır",
                            price=30.9, image="local/img", isStock=true, quantity=10}
            };
            return View(urun);
        }
        public IActionResult UrunEkle()
        {
            return View();
        }
        public IActionResult UrunSil()
        {
            return View();
        }
        public IActionResult AskiyaAl()
        {
            return View();
        }
        public IActionResult UrunGuncelle()
        {
            return View();
        }
    }
}
