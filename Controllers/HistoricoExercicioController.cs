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
    public class HistoricoExercicioController : Controller {

        private readonly IHistoricoExercicioRepository _historicoExercicioRepository;

        public HistoricoExercicioController(IHistoricoExercicioRepository historicoExercicioRepository) {
            _historicoExercicioRepository = historicoExercicioRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody]IEnumerable<HistoricoExercicio> historicosExercicios) {
            foreach (var historico in historicosExercicios) {
                //Define a data como a data do recebimento da requisição.
                historico.Data = DateTime.Now;
            }

            if (ModelState.IsValid) {
                _historicoExercicioRepository.Cadastrar(historicosExercicios);
                return Ok(new { msg = $"O histórico de seu treino foi cadastrado com sucesso!" });
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
    }
}