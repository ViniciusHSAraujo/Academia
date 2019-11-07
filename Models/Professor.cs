using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Professor : Pessoa {
        public double Salario { get; set; }

        public DateTime Admissao { get; set; }

        public DateTime? Demissao { get; set; }

        public char Turno { get; set; }

        public List<Treino> Treinos { get; set; }
    }
}
