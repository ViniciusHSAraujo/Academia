using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Repositories.Interfaces {
    public interface ITreinoRepository : IRepository<Treino> {

        Treino BuscarUltimoTreinoDoAluno(int id);

        int ContarTreinosAtivos();

        bool AtivarOuDesativar(int id);

    }
}
