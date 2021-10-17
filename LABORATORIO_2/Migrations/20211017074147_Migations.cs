using Microsoft.EntityFrameworkCore.Migrations;

namespace LABORATORIO_2.Migrations
{
    public partial class Migations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlmacenPersona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombePersona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EdadPersona = table.Column<int>(type: "int", nullable: false),
                    DescripcionPersona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlmacenPersona", x => x.IdPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlmacenPersona");
        }
    }
}
