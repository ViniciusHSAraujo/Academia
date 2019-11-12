using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Treino {
        public int Id { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        [ForeignKey("Professor")]
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        public Objetivo Objetivo { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataFim { get; set; }

        public List<Agrupamento> Agrupamentos { get; set; }
    }
}
