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
        public string Cep { get; set; }

        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [Display(Name = "Número")]
        public string Numero { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        public UnidadeFederativa UF { get; set; }

        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
    }
}

