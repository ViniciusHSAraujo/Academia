using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Filters;
using Academia.Models.ViewModel;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Areas.Professor.Controllers {
    [ProfessorAuthorization]
    [Area("Professor")]
    public class HomeController : Controller {

        private IProfessorRepository _professorRepository;
        private IAlunoRepository _alunoRepository;
        private ITreinoRepository _treinoRepository;
        private IHistoricoExercicioRepository _historicoExercicioRepository;

        public HomeController(IProfessorRepository professorRepository, IAlunoRepository alunoRepository, ITreinoRepository treinoRepository, IHistoricoExercicioRepository historicoExercicioRepository) {
            _professorRepository = professorRepository;
            _alunoRepository = alunoRepository;
            _treinoRepository = treinoRepository;
            _historicoExercicioRepository = historicoExercicioRepository;
        }
        public IActionResult Index() {

            var alunos = _alunoRepository.ContarAlunosAtivos();
            var professores = _professorRepository.ContarProfessoresAtivos();
            var treinos = _treinoRepository.ContarTreinosAtivos();
            var historicos = _historicoExercicioRepository.ContarTreinosExecutados();

            DashboardProfessorViewModel dashboardProfessorViewModel = new DashboardProfessorViewModel() {
                QuantidadeAlunosAtivos = alunos,
                QuantidadeProfessoresAtivos = professores,
                QuantidadeFichasAtivas = treinos,
                QuantidadeTreinosConcluidos = historicos
            };
            return View(dashboardProfessorViewModel);
        }

        public IActionResult Cadastrar() {
            return View();
        }
    }
}