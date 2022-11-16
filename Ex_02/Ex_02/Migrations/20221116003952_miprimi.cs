using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ex02.Migrations
{
    /// <inheritdoc />
    public partial class miprimi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "plantas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Años = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Plantación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Plantines = table.Column<double>(type: "float", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamaño = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plantas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "riesgo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Litros = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Dias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tiempoduracion = table.Column<DateTime>(name: "Tiempo_duracion", type: "datetime2", nullable: false),
                    Plantación = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_riesgo", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "plantas");

            migrationBuilder.DropTable(
                name: "riesgo");
        }
    }
}
