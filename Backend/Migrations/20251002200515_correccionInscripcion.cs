using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class correccionInscripcion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Inscripciones");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "Dni");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Inscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.InsertData(
                table: "Capacitaciones",
                columns: new[] { "Id", "Cupo", "Detalle", "FechaHora", "InscripcionAbierta", "IsDeleted", "Nombre", "Ponente" },
                values: new object[] { 3, 25, "Crea webapps con Angular y ASP.NET Core.", new DateTime(2025, 10, 22, 17, 5, 14, 697, DateTimeKind.Local).AddTicks(3), true, false, "ASP.NET Core con Angular", "Pedro Martínez" });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acreditado", "Importe", "UsuarioId" },
                values: new object[] { true, 0m, 1 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acreditado", "Importe", "TipoInscripcionId", "UsuarioId" },
                values: new object[] { true, 12000m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acreditado", "CapacitacionId", "Importe", "UsuarioId" },
                values: new object[] { true, 1, 0m, 3 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acreditado", "Importe", "TipoInscripcionId", "UsuarioId" },
                values: new object[] { true, 8000m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acreditado", "UsuarioId" },
                values: new object[] { true, 4 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellido", "DeleteDate", "Dni", "Email", "Nombre", "TipoUsuario" },
                values: new object[] { "Ramírez", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43111222", "tadeo@isp20.edu.ar", "Tadeo", 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellido", "DeleteDate", "Dni", "Email", "Nombre" },
                values: new object[] { "Gómez", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "40222333", "lucia.gomez@isp20.edu.ar", "Lucía" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Apellido", "DeleteDate", "Dni", "Email", "IsDeleted", "Nombre", "TipoUsuario" },
                values: new object[,]
                {
                    { 3, "Pérez", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "39555111", "martin.perez@isp20.edu.ar", false, "Martín", 0 },
                    { 4, "Sosa", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38888999", "carla.sosa@isp20.edu.ar", false, "Carla", 0 },
                    { 5, "López", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "37777666", "diego.lopez@isp20.edu.ar", false, "Diego", 1 },
                    { 6, "Admin", new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00000000", "soporte@agora.isp20.edu.ar", false, "Soporte", 2 }
                });

            migrationBuilder.InsertData(
                table: "Inscripciones",
                columns: new[] { "Id", "Acreditado", "CapacitacionId", "Importe", "IsDeleted", "Pagado", "TipoInscripcionId", "UsuarioCobroId", "UsuarioId" },
                values: new object[,]
                {
                    { 6, false, 3, 15000m, false, false, 1, null, 1 },
                    { 7, false, 3, 0m, false, false, 3, null, 2 },
                    { 8, false, 3, 15000m, false, false, 1, null, 3 },
                    { 9, false, 3, 15000m, false, false, 1, null, 4 },
                    { 10, false, 3, 10000m, false, false, 2, null, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscripciones_UsuarioId",
                table: "Inscripciones",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inscripciones_Usuarios_UsuarioId",
                table: "Inscripciones",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inscripciones_Usuarios_UsuarioId",
                table: "Inscripciones");

            migrationBuilder.DropIndex(
                name: "IX_Inscripciones_UsuarioId",
                table: "Inscripciones");

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Inscripciones");

            migrationBuilder.RenameColumn(
                name: "Dni",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Dni",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Inscripciones",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaHora",
                value: new DateTime(2025, 8, 29, 18, 30, 3, 794, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Capacitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaHora",
                value: new DateTime(2025, 9, 8, 18, 30, 3, 794, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Acreditado", "Apellido", "Dni", "Email", "Importe", "Nombre" },
                values: new object[] { false, "Gómez", "12345678", "carlos.gomez@gmail.com", 10000m, "Carlos" });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Acreditado", "Apellido", "Dni", "Email", "Importe", "Nombre", "TipoInscripcionId" },
                values: new object[] { false, "Martínez", "87654321", "ana.martinez@gmail.com", 5000m, "Ana", 2 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Acreditado", "Apellido", "CapacitacionId", "Dni", "Email", "Importe", "Nombre" },
                values: new object[] { false, "Pérez", 2, "11223344", "juan.perez@gmail.com", 4000m, "Juan" });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Acreditado", "Apellido", "Dni", "Email", "Importe", "Nombre", "TipoInscripcionId" },
                values: new object[] { false, "Lopez", "44332211", "maria.lopez@gmail.com", 3000m, "Maria", 4 });

            migrationBuilder.UpdateData(
                table: "Inscripciones",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Acreditado", "Apellido", "Dni", "Email", "Nombre" },
                values: new object[] { false, "Fernandez", "55667788", "luis.fernandez@gmail.com", "Luis" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeleteDate", "Email", "Nombre", "Password", "TipoUsuario" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Admin", "admin123", 2 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeleteDate", "Email", "Nombre", "Password" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "perez@gmail.com", "Juan Perez", "juan123" });
        }
    }
}
