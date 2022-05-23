using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIBiblioteca.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    EditorialId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.EditorialId);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Título = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Páginas = table.Column<int>(type: "int", precision: 1, scale: 1000, nullable: false),
                    EditorialIdentificador = table.Column<int>(type: "int", nullable: false),
                    EditorialId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroId);
                    table.ForeignKey(
                        name: "FK_Libros_Editoriales_EditorialId",
                        column: x => x.EditorialId,
                        principalTable: "Editoriales",
                        principalColumn: "EditorialId");
                });

            migrationBuilder.InsertData(
                table: "Editoriales",
                columns: new[] { "EditorialId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Planeta" },
                    { 2, "Aguilar" }
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "EditorialId", "EditorialIdentificador", "Páginas", "Título" },
                values: new object[,]
                {
                    { 1, null, 1, 300, "El Quijote" },
                    { 2, null, 1, 350, "Cien años de soledad" },
                    { 3, null, 2, 500, "El amor en los tiempos del cólera" },
                    { 4, null, 1, 300, "Divina comedia" },
                    { 5, null, 1, 350, "El extranjero" },
                    { 6, null, 2, 1000, "Crimen y castigo" },
                    { 7, null, 1, 1500, "El hombre invisible" },
                    { 8, null, 1, 850, "Almas muertas" },
                    { 9, null, 2, 900, "El castillo" },
                    { 10, null, 2, 800, "Pippi Calzaslargas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_EditorialId",
                table: "Libros",
                column: "EditorialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Editoriales");
        }
    }
}
