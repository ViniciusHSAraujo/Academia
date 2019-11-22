using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Filters;
using Academia.Libraries.Login;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Academia.Areas.Aluno.Controllers {

    [ProfessorAuthorization]
    [Area("Professor")]
    public class AlunoController : Controller {

        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository) {
            _alunoRepository = alunoRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa) {
            var alunos = _alunoRepository.Listar(pagina, pesquisa);
            return View(alunos);
        }

        public IActionResult Cadastrar() {
            return View();
        }

        public IActionResult Editar(int id) {
            var aluno = _alunoRepository.Buscar(id);
            return View(aluno);
        }

        public IActionResult Detalhar(int id) {
            var aluno = _alunoRepository.Buscar(id);
            return View(aluno);
        }
    }
}