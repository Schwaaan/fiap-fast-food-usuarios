using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FourSix.Controllers.Migrations
{
    /// <inheritdoc />
    public partial class EditAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AgendaHorario",
                table: "AgendaHorario");

            migrationBuilder.DropColumn(
                name: "Hora",
                table: "AgendaHorario");

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraInicio",
                table: "AgendaHorario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "HoraFim",
                table: "AgendaHorario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgendaHorario",
                table: "AgendaHorario",
                columns: new[] { "AgendaId", "HoraInicio" });

            migrationBuilder.UpdateData(
                table: "Agenda",
                keyColumn: "Id",
                keyValue: new Guid("78e3b8d0-be9a-4407-9304-c61788797808"),
                column: "DataAgenda",
                value: new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AgendaHorario",
                columns: new[] { "AgendaId", "HoraInicio", "HoraFim", "Status" },
                values: new object[,]
                {
                    { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Disponível" },
                    { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), new DateTime(2024, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), "Disponível" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AgendaHorario",
                table: "AgendaHorario");

            migrationBuilder.DeleteData(
                table: "AgendaHorario",
                keyColumns: new[] { "AgendaId", "HoraInicio" },
                keyColumnTypes: new[] { "uniqueidentifier", "datetime2" },
                keyValues: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), new DateTime(2024, 8, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DeleteData(
                table: "AgendaHorario",
                keyColumns: new[] { "AgendaId", "HoraInicio" },
                keyColumnTypes: new[] { "uniqueidentifier", "datetime2" },
                keyValues: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), new DateTime(2024, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "AgendaHorario");

            migrationBuilder.DropColumn(
                name: "HoraFim",
                table: "AgendaHorario");

            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "AgendaHorario",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgendaHorario",
                table: "AgendaHorario",
                columns: new[] { "AgendaId", "Hora" });

            migrationBuilder.UpdateData(
                table: "Agenda",
                keyColumn: "Id",
                keyValue: new Guid("78e3b8d0-be9a-4407-9304-c61788797808"),
                column: "DataAgenda",
                value: new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
