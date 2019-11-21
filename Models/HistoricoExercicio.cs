using Academia.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class HistoricoExercicio {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Exercício")]
        public Exercicio Exercicio { get; set; }
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public int ExercicioId { get; set; }

        [Display(Name = "Data")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime Data { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        [Range(0, 999, ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E011")]
        public int Quantidade { get; set; }

    }
}
