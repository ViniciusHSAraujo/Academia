using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class AddCampoSituacaoTreino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Situacao",
                table: "Treinos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Situacao",
                table: "Treinos");
        }
    }
}
