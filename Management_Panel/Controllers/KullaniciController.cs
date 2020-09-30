using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Management_Panel.Models;

namespace Management_Panel.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult KullaniciListele()
        {
            var kullanici = new List<Kullanici>()
            {
                new Kullanici(){id=1, name="Harun DEMİR", mail="harundemirp@gmail.com", telephone="05555555555", country="Türkiye", province="Ankara", address="Koru/Ankara"},
                new Kullanici(){id=2, name="Zeliha BAŞTÜRK", mail="zlhbstrk@hotmail.com", telephone="05444444444", country="Türkiye", province="Ankara", address="Sincan/Ankara"},
                new Kullanici(){id=3, name="Rukiye YILMAZ", mail="r@hotmail.com", telephone="05333333333", country="Türkiye", province="Karabük", address="Merkez/Karabük"}
            };

            return View(kullanici);
        }
        public IActionResult KullaniciLogin()
        {
            return View();
        }
    }
}
