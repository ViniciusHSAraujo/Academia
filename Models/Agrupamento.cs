using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {

    public class Agrupamento {

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Exercícios")]
        public virtual List<Exercicio> Exercicios { get; set; }

        [Display(Name = "Treino")]
        public virtual Treino Treino { get; set; }
    }
}
