using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Filters;
using Academia.Libraries.Login;
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
        private LoginProfessor _loginProfessor;

        public HomeController(IProfessorRepository professorRepository, IAlunoRepository alunoRepository, ITreinoRepository treinoRepository, IHistoricoExercicioRepository historicoExercicioRepository, LoginProfessor loginProfessor) {
            _professorRepository = professorRepository;
            _alunoRepository = alunoRepository;
            _treinoRepository = treinoRepository;
            _historicoExercicioRepository = historicoExercicioRepository;
            _loginProfessor = loginProfessor;
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

        public IActionResult MinhaConta() {
            var professor = _loginProfessor.Obter();
            return View(professor);
        }

    }
}