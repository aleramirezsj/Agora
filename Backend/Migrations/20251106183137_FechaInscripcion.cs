using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class FechaInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaInscripcion",
                table: "Inscripciones",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 11, 16, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 11, 26, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 11, 26, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 8,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 9,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 10,
                column: "FechaInscripcion",
                value: new DateTime(2025, 11, 6, 15, 31, 36, 6, DateTimeKind.Local).AddTicks(7624));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaInscripcion",
                table: "Inscripciones");

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 10, 12, 17, 5, 14, 696, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 10, 22, 17, 5, 14, 697, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaHora",
                value: new DateTime(2025, 10, 22, 17, 5, 14, 697, DateTimeKind.Local).AddTicks(3));
        }
    }
}
