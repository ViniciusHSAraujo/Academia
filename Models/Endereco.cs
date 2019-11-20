using Academia.Libraries.Lang;
using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class Endereco {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public string Cep { get; set; }

        [Display(Name = "Rua")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(1, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(125, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [Range(1, 99999, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E011")]
        public string Numero { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(1, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(125, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(1, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(125, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E003")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public UnidadeFederativa UF { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
    }
}

