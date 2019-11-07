using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class AddColunaNomePessoa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Professores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Alunos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Professores");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Alunos");
        }
    }
}
