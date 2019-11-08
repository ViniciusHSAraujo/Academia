using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models.Enums {
    public enum Sexo {
        [Display(Name = "Masculino")]
        Masculino,
        [Display(Name = "Feminino")]
        Feminino
    }
}
