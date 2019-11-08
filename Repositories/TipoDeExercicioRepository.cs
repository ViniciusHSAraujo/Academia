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
    public class TipoDeExercicioRepository : ITipoDeExercicioRepository {

        private readonly ApplicationDbContext _dbContext;
        public TipoDeExercicioRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public TipoExercicio Buscar(int id) {
            return _dbContext.TiposExercicios.AsNoTracking().SingleOrDefault(t => t.Id == id);
        }

        public void Cadastrar(TipoExercicio obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(TipoExercicio obj) {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var obj = Buscar(id);
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<TipoExercicio> Listar() {
            return _dbContext.TiposExercicios.AsNoTracking().ToList();
        }

        public IPagedList<TipoExercicio> Listar(int? pagina) {
            return _dbContext.TiposExercicios.ToPagedList();
        }
    }
}
