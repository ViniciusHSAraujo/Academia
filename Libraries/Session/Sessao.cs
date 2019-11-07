using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Libraries.Session {
    public class Sessao {
        private readonly IHttpContextAccessor _context;
        public Sessao(IHttpContextAccessor context) {
            _context = context;
        }


        public void Criar(string key, string value) {
            _context.HttpContext.Session.SetString(key, value);
        }

        public void Atualizar(string key, string value) {
            Remover(key);
            Criar(key, value);
        }

        public void Remover(string key) {
            if (Existe(key)) {
                _context.HttpContext.Session.Remove(key);
            }
        }

        public void RemoverTodas() {
            _context.HttpContext.Session.Clear();
        }

        public string Consultar(string key) {
            return _context.HttpContext.Session.GetString(key);
        }

        public bool Existe(string key) {
            return _context.HttpContext.Session.TryGetValue(key, out byte[] value);
        }

    }
}
