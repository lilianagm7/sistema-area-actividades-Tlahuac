using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class CreateInscripciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividad_TipoActividadId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_TiposActividad_TipoActividadId",
                table: "Talleres");

            migrationBuilder.DropTable(
                name: "TiposActividad");

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

            migrationBuilder.CreateTable(
                name: "Inscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaInscripcion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    TallerId = table.Column<int>(type: "int", nullable: false),
                    AlumnoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioRegistroId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscripciones_AspNetUsers_UsuarioRegistroId",
                        column: x => x.UsuarioRegistroId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inscripciones_Talleres_TallerId",
                        column: x => x.TallerId,
                        principalTable: "Talleres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiposActividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposActividades", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Talleres_TipoActividadesId",
                table: "Talleres",
                column: "TipoActividadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TipoActividadesId",
                table: "Eventos",
                column: "TipoActividadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_AlumnoId",
                table: "Inscripciones",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_TallerId",
                table: "Inscripciones",
                column: "TallerId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_UsuarioRegistroId",
                table: "Inscripciones",
                column: "UsuarioRegistroId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadesId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Talleres_TiposActividades_TipoActividadesId",
                table: "Talleres");

            migrationBuilder.DropTable(
                name: "Inscripciones");

            migrationBuilder.DropTable(
                name: "TiposActividades");

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

            migrationBuilder.CreateTable(
                name: "TiposActividad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposActividad", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Talleres_TipoActividadId",
                table: "Talleres",
                column: "TipoActividadId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TiposActividad_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId",
                principalTable: "TiposActividad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talleres_TiposActividad_TipoActividadId",
                table: "Talleres",
                column: "TipoActividadId",
                principalTable: "TiposActividad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
