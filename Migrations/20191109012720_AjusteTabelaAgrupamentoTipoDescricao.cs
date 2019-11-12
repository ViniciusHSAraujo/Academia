using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class AjusteTabelaAgrupamentoTipoDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "Agrupamentos");

            migrationBuilder.AlterColumn<int>(
                name: "Objetivo",
                table: "Treinos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Agrupamentos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Agrupamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Objetivo",
                table: "Treinos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Tipo",
                table: "Agrupamentos",
                nullable: false,
                defaultValue: "");
        }
    }
}
