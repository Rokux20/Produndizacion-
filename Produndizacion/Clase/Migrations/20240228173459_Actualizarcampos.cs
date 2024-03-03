using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class Actualizarcampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRegistration",
                table: "roomAttendeeRegistration",
                newName: "IdAttendeeR");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAttendeeR",
                table: "roomAttendeeRegistration",
                newName: "IdRegistration");
        }
    }
}
