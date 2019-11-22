using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Filters;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Areas.Professor.Controllers {
    [ProfessorAuthorization]
    [Area("Professor")]
    public class TipoDeExercicioController : Controller {

        private readonly ITipoDeExercicioRepository _tipoDeExercicioRepository;

        public TipoDeExercicioController(ITipoDeExercicioRepository tipoDeExercicioRepository) {
            _tipoDeExercicioRepository = tipoDeExercicioRepository;
        }

        public IActionResult Index(int? pagina, string pesquisa) {
            var tipoDeExercicio = _tipoDeExercicioRepository.Listar(pagina, pesquisa);
            return View(tipoDeExercicio);
        }

        public IActionResult Cadastrar() {
            return View();
        }

        public IActionResult Editar(int id) {
            var tipoDeExercicio = _tipoDeExercicioRepository.Buscar(id);
            return View(tipoDeExercicio);
        }
    }
}