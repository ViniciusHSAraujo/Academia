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
            ModelState.Remove("Aluno");
            ModelState.Remove("Professor");
            ModelState.Remove("TipoExercicio");

            if (ModelState.IsValid) {

                _treinoRepository.Cadastrar(treino);
                return Ok(new { msg = $"O treino do aluno foi cadastrado com sucesso!" });
            } else {
                /**
                 * Pega os erros do Model e coloca em uma string.
                 */
                var mensagem = string.Join(" | ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage));
                return BadRequest(new { msg = $"{mensagem}" });
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]Treino treino) {
            if (ModelState.IsValid) {
                _treinoRepository.Editar(treino);
                return Ok(new { msg = $"O treino do aluno {treino.Aluno.Nome} foi editado com sucesso!" });
            } else {
                /**
                 * Pega os erros do Model e coloca em uma string.
                 */
                var mensagem = string.Join(" | ", ModelState.Values
                                            .SelectMany(v => v.Errors)
                                            .Select(e => e.ErrorMessage));
                return BadRequest(new { msg = $"{mensagem}" });
            }
        }

        [HttpDelete]
        public IActionResult Excluir([FromBody]int id) {
            try {
                _treinoRepository.Excluir(id);
                return Ok(new { msg = "Excluído com sucesso." });
            } catch (Exception) {
                return new StatusCodeResult(412); // Pré-condição falhou, pois provavelmente esse registro há relacionamentos que o impedem de ser excluído.
            }
        }

        [HttpPatch]
        public IActionResult AtivarOuInativar([FromBody]int id) {
            var situacao = _treinoRepository.AtivarOuDesativar(id);

            if (situacao) {
                return Ok(new { msg = "Treino ativado com sucesso." });
            } else {
                return Ok(new { msg = "Treino inativado com sucesso." });
            }
        }

    }
}