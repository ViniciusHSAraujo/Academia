using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Academia.Models;
using Academia.Libraries.Login;

namespace Academia.Controllers {
    public class HomeController : Controller {

        private readonly LoginProfessor _loginProfessor;

        public HomeController(LoginProfessor loginProfessor) {
            _loginProfessor = loginProfessor;
        }
        public IActionResult Index() {
            return View();
        }

        public IActionResult Login() {
            return View();
        }

        public IActionResult Logout() {
            _loginProfessor.Logout();
            return RedirectToAction("Index", null);
        }
    }
}
