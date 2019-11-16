using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class RemoveCampoUnidadeHistoricoExercicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Unidade",
                table: "HistoricosExercicios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Unidade",
                table: "HistoricosExercicios",
                nullable: true);
        }
    }
}
