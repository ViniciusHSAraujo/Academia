﻿using Academia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Repositories.Interfaces {
    public interface ITipoDeExercicioRepository : IRepository<TipoExercicio> {
        bool AtivarOuDesativar(int id);

    }
}

