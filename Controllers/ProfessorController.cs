using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academia.Libraries.Login;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Academia.Controllers {
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class ProfessorController : Controller {

        private readonly IProfessorRepository _professorRepository;
        private readonly LoginProfessor _loginProfessor;

        public ProfessorController(IProfessorRepository professorRepository, LoginProfessor loginProfessor) {
            _professorRepository = professorRepository;
            _loginProfessor = loginProfessor;
        }

        [HttpPost]
        [Route("[Action]")]
        public IActionResult Login([FromBody] Professor professor) {
            professor = _professorRepository.Login(professor.Email, professor.Senha);

            if (professor != null) {
                _loginProfessor.Login(professor);

                return Ok(JsonConvert.SerializeObject(professor));
            } else {
                Response.StatusCode = 401;
                return new ObjectResult(new { msg = $"O usuário ou a senha foi informado incorretamente." });
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Professor professor) {
            if (ModelState.IsValid) {
                _professorRepository.Cadastrar(professor);
                return Ok(new { msg = $"O professor {professor.Nome} foi cadastrado com sucesso!" });
            } else {
                return BadRequest(new { msg = $"Há algo de errado na requisição, verifique e tente novamente." });
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody]Professor professor) {
            ModelState.Remove("Senha");
            ModelState.Remove("ConfirmacaoSenha");
            if (ModelState.IsValid) {
                _professorRepository.Editar(professor);
                return Ok(new { msg = $"O cadastro do professor {professor.Nome} foi editado com sucesso!" });
            } else {
                return BadRequest(new { msg = $"Há algo de errado na requisição, verifique e tente novamente." });
            }
        }
    }
}