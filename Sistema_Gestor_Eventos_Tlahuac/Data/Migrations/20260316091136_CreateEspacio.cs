using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class CreateEspacio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspacioId",
                table: "Talleres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspacioId",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Espacio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    LugarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Espacio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Espacio_Lugares_LugarId",
                        column: x => x.LugarId,
                        principalTable: "Lugares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Talleres_EspacioId",
                table: "Talleres",
                column: "EspacioId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_EspacioId",
                table: "Eventos",
                column: "EspacioId");

            migrationBuilder.CreateIndex(
                name: "IX_Espacio_LugarId",
                table: "Espacio",
                column: "LugarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Espacio_EspacioId",
                table: "Eventos",
                column: "EspacioId",
                principalTable: "Espacio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Talleres_Espacio_EspacioId",
                table: "Talleres",
                column: "EspacioId",
                principalTable: "Espacio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Espacio_EspacioId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_Espacio_EspacioId",
                table: "Talleres");

            migrationBuilder.DropTable(
                name: "Espacio");

            migrationBuilder.DropIndex(
                name: "IX_Talleres_EspacioId",
                table: "Talleres");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_EspacioId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "EspacioId",
                table: "Talleres");

            migrationBuilder.DropColumn(
                name: "EspacioId",
                table: "Eventos");
        }
    }
}
