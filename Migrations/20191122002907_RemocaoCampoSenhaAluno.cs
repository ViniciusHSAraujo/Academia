using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class RemocaoCampoSenhaAluno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Alunos",
                maxLength: 32,
                nullable: false,
                defaultValue: "");
        }
    }
}
