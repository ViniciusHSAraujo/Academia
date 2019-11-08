﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Areas.Professor.Controllers {
    [Area("Professor")]
    public class TipoDeExercicioController : Controller {

        private readonly ITipoDeExercicioRepository _tipoDeExercicioRepository;

        public TipoDeExercicioController(ITipoDeExercicioRepository tipoDeExercicioRepository) {
            _tipoDeExercicioRepository = tipoDeExercicioRepository;
        }

        public IActionResult Index() {
            var tipoDeExercicio = _tipoDeExercicioRepository.Listar();
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