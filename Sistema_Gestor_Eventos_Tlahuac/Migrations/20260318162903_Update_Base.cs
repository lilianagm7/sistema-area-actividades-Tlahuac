using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class Update_Base : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Espacio_Lugares_LugarId",
                table: "Espacio");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Espacio_EspacioId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_Espacio_EspacioId",
                table: "Talleres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Espacio",
                table: "Espacio");

            migrationBuilder.RenameTable(
                name: "Espacio",
                newName: "Espacios");

            migrationBuilder.RenameIndex(
                name: "IX_Espacio_LugarId",
                table: "Espacios",
                newName: "IX_Espacios_LugarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Espacios",
                table: "Espacios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Espacios_Lugares_LugarId",
                table: "Espacios",
                column: "LugarId",
                principalTable: "Lugares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Espacios_EspacioId",
                table: "Eventos",
                column: "EspacioId",
                principalTable: "Espacios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Talleres_Espacios_EspacioId",
                table: "Talleres",
                column: "EspacioId",
                principalTable: "Espacios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Espacios_Lugares_LugarId",
                table: "Espacios");

            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Espacios_EspacioId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_Espacios_EspacioId",
                table: "Talleres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Espacios",
                table: "Espacios");

            migrationBuilder.RenameTable(
                name: "Espacios",
                newName: "Espacio");

            migrationBuilder.RenameIndex(
                name: "IX_Espacios_LugarId",
                table: "Espacio",
                newName: "IX_Espacio_LugarId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Espacio",
                table: "Espacio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Espacio_Lugares_LugarId",
                table: "Espacio",
                column: "LugarId",
                principalTable: "Lugares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
