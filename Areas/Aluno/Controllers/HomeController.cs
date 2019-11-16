using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Academia.Areas.Aluno.Controllers {
    [Area("Aluno")]
    public class HomeController : Controller {

        private IAlunoRepository _alunoRepository;
        private ITreinoRepository _treinoRepository;
        private IHistoricoExercicioRepository _historicoExercicioRepository;

        public HomeController(IAlunoRepository alunoRepository, ITreinoRepository treinoRepository, IHistoricoExercicioRepository historicoExercicioRepository) {
            _alunoRepository = alunoRepository;
            _treinoRepository = treinoRepository;
            _historicoExercicioRepository = historicoExercicioRepository;
        }

        public IActionResult Index() {
            ViewBag.Alunos = _alunoRepository.Listar().Select(c => new SelectListItem(c.Nome, c.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Ficha(int id) {
            var treino = _treinoRepository.Buscar(id);
            var ultimoExercicio = _historicoExercicioRepository.BuscarUltimo(id);
            if (ultimoExercicio == null) {
                ViewBag.AgrupamentoDeHojeIndex = 0;
            } else {
                var proximoIndice = treino.Agrupamentos.IndexOf(ultimoExercicio.Exercicio.Agrupamento) + 1;
                //Se o próximo índice for igual à quantidade de agrupamentos, ele estará em um índice maior do que o array, portanto, volta pro zero.
                ViewBag.AgrupamentoDeHojeIndex = proximoIndice == treino.Agrupamentos.Count() ? 0 : proximoIndice;
            }
            return View(treino);
        }
    }
}