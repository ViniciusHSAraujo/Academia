using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class MigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    UF = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposExercicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    GrupoMuscular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposExercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Salario = table.Column<double>(nullable: false),
                    Admissão = table.Column<DateTime>(nullable: false),
                    Demissão = table.Column<DateTime>(nullable: true),
                    Turno = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true),
                    Objetivo = table.Column<string>(nullable: true),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treinos_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Treinos_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Agrupamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(nullable: false),
                    TreinoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agrupamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agrupamentos_Treinos_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "Treinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TipoExercicioId = table.Column<int>(nullable: true),
                    Serie = table.Column<int>(nullable: false),
                    Repeticao = table.Column<int>(nullable: false),
                    AgrupamentoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercicios_Agrupamentos_AgrupamentoId",
                        column: x => x.AgrupamentoId,
                        principalTable: "Agrupamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exercicios_TiposExercicios_TipoExercicioId",
                        column: x => x.TipoExercicioId,
                        principalTable: "TiposExercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoExercicio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExercicioId = table.Column<int>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Unidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoExercicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoExercicio_Exercicios_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "Exercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agrupamentos_TreinoId",
                table: "Agrupamentos",
                column: "TreinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_EnderecoId",
                table: "Aluno",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_AgrupamentoId",
                table: "Exercicios",
                column: "AgrupamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_TipoExercicioId",
                table: "Exercicios",
                column: "TipoExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoExercicio_ExercicioId",
                table: "HistoricoExercicio",
                column: "ExercicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Professores_EnderecoId",
                table: "Professores",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_AlunoId",
                table: "Treinos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_ProfessorId",
                table: "Treinos",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoExercicio");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "Agrupamentos");

            migrationBuilder.DropTable(
                name: "TiposExercicios");

            migrationBuilder.DropTable(
                name: "Treinos");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
