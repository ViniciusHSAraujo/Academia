using Academia.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class Aluno : Pessoa {
        [Display(Name = "Treinos")]
        public virtual List<Treino> Treinos { get; set; }

        [Display(Name = "Status")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public bool Status { get; set; }

        [Display(Name = "Data de Cadastro")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataCadastro { get; set; }
    }
}
