﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Academia.Areas.Aluno.Controllers {
    [Area("Aluno")]
    [Route("{Area}/{Action=index}/{id?}")]
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
            ViewBag.Alunos = _alunoRepository.Listar().Where(a => a.Status).Select(c => new SelectListItem($"{c.Id.ToString()} - {c.Nome}", c.Id.ToString()));
            return View();
        }

        [HttpPost]
        public IActionResult Ficha(int id) {
            var treino = _treinoRepository.BuscarUltimoTreinoDoAluno(id);
            var ultimoExercicio = _historicoExercicioRepository.BuscarUltimoExercicioDoAluno(id);



            if (ultimoExercicio == null) {
                ViewBag.AgrupamentoDeHojeIndex = 0;
            } else if (treino != ultimoExercicio.Exercicio.Agrupamento.Treino) {
                ViewBag.AgrupamentoDeHojeIndex = 0;
            } else {
                var proximoIndice = treino.Agrupamentos.IndexOf(ultimoExercicio.Exercicio.Agrupamento) + 1;
                //Se o próximo índice for igual à quantidade de agrupamentos, ele estará em um índice maior do que o array, portanto, volta pro zero.
                ViewBag.AgrupamentoDeHojeIndex = proximoIndice == treino.Agrupamentos.Count() ? 0 : proximoIndice;
            }
            return View(treino);
        }

        public IActionResult LinhaDoTempo(int id) {
            var historicos = _historicoExercicioRepository.ListarHistoricosDoAluno(id);
            return View(historicos);
        }
    }
}