using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {

    public class Agrupamento {

        public int Id { get; set; }

        public char Tipo { get; set; }

        public virtual List<Exercicio> Exercicios { get; set; }

        public Treino Treino { get; set; }
    }
}
