using Academia.Libraries.Session;
using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Academia.Libraries.Login {
    public class LoginAluno {

        private readonly Sessao _sessao;
        private readonly string key = "Login.Aluno";

        public LoginAluno(Sessao sessao) {
            _sessao = sessao;
        }

        public void Login(Aluno aluno) {
            var alunoJson = JsonConvert.SerializeObject(aluno);
            _sessao.Criar(key, alunoJson);
        }

        public Aluno Obter() {

            var alunoJson = _sessao.Consultar(key);
            if (alunoJson != null) {
                Aluno aluno = JsonConvert.DeserializeObject<Aluno>(alunoJson);
                return aluno;
            }
            return null;
        }

        public void Logout() {
            _sessao.RemoverTodas();
        }
    }
}
