using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Repositories.Interfaces {
    public interface IAlunoRepository : IRepository<Aluno> {

        Aluno Login(string email, string senha);

    }
}
