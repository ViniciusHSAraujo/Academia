using Academia.Libraries.Login;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Libraries.Filters {
    public class AlunoAuthorizationAttribute : Attribute, IAuthorizationFilter {

        private LoginAluno _loginAluno;

        public void OnAuthorization(AuthorizationFilterContext context) {
            _loginAluno = context.HttpContext.RequestServices.GetService(typeof(LoginAluno)) as LoginAluno;
            Aluno alunoLogado = _loginAluno.Obter();

            if (alunoLogado == null) {
                context.Result = new RedirectToActionResult("login", "home", null);
            }
        }
    }
}
