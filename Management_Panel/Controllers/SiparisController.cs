using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Management_Panel.Models;

namespace Management_Panel.Controllers
{
    public class SiparisController : Controller
    {
        public IActionResult SiparisListele()
        {
            var siparis = new List<Siparis>()
            {
                new Siparis(){id=1, userId=1, name="Ali", mail="ali@gmail.com", telephone="5555555555", address="Çankaya/ANKARA",
                    country="TÜRKİYE", province="Ankara", price=45.25, date=new DateTime().Date, note="Teşekkürler." },
                new Siparis(){id=2, userId=1, name="Ali", mail="ali@gmail.com", telephone="5555555555", address="Çankaya/ANKARA",
                    country="TÜRKİYE", province="Ankara", price=120.90, date=new DateTime().Date, note="Ürünleriniz çok lezzetli." }
            };

            return View(siparis);
        }
        public IActionResult SiparisDetay()
        {
            return View();
        }
        public IActionResult SiparisOnayla()
        {
            return View();
        }
        public IActionResult KargoBilgisiGir()
        {
            return View();
        }
    }
}
