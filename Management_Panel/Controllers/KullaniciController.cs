using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Management_Panel.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult KullaniciListele()
        {
            return View();
        }
        public IActionResult KullaniciLogin()
        {
            return View();
        }
    }
}
