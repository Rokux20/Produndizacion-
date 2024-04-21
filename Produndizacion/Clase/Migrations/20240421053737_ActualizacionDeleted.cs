using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropIndex(
                name: "IX_eventOrganizerAssociation_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation");

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
                name: "Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_eventOrganizerAssociation_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                column: "Event_OrganizersIdOrganizer");

            migrationBuilder.AddForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                column: "Event_OrganizersIdOrganizer",
                principalTable: "event_Organizers",
                principalColumn: "IdOrganizer");
        }
    }
}
