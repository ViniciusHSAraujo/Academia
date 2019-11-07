using Academia.Libraries.Session;
using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Academia.Libraries.Login {
    public class LoginProfessor {

        private readonly Sessao _sessao;
        private readonly string key = "Login.Professor";

        public LoginProfessor(Sessao sessao) {
            _sessao = sessao;
        }

        public void Login(Professor professor) {
            var professorJson = JsonConvert.SerializeObject(professor);
            _sessao.Criar(key, professorJson);
        }

        public Professor Obter() {

            var professorJson = _sessao.Consultar(key);
            if (professorJson != null) {
                Professor professor = JsonConvert.DeserializeObject<Professor>(professorJson);
                return professor;
            }
            return null;
        }

        public void Logout() {
            _sessao.RemoverTodas();
        }
    }
}
