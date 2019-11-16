using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Repositories.Interfaces {
    public interface IHistoricoExercicioRepository : IRepository<HistoricoExercicio> {
        void Cadastrar(IEnumerable<HistoricoExercicio> obj);
        HistoricoExercicio BuscarUltimo(int id);

    }
}
