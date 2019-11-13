using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {

    public class Agrupamento {

        public int Id { get; set; }

        [Display(Name = "Descri��o")]
        public string Descricao { get; set; }

        [Display(Name = "Exerc�cios")]
        public virtual List<Exercicio> Exercicios { get; set; }

        [Display(Name = "Treino")]
        public virtual Treino Treino { get; set; }
    }
}
