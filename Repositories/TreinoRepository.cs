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
            return _dbContext.Treinos.Include(t => t.Aluno).Include(t => t.Professor).Include(t => t.Agrupamentos).ThenInclude(a => a.Exercicios).ThenInclude(e => e.TipoExercicio).Where(t => t.DataInicio < DateTime.Now && t.DataFim > DateTime.Now && t.Situacao == true && t.Aluno.Id == id).LastOrDefault();
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
            return _dbContext.Treinos.AsNoTracking().Include(t => t.Aluno).Include(t => t.Professor).ToList();
        }

        public IPagedList<Treino> Listar(int? pagina) {
            return _dbContext.Treinos.ToPagedList();
        }
        /**
         * Conta a quantidade de treinos que estão com a situação ativa que estejam entre sua data de inicio e fim.
         */
        public int ContarTreinosAtivos() {
            return _dbContext.Treinos.Where(t => (t.DataInicio < DateTime.Now && t.DataFim > DateTime.Now) && t.Situacao == true).GroupBy(t => t.Aluno).Count();
        }
    }
}
