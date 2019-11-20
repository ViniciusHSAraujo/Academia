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
    public class TipoDeExercicioController : Controller {

        private readonly ITipoDeExercicioRepository _tipoDeExercicioRepository;

        public TipoDeExercicioController(ITipoDeExercicioRepository tipoDeExercicioRepository) {
            _tipoDeExercicioRepository = tipoDeExercicioRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody]TipoExercicio tipoExercicio) {
            if (ModelState.IsValid) {
                _tipoDeExercicioRepository.Cadastrar(tipoExercicio);
                return Ok(new { msg = $"O tipo de exercício {tipoExercicio.Nome} foi cadastrado com sucesso!" });
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

        [HttpPatch]
        public IActionResult Put([FromBody]TipoExercicio tipoExercicio) {
            if (ModelState.IsValid) {
                _tipoDeExercicioRepository.Editar(tipoExercicio);
                return Ok(new { msg = $"O cadastro do tipo de exercício {tipoExercicio.Nome} foi editado com sucesso!" });
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