using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Academia.Controllers {
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class AlunoController : ControllerBase {

        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository) {
            _alunoRepository = alunoRepository;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Aluno aluno) {
            if (ModelState.IsValid) {
                _alunoRepository.Cadastrar(aluno);
                return Ok(new { msg = $"O aluno {aluno.Nome} foi cadastrado com sucesso!" });
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
        public IActionResult Put([FromBody]Aluno aluno) {
            ModelState.Remove("Senha");
            ModelState.Remove("ConfirmacaoSenha");
            if (ModelState.IsValid) {
                _alunoRepository.Editar(aluno);
                return Ok(new { msg = $"O cadastro do aluno {aluno.Nome} foi editado com sucesso!" });
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
                _alunoRepository.Excluir(id);
                return Ok(new { msg = "Excluído com sucesso."});
            } catch (Exception) {
                return new StatusCodeResult(412); // Pré-condição falhou, pois provavelmente esse registro há relacionamentos que o impedem de ser excluído.
            }
        }

    }
}