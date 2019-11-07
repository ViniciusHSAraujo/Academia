using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class HistoricoExercicio {
        public int Id { get; set; }

        public Exercicio Exercicio { get; set; }

        public DateTime Data { get; set; }

        public int Quantidade { get; set; }

        public string Unidade { get; set; }
    }
}
