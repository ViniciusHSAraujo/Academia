using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class MigrationInicialCorrecaoProjetoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    UF = table.Column<int>(nullable: false),
                    Complemento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TiposExercicios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    GrupoMuscular = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposExercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(maxLength: 32, nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alunos_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 80, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    EnderecoId = table.Column<int>(nullable: false),
                    Telefone = table.Column<string>(nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(maxLength: 32, nullable: false),
                    Salario = table.Column<double>(nullable: false),
                    Admissao = table.Column<DateTime>(nullable: false),
                    Demissao = table.Column<DateTime>(nullable: true),
                    Turno = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professores_Enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlunoId = table.Column<int>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true),
                    Objetivo = table.Column<int>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treinos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
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
                    Descricao = table.Column<string>(nullable: true),
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
                    TipoExercicioId = table.Column<int>(nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Alunos_EnderecoId",
                table: "Alunos",
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
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Professores");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
