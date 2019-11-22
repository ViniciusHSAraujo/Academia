using Academia.Libraries.Lang;
using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Professor : Pessoa {
        [Display(Name = "Salário")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [Range(0.01, 99999.99, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E011")]
        public double Salario { get; set; }

        [Display(Name = "Data de Admissão")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime Admissao { get; set; }

        [Display(Name = "Data de Demissão")]
        public DateTime? Demissao { get; set; }

        [Display(Name = "Turno")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public Turno Turno { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(32, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Senha { get; set; }

        [Display(Name = "Confirmação da Senha")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [Compare("Senha", ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E005")]
        [NotMapped]
        public string ConfirmacaoSenha { get; set; }

        public List<Treino> Treinos { get; set; }
    }
}
