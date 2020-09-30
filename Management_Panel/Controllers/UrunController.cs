using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Management_Panel.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult UrunListele()
        {
            return View();
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
