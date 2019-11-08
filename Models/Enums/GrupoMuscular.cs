using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academia.Models.Enums {
    public enum GrupoMuscular {
        [Display(Name = "Costas")]
        Costas,
        [Display(Name = "Bíceps")]
        Biceps,
        [Display(Name = "Pernas")]
        Pernas,
        [Display(Name = "Peito")]
        Peito,
        [Display(Name = "Ombro")]
        Ombro,
        [Display(Name = "Tríceps")]
        Triceps,
        [Display(Name = "Antebraço")]
        Antebraco,
        [Display(Name = "Aeróbico")]
        Aerobico
    }
}
