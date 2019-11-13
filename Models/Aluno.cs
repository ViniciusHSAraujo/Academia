using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class Aluno : Pessoa {
        [Display(Name = "Treinos")]
        public virtual List<Treino> Treinos { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
