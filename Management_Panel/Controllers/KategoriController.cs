using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Management_Panel.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult KategoriListele()
        {
            return View();
        }
        public IActionResult KategoriEkle()
        {
            return View();
        }
    }
}
