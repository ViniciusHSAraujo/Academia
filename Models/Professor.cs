using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class Professor : Pessoa {
        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Display(Name = "Data de Admissão")]
        public DateTime Admissao { get; set; }

        [Display(Name = "Data de Demissão")]
        public DateTime? Demissao { get; set; }

        [Display(Name = "Turno")]
        public Turno Turno { get; set; }

        public List<Treino> Treinos { get; set; }
    }
}
