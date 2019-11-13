using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Controllers {
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class TreinoController : Controller {

        private readonly ITreinoRepository _treinoRepository;

        public TreinoController(ITreinoRepository treinoRepository) {
            _treinoRepository = treinoRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Treino treino) {
            if (ModelState.IsValid) {

                _treinoRepository.Cadastrar(treino);
                return Ok(new { msg = $"O treino do aluno foi cadastrado com sucesso!" });
            } else {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]Treino treino) {
            if (ModelState.IsValid) {
                _treinoRepository.Editar(treino);
                return Ok(new { msg = $"O treino do aluno {treino.Aluno.Nome} foi editado com sucesso!" });
            } else {
                return BadRequest(new { msg = $"Há algo de errado na requisição, verifique e tente novamente." });
            }
        }
    }
}