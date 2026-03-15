using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class CreateRespuestaEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RespuestasEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoEventoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Valor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RespuestasEventos_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RespuestasEventos_CamposEventos_CampoEventoId",
                        column: x => x.CampoEventoId,
                        principalTable: "CamposEventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RespuestasEventos_CampoEventoId",
                table: "RespuestasEventos",
                column: "CampoEventoId");

            migrationBuilder.CreateIndex(
                name: "IX_RespuestasEventos_UsuarioId",
                table: "RespuestasEventos",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespuestasEventos");
        }
    }
}
