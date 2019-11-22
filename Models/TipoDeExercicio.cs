using Academia.Libraries.Lang;
using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class TipoExercicio {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public string Nome { get; set; }

        [Display(Name = "Grupo Muscular")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public GrupoMuscular GrupoMuscular { get; set; }

        [Display(Name = "Situacao")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public bool Situacao { get; set; }

    }
}
