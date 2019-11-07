using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class CorrecaoNomeTabelasComAcento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Demissão",
                table: "Professores",
                newName: "Demissao");

            migrationBuilder.RenameColumn(
                name: "Admissão",
                table: "Professores",
                newName: "Admissao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Demissao",
                table: "Professores",
                newName: "Demissão");

            migrationBuilder.RenameColumn(
                name: "Admissao",
                table: "Professores",
                newName: "Admissão");
        }
    }
}
