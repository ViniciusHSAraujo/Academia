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
        public int ExercicioId { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

    }
}
