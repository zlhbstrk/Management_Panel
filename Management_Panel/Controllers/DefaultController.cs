using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Management_Panel.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {

            //sipariş ürün kullanıcı sayıları db den apiden glecek 

            return View();
        }
    }
}
