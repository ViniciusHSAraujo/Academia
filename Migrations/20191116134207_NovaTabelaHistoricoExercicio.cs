using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class NovaTabelaHistoricoExercicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoExercicio_Exercicios_ExercicioId",
                table: "HistoricoExercicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoExercicio",
                table: "HistoricoExercicio");

            migrationBuilder.RenameTable(
                name: "HistoricoExercicio",
                newName: "HistoricosExercicios");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricoExercicio_ExercicioId",
                table: "HistoricosExercicios",
                newName: "IX_HistoricosExercicios_ExercicioId");

            migrationBuilder.AddColumn<int>(
                name: "AgrupamentoId",
                table: "HistoricosExercicios",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricosExercicios",
                table: "HistoricosExercicios",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricosExercicios_Exercicios_ExercicioId",
                table: "HistoricosExercicios",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosExercicios_Agrupamentos_AgrupamentoId",
                table: "HistoricosExercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricosExercicios_Exercicios_ExercicioId",
                table: "HistoricosExercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricosExercicios",
                table: "HistoricosExercicios");

            migrationBuilder.DropIndex(
                name: "IX_HistoricosExercicios_AgrupamentoId",
                table: "HistoricosExercicios");

            migrationBuilder.DropColumn(
                name: "AgrupamentoId",
                table: "HistoricosExercicios");

            migrationBuilder.RenameTable(
                name: "HistoricosExercicios",
                newName: "HistoricoExercicio");

            migrationBuilder.RenameIndex(
                name: "IX_HistoricosExercicios_ExercicioId",
                table: "HistoricoExercicio",
                newName: "IX_HistoricoExercicio_ExercicioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoExercicio",
                table: "HistoricoExercicio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoExercicio_Exercicios_ExercicioId",
                table: "HistoricoExercicio",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
