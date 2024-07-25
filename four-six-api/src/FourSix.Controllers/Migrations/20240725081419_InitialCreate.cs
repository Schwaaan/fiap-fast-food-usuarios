using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FourSix.Controllers.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Crm = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataAgenda = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Medico_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgendaHorario",
                columns: table => new
                {
                    AgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaHorario", x => new { x.AgendaId, x.Hora });
                    table.ForeignKey(
                        name: "FK_AgendaHorario_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medico",
                columns: new[] { "Id", "Crm", "Especialidade", "Nome" },
                values: new object[] { new Guid("fdd632ff-6852-4e89-9a1a-b8c16fb54b8b"), "1234", "Pediatra", "Dr. Jorge Mendoza" });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "Cpf", "Email", "Nome" },
                values: new object[] { new Guid("717b2fb9-4bbe-4a8c-8574-7808cd652e0b"), "12851671049", "joao.silva@gmail.com", "João da Silva Gomes" });

            migrationBuilder.InsertData(
                table: "Agenda",
                columns: new[] { "Id", "DataAgenda", "MedicoId" },
                values: new object[] { new Guid("78e3b8d0-be9a-4407-9304-c61788797808"), new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Local), new Guid("fdd632ff-6852-4e89-9a1a-b8c16fb54b8b") });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_MedicoId",
                table: "Agenda",
                column: "MedicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgendaHorario");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
