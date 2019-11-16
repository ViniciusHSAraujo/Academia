using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Treino {
        public int Id { get; set; }

        public int? AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        public Aluno Aluno { get; set; }

        public int? ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }

        public Objetivo Objetivo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public virtual List<Agrupamento> Agrupamentos { get; set; }
        public bool Situacao { get; internal set; }
    }
}
