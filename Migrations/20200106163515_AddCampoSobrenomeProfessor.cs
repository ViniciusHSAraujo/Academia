using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class AddCampoSobrenomeProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Professores",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Professores");
        }
    }
}
