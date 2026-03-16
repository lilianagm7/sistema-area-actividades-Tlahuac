using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class UltimasModificaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadesId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_TiposActividades_TipoActividadesId",
                table: "Talleres");

            migrationBuilder.DropIndex(
                name: "IX_Talleres_TipoActividadesId",
                table: "Talleres");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_TipoActividadesId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "TipoActividadesId",
                table: "Talleres");

            migrationBuilder.DropColumn(
                name: "TipoActividadesId",
                table: "Eventos");

            migrationBuilder.CreateIndex(
                name: "IX_Talleres_TipoActividadId",
                table: "Talleres",
                column: "TipoActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId",
                principalTable: "TiposActividades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talleres_TiposActividades_TipoActividadId",
                table: "Talleres",
                column: "TipoActividadId",
                principalTable: "TiposActividades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_TiposActividades_TipoActividadId",
                table: "Talleres");

            migrationBuilder.DropIndex(
                name: "IX_Talleres_TipoActividadId",
                table: "Talleres");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_TipoActividadId",
                table: "Eventos");

            migrationBuilder.AddColumn<int>(
                name: "TipoActividadesId",
                table: "Talleres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoActividadesId",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Talleres_TipoActividadesId",
                table: "Talleres",
                column: "TipoActividadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TipoActividadesId",
                table: "Eventos",
                column: "TipoActividadesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadesId",
                table: "Eventos",
                column: "TipoActividadesId",
                principalTable: "TiposActividades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talleres_TiposActividades_TipoActividadesId",
                table: "Talleres",
                column: "TipoActividadesId",
                principalTable: "TiposActividades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
