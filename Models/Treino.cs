using Academia.Libraries.Lang;
using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Academia.Models {
    public class Treino {
        public int Id { get; set; }

        [Display(Name = "Aluno")]
        public int? AlunoId { get; set; }

        [ForeignKey("AlunoId")]
        [Display(Name = "Aluno")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public Aluno Aluno { get; set; }

        [Display(Name = "Professor")]
        public int? ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        [Display(Name = "Professor")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public Professor Professor { get; set; }

        [Display(Name = "Objetivo")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public Objetivo Objetivo { get; set; }

        [Display(Name = "Data de Início")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Data de Fim")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public DateTime DataFim { get; set; }

        [Display(Name = "Agrupamentos")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public virtual List<Agrupamento> Agrupamentos { get; set; }

        [Display(Name = "Situação")]
        [Required(ErrorMessageResourceType = typeof(MensagensErro), ErrorMessageResourceName = "MSG_E001")]
        public bool Situacao { get; set; }
    }
}
