using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Areas.Professor.Controllers {
    [Area("Professor")]
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Cadastrar() {
            return View();
        }
    }
}