using Microsoft.EntityFrameworkCore.Migrations;

namespace Academia.Migrations
{
    public partial class CorrecaoEnumerados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GrupoMuscular",
                table: "TiposExercicios",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Professores",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "UF",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sexo",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GrupoMuscular",
                table: "TiposExercicios",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Professores",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UF",
                table: "Enderecos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Sexo",
                table: "Alunos",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
