using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Exercicio {
        public int Id { get; set; }

        public TipoExercicio TipoExercicio { get; set; }

        public int Serie { get; set; }

        public int Repeticao { get; set; }

        public virtual List<HistoricoExercicio> Historicos { get; set; }

        public Agrupamento Agrupamento { get; set; }
    }
}