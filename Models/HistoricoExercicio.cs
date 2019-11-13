using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academia.Models {
    public class HistoricoExercicio {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "Exercício")]
        public virtual Exercicio Exercicio { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Unidade")]
        public string Unidade { get; set; }
    }
}
