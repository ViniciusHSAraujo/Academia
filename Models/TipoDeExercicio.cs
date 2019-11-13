using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class TipoExercicio {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Grupo Muscular")]
        public GrupoMuscular GrupoMuscular { get; set; }
    }
}
