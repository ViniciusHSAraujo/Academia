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
    public class HistoricoExercicioRepository : IHistoricoExercicioRepository {

        private readonly ApplicationDbContext _dbContext;
        public HistoricoExercicioRepository(ApplicationDbContext dbContext) {
            _dbContext = dbContext;
        }

        public HistoricoExercicio Buscar(int id) {
            return _dbContext.HistoricosExercicios.Include(h => h.Exercicio).Include(h => h.Agrupamento).ThenInclude(a => a.Treino).ThenInclude(t => t.Aluno).LastOrDefault(e => e.Agrupamento.Treino.Aluno.Id == id); ;
        }

        public void Cadastrar(HistoricoExercicio obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Editar(HistoricoExercicio obj) {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }

        public void Excluir(int id) {
            var obj = Buscar(id);
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public List<HistoricoExercicio> Listar() {
            return _dbContext.HistoricosExercicios.AsNoTracking().Include(h => h.Agrupamento).ToList();
        }

        public IPagedList<HistoricoExercicio> Listar(int? pagina) {
            return _dbContext.HistoricosExercicios.ToPagedList();
        }
    }
}
