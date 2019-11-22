using Academia.Database;
using Academia.Models;
using Academia.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Academia.Repositories {
    public class ProfessorRepository : IProfessorRepository {

        private readonly ApplicationDbContext _dbContext;
        public ProfessorRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Professor Buscar(int id) {
            return _dbContext.Professores.Include(p => p.Endereco).SingleOrDefault(p => p.Id == id);
        }

        public void Cadastrar(Professor obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(Professor obj) {
            _dbContext.Entry(obj).Property(p => p.Senha).IsModified = false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }

        public void TrocarSenha(Professor obj) {
            var objBanco = Buscar(obj.Id);

            objBanco.Senha = obj.Senha;
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var obj = Buscar(id);
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Professor> Listar() {
            return _dbContext.Professores.ToList();
        }

        public IPagedList<Professor> Listar(int? pagina) {
            int numeroDaPagina = pagina ?? 1;
            int registrosPorPagina = 10;
            return _dbContext.Professores.ToPagedList(numeroDaPagina, registrosPorPagina);
        }

        public Professor Login(string email, string senha) {
            return _dbContext.Professores.Where(p => p.Email.Equals(email) && p.Senha.Equals(senha)).FirstOrDefault();
        }
        /**
         * Conta a quantidade de professores que estão ativos (já foram admitidos e não foram demitidos ainda).
         */
        public int ContarProfessoresAtivos() {
            return _dbContext.Professores.Where(p => p.Admissao <= DateTime.Now.Date && ((p.Demissao.HasValue && p.Demissao.Value > DateTime.Now.Date) || !p.Demissao.HasValue)).Count();
        }
    }
}
