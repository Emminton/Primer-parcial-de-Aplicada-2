using Microsoft.EntityFrameworkCore.Migrations;

namespace Primer_Parcial_Aplicada_2_Emminton.Migrations
{
    public partial class Articulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articulos",
                columns: table => new
                {
                    ArticuloId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(maxLength: 100, nullable: false),
                    Existencia = table.Column<decimal>(nullable: false),
                    Costo = table.Column<decimal>(nullable: false),
                    ValorInventario = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articulos", x => x.ArticuloId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articulos");
        }
    }
}
