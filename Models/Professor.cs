using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Professor : Pessoa {
        public double Salario { get; set; }

        public DateTime Admissão { get; set; }

        public DateTime? Demissão { get; set; }

        public char Turno { get; set; }

        public List<Treino> Treinos { get; set; }
    }
}
