using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models.Enums {
    public enum Objetivo {
        [Display(Name = "Hipertrofia")]
        Hipertrofia,
        [Display(Name = "Definição")]
        Definicao,
        [Display(Name = "Emagrecimento")]
        Emagrecimento,
        [Display(Name = "Saúde")]
        Saude,
        [Display(Name = "Força")]
        Forca
    }
}
