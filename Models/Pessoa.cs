using Academia.Libraries.Lang;
using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Pessoa {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(80, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public virtual Endereco Endereco { get; set; }

        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [Phone(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E004")]
        public string Telefone { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public Sexo Sexo { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [EmailAddress(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(6, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(32, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Senha { get; set; }

        [Display(Name = "Confirmação da Senha")]
        //[Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        //[Compare("Senha", ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E005")]
        [NotMapped]
        public string ConfirmacaoSenha { get; set; }
    }
}
