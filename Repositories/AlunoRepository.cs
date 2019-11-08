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
    public class AlunoRepository : IAlunoRepository {

        private readonly ApplicationDbContext _dbContext;
        public AlunoRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Aluno Buscar(int id) {
            return _dbContext.Alunos.Include(a => a.Endereco).SingleOrDefault(a => a.Id == id);
        }

        public void Cadastrar(Aluno obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(Aluno obj) {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var obj = Buscar(id);
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Aluno> Listar() {
            return _dbContext.Alunos.AsNoTracking().ToList();
        }

        public IPagedList<Aluno> Listar(int? pagina) {
            return _dbContext.Alunos.ToPagedList();
        }

        public Aluno Login(string email, string senha) {
            return _dbContext.Alunos.Where(p => p.Email.Equals(email) && p.Senha.Equals(senha)).FirstOrDefault();
        }

    }
}
