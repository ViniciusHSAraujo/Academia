﻿using Academia.Database;
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
            return _dbContext.HistoricosExercicios.Include(h => h.Exercicio).FirstOrDefault(h => h.Id == id);
        }


        public HistoricoExercicio BuscarUltimoExercicioDoAluno(int id) {
            return _dbContext.HistoricosExercicios.Include(h => h.Exercicio).ThenInclude(h => h.Agrupamento).ThenInclude(a => a.Treino).ThenInclude(t => t.Aluno).Where(h => h.Exercicio.Agrupamento.Treino.Aluno.Id == id).OrderBy(h => h.Id).LastOrDefault();
        }

        public void Cadastrar(HistoricoExercicio obj) {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Cadastrar(IEnumerable<HistoricoExercicio> obj) {
            _dbContext.AddRange(obj);
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
            return _dbContext.HistoricosExercicios.AsNoTracking().Include(h => h.Exercicio).ToList();
        }

        public IPagedList<HistoricoExercicio> Listar(int? pagina) {
            return _dbContext.HistoricosExercicios.ToPagedList();
        }
        /**
         * Conta a quantidade de treinos que foram executados no mês atual.
         */
        public int ContarTreinosExecutados() {
            return _dbContext.HistoricosExercicios.Where(h => h.Data.Month == DateTime.Now.Month && h.Data.Year == DateTime.Now.Year).GroupBy(h => h.Exercicio).Count();
        }
    }
}