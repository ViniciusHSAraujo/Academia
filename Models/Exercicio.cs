using Academia.Libraries.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Exercicio {
        [Display(Name = "Id")]
        public int Id { get; set; }

        public int TipoExercicioId { get; set; }
        [Display(Name = "Tipo de Exerc�cio")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public virtual TipoExercicio TipoExercicio { get; set; }

        [Display(Name = "S�ries")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public int Serie { get; set; }

        [Display(Name = "Repeti��es")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public int Repeticao { get; set; }

        [Display(Name = "Hist�rico")]
        public virtual List<HistoricoExercicio> Historicos { get; set; }

        [Display(Name = "Agrupamento")]
        public virtual Agrupamento Agrupamento { get; set; }
    }
}
