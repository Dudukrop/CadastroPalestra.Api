using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroPalestra.Migrations
{
    public partial class confimacaoemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmacaoEmail",
                table: "Participante",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmacaoEmail",
                table: "Participante");
        }
    }
}
