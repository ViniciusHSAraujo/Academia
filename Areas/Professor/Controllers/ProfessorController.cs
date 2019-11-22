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

namespace Academia.Areas.Professor.Controllers {
    [ProfessorAuthorization]
    [Area("Professor")]
    public class ProfessorController : Controller {

        private readonly IProfessorRepository _professorRepository;

        public ProfessorController(IProfessorRepository professorRepository) {
            _professorRepository = professorRepository;
        }

        public IActionResult Index() {
            var professores = _professorRepository.Listar();
            return View(professores);
        }

        public IActionResult Cadastrar() {
            return View();
        }

        public IActionResult Editar(int id) {
            var professor = _professorRepository.Buscar(id);
            return View(professor);
        }

        public IActionResult TrocarSenha(int id) {
            var colaborador = _professorRepository.Buscar(id);
            return View(colaborador);
        }


        public IActionResult Detalhar(int id) {
            var professor = _professorRepository.Buscar(id);
            return View(professor);
        }
    }
}