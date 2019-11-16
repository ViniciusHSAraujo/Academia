using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class RemoveCampoAgrupamentoHistoricoExercicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosExercicios_Agrupamentos_AgrupamentoId",
                table: "HistoricosExercicios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosExercicios_AgrupamentoId",
                table: "HistoricosExercicios");

            migrationBuilder.DropColumn(
                name: "AgrupamentoId",
                table: "HistoricosExercicios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AgrupamentoId",
                table: "HistoricosExercicios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HistoricosExercicios_AgrupamentoId",
                table: "HistoricosExercicios",
                column: "AgrupamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosExercicios_Agrupamentos_AgrupamentoId",
                table: "HistoricosExercicios",
                column: "AgrupamentoId",
                principalTable: "Agrupamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
