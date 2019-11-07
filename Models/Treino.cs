using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Treino {
        public int Id { get; set; }

        public virtual Aluno Aluno { get; set; }

        public virtual Professor Professor { get; set; }

        public string Objetivo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public List<Agrupamento> Agrupamentos { get; set; }
    }
}
