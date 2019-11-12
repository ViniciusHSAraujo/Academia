﻿// <auto-generated />
using System;
using Academia.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academia.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academia.Models.Agrupamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<int?>("TreinoId");

                    b.HasKey("Id");

                    b.HasIndex("TreinoId");

                    b.ToTable("Agrupamentos");
                });

            modelBuilder.Entity("Academia.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Sexo");

                    b.Property<bool>("Status");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Academia.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Numero");

                    b.Property<string>("Rua");

                    b.Property<int>("UF");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("Academia.Models.Exercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgrupamentoId");

                    b.Property<int>("Repeticao");

                    b.Property<int>("Serie");

                    b.Property<int?>("TipoExercicioId");

                    b.HasKey("Id");

                    b.HasIndex("AgrupamentoId");

                    b.HasIndex("TipoExercicioId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("Academia.Models.HistoricoExercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int?>("ExercicioId");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Unidade");

                    b.HasKey("Id");

                    b.HasIndex("ExercicioId");

                    b.ToTable("HistoricoExercicio");
                });

            modelBuilder.Entity("Academia.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Admissao");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<DateTime?>("Demissao");

                    b.Property<string>("Email");

                    b.Property<int?>("EnderecoId");

                    b.Property<string>("Nome");

                    b.Property<double>("Salario");

                    b.Property<string>("Senha");

                    b.Property<int>("Sexo");

                    b.Property<string>("Telefone");

                    b.Property<string>("Turno")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("Academia.Models.TipoExercicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GrupoMuscular");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("TiposExercicios");
                });

            modelBuilder.Entity("Academia.Models.Treino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AlunoId");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<int>("Objetivo");

                    b.Property<int?>("ProfessorId");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Treinos");
                });

            modelBuilder.Entity("Academia.Models.Agrupamento", b =>
                {
                    b.HasOne("Academia.Models.Treino", "Treino")
                        .WithMany("Agrupamentos")
                        .HasForeignKey("TreinoId");
                });

            modelBuilder.Entity("Academia.Models.Aluno", b =>
                {
                    b.HasOne("Academia.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Academia.Models.Exercicio", b =>
                {
                    b.HasOne("Academia.Models.Agrupamento", "Agrupamento")
                        .WithMany("Exercicios")
                        .HasForeignKey("AgrupamentoId");

                    b.HasOne("Academia.Models.TipoExercicio", "TipoExercicio")
                        .WithMany()
                        .HasForeignKey("TipoExercicioId");
                });

            modelBuilder.Entity("Academia.Models.HistoricoExercicio", b =>
                {
                    b.HasOne("Academia.Models.Exercicio", "Exercicio")
                        .WithMany("Historicos")
                        .HasForeignKey("ExercicioId");
                });

            modelBuilder.Entity("Academia.Models.Professor", b =>
                {
                    b.HasOne("Academia.Models.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("Academia.Models.Treino", b =>
                {
                    b.HasOne("Academia.Models.Aluno", "Aluno")
                        .WithMany("Treinos")
                        .HasForeignKey("AlunoId");

                    b.HasOne("Academia.Models.Professor", "Professor")
                        .WithMany("Treinos")
                        .HasForeignKey("ProfessorId");
                });
#pragma warning restore 612, 618
        }
    }
}
