using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TransnetWebAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingPrescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    doctorid = table.Column<int>(name: "doctor_id", type: "INTEGER", nullable: false),
                    medicineid = table.Column<int>(name: "medicine_id", type: "INTEGER", nullable: false),
                    patiantid = table.Column<int>(name: "patiant_id", type: "INTEGER", nullable: false),
                    date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    time = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prescriptions");
        }
    }
}
