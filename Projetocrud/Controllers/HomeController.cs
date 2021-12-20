using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projetocrud.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projetocrud.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Destino()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult contato()
        {
            return View();
        }

        public IActionResult pagamento ()
        {
            return View();
        }





    }
}
