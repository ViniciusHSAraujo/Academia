using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Login;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Academia.Areas.Aluno.Controllers {

    [Area("Professor")]
    public class AlunoController : Controller {

        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository) {
            _alunoRepository = alunoRepository;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Cadastrar() {
            return View();
        }

        public IActionResult Editar(int id) {
            var aluno = _alunoRepository.Buscar(id);
            return View(aluno);
        }

    }
}