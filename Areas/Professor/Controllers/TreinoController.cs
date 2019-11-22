using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Filters;
using Academia.Models.ViewModel;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Academia.Areas.Professor.Controllers {
    [ProfessorAuthorization]
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
        public IActionResult Index(int? pagina, string pesquisa) {

            var treinos = _treinoRepository.Listar(pagina, pesquisa);
            return View(treinos);
        }

        public IActionResult Cadastrar() {
            ViewBag.Alunos = _alunoRepository.Listar().Where(a => a.Status).Select(a => new SelectListItem(a.Nome, a.Id.ToString()));
            ViewBag.Professores = _professorRepository.Listar().Where(p => p.Admissao <= DateTime.Now.Date && ((p.Demissao.HasValue && p.Demissao.Value > DateTime.Now.Date) || !p.Demissao.HasValue)).Select(p => new SelectListItem(p.Nome, p.Id.ToString()));
            ViewBag.TiposDeExercicios = _tipoDeExercicioRepository.Listar().Where(t => t.Situacao).Select(c => new SelectListItem(c.Nome, c.Id.ToString()));
            return View();
        }

        public IActionResult Editar(int id) {
            //TODO - Fazer a edição dos treinos.
            return View();
        }

        public IActionResult Detalhar(int id) {
            var treino = _treinoRepository.Buscar(id);
            return View(treino);
        }
    }
}