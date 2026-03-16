using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Gestor_Eventos_Tlahuac.Migrations
{
    /// <inheritdoc />
    public partial class CreateEventos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Eventos",
                newName: "FechaInicio");

            migrationBuilder.AddColumn<int>(
                name: "EventoId",
                table: "Inscripciones",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TipoActividadId",
                table: "Eventos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaFin",
                table: "Eventos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_EventoId",
                table: "Inscripciones",
                column: "EventoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId",
                principalTable: "TiposActividades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Eventos_EventoId",
                table: "Inscripciones",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos");

            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Eventos_EventoId",
                table: "Inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_Inscripciones_EventoId",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "FechaFin",
                table: "Eventos");

            migrationBuilder.RenameColumn(
                name: "FechaInicio",
                table: "Eventos",
                newName: "Fecha");

            migrationBuilder.AlterColumn<int>(
                name: "TipoActividadId",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_TiposActividades_TipoActividadId",
                table: "Eventos",
                column: "TipoActividadId",
                principalTable: "TiposActividades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
