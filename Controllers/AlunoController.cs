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
    public class AlunoController : ControllerBase {

        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IAlunoRepository alunoRepository) {
            _alunoRepository = alunoRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody]Aluno aluno) {
            if (ModelState.IsValid) {
                _alunoRepository.Cadastrar(aluno);
                return Ok(new { msg = $"O aluno {aluno.Nome} foi cadastrado com sucesso!" });
            } else {
                return BadRequest(new { msg = $"Há algo de errado na requisição, verifique e tente novamente." });
            }
        }

        [HttpPatch]
        public IActionResult Editar([FromBody]Aluno aluno) {
            if (ModelState.IsValid) {
                _alunoRepository.Editar(aluno);
                return Ok(new { msg = $"O cadastro do aluno {aluno.Nome} foi editado com sucesso!" });
            } else {
                return BadRequest(new { msg = $"Há algo de errado na requisição, verifique e tente novamente." });
            }
        }
    }
}