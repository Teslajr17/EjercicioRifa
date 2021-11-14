using Microsoft.EntityFrameworkCore.Migrations;

namespace ejercicio.Migrations
{
    public partial class AgregarClaseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombre2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<int>(type: "int", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
