using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class CorrecaoNomeTabelasPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Endereco_EnderecoId",
                table: "Aluno");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Endereco_EnderecoId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_Aluno_AlunoId",
                table: "Treinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Aluno",
                newName: "Alunos");

            migrationBuilder.RenameIndex(
                name: "IX_Aluno_EnderecoId",
                table: "Alunos",
                newName: "IX_Alunos_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Alunos_Enderecos_EnderecoId",
                table: "Alunos",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Enderecos_EnderecoId",
                table: "Professores",
                column: "EnderecoId",
                principalTable: "Enderecos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_Alunos_AlunoId",
                table: "Treinos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alunos_Enderecos_EnderecoId",
                table: "Alunos");

            migrationBuilder.DropForeignKey(
                name: "FK_Professores_Enderecos_EnderecoId",
                table: "Professores");

            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_Alunos_AlunoId",
                table: "Treinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alunos",
                table: "Alunos");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Alunos",
                newName: "Aluno");

            migrationBuilder.RenameIndex(
                name: "IX_Alunos_EnderecoId",
                table: "Aluno",
                newName: "IX_Aluno_EnderecoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aluno",
                table: "Aluno",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Endereco_EnderecoId",
                table: "Aluno",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Professores_Endereco_EnderecoId",
                table: "Professores",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_Aluno_AlunoId",
                table: "Treinos",
                column: "AlunoId",
                principalTable: "Aluno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
