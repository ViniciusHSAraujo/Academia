using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Academia.Areas.Professor.Controllers {
    [Area("Professor")]
    public class TreinoController : Controller {

        private readonly ITreinoRepository _treinoRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IProfessorRepository _professorRepository;
        private readonly ITipoDeExercicioRepository _tipoDeExercicioRepository;

        public TreinoController(ITreinoRepository treinoRepository, IAlunoRepository alunoRepository, IProfessorRepository professorRepository, ITipoDeExercicioRepository tipoDeExercicioRepository) {
            _treinoRepository = treinoRepository;
            _alunoRepository = alunoRepository;
            _professorRepository = professorRepository;
            _tipoDeExercicioRepository = tipoDeExercicioRepository;
        }
        public IActionResult Index() {

            var treinos = _treinoRepository.Listar();
            return View(treinos);
        }
        public IActionResult Cadastrar() {
            ViewBag.Alunos = _alunoRepository.Listar().Select(c => new SelectListItem(c.Nome, c.Id.ToString()));
            ViewBag.Professores = _professorRepository.Listar().Select(c => new SelectListItem(c.Nome, c.Id.ToString()));
            ViewBag.TiposDeExercicios = _tipoDeExercicioRepository.Listar().Select(c => new SelectListItem(c.Nome, c.Id.ToString()));
            return View();
        }

        public IActionResult Editar(int id) {
            var treino = _treinoRepository.Buscar(id);
            return View(treino);
        }

        public IActionResult Detalhar(int id) {
            var treino = _treinoRepository.Buscar(id);
            return View(treino);
        }
    }
}