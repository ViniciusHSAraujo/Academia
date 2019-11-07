using Academia.Models;
using Microsoft.EntityFrameworkCore;

namespace Academia.Database {
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<Agrupamento> Agrupamentos { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<TipoExercicio> TiposExercicios { get; set; }
        public DbSet<Treino> Treinos { get; set; }

    }
}