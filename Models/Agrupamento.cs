using Academia.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {

    public class Agrupamento {

        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public string Descricao { get; set; }

        [Display(Name = "Exercícios")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public virtual List<Exercicio> Exercicios { get; set; }

        [Display(Name = "Treino")]
        public virtual Treino Treino { get; set; }
    }
}
