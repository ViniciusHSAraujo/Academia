using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models.Enums {
    public enum Turno {
        [Display(Name = "Manhã")]
        Manha,
        [Display(Name = "Tarde")]
        Tarde,
        [Display(Name = "Noite")]
        Noite
    }
}
