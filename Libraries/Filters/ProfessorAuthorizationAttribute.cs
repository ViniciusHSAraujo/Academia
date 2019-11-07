using Academia.Libraries.Login;
using Academia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Libraries.Filters {
    public class ProfessorAuthorizationAttribute : Attribute, IAuthorizationFilter {

        private LoginProfessor _loginProfessor;

        public void OnAuthorization(AuthorizationFilterContext context) {
            _loginProfessor = context.HttpContext.RequestServices.GetService(typeof(LoginProfessor)) as LoginProfessor;
            Professor professorLogado = _loginProfessor.Obter();

            if (professorLogado == null) {
                context.Result = new RedirectToActionResult("login", "home", null);
            }
        }
    }
}
