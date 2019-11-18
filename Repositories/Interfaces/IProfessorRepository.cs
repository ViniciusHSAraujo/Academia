using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Repositories.Interfaces {
    public interface IProfessorRepository : IRepository<Professor> {

        Professor Login(string email, string senha);
        int ContarProfessoresAtivos();
    }
}
