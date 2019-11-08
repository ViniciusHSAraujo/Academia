using Academia.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academia.Models {
    public class Pessoa {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public virtual Endereco Endereco { get; set; }

        public string Telefone { get; set; }

        public Sexo Sexo { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
