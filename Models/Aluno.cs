using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Aluno : Pessoa {
        public List<Treino> Treinos { get; set; }

        public bool Status { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
