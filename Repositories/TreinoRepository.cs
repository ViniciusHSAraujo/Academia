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
    public class TreinoRepository : ITreinoRepository {

        private readonly ApplicationDbContext _dbContext;
        public TreinoRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Treino Buscar(int id) {
            return _dbContext.Treinos.AsNoTracking().SingleOrDefault(t => t.Id == id);
        }

        public void Cadastrar(Treino obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(Treino obj) {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var obj = Buscar(id);
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<Treino> Listar() {
            return _dbContext.Treinos.AsNoTracking().ToList();
        }

        public IPagedList<Treino> Listar(int? pagina) {
            return _dbContext.Treinos.ToPagedList();
        }
    }
}
