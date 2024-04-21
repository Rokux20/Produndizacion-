using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class NombreDeLaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "roomAttendeeRegistration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "events",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "eventOrganizerAssociation",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "event_Organizers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleted",
                table: "event_Attendee_Registration",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "deleted",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "events");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "event_Organizers");

            migrationBuilder.DropColumn(
                name: "deleted",
                table: "event_Attendee_Registration");
        }
    }
}
