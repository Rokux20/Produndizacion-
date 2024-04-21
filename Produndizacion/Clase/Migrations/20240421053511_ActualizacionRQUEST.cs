using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionRQUEST : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_event_Attendee_Registration_attendee_attendeeIdAttendee",
                table: "event_Attendee_Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_event_Attendee_Registration_events_eventsIdEvents",
                table: "event_Attendee_Registration");

            migrationBuilder.DropForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropForeignKey(
                name: "FK_eventOrganizerAssociation_events_eventsIdEvents",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropForeignKey(
                name: "FK_roomAttendeeRegistration_attendee_attendeeIdAttendee",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropForeignKey(
                name: "FK_roomAttendeeRegistration_rooms_roomsIdRoom",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropIndex(
                name: "IX_roomAttendeeRegistration_attendeeIdAttendee",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropIndex(
                name: "IX_roomAttendeeRegistration_roomsIdRoom",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropIndex(
                name: "IX_eventOrganizerAssociation_eventsIdEvents",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropIndex(
                name: "IX_event_Attendee_Registration_attendeeIdAttendee",
                table: "event_Attendee_Registration");

            migrationBuilder.DropIndex(
                name: "IX_event_Attendee_Registration_eventsIdEvents",
                table: "event_Attendee_Registration");

            migrationBuilder.DropColumn(
                name: "attendeeIdAttendee",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropColumn(
                name: "roomsIdRoom",
                table: "roomAttendeeRegistration");

            migrationBuilder.DropColumn(
                name: "eventsIdEvents",
                table: "eventOrganizerAssociation");

            migrationBuilder.DropColumn(
                name: "attendeeIdAttendee",
                table: "event_Attendee_Registration");

            migrationBuilder.DropColumn(
                name: "eventsIdEvents",
                table: "event_Attendee_Registration");

            migrationBuilder.RenameColumn(
                name: "event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                newName: "Event_OrganizersIdOrganizer");

            migrationBuilder.RenameIndex(
                name: "IX_eventOrganizerAssociation_event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                newName: "IX_eventOrganizerAssociation_Event_OrganizersIdOrganizer");

            migrationBuilder.AddForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                column: "Event_OrganizersIdOrganizer",
                principalTable: "event_Organizers",
                principalColumn: "IdOrganizer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation");

            migrationBuilder.RenameColumn(
                name: "Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                newName: "event_OrganizersIdOrganizer");

            migrationBuilder.RenameIndex(
                name: "IX_eventOrganizerAssociation_Event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                newName: "IX_eventOrganizerAssociation_event_OrganizersIdOrganizer");

            migrationBuilder.AddColumn<int>(
                name: "attendeeIdAttendee",
                table: "roomAttendeeRegistration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "roomsIdRoom",
                table: "roomAttendeeRegistration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eventsIdEvents",
                table: "eventOrganizerAssociation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "attendeeIdAttendee",
                table: "event_Attendee_Registration",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "eventsIdEvents",
                table: "event_Attendee_Registration",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_roomAttendeeRegistration_attendeeIdAttendee",
                table: "roomAttendeeRegistration",
                column: "attendeeIdAttendee");

            migrationBuilder.CreateIndex(
                name: "IX_roomAttendeeRegistration_roomsIdRoom",
                table: "roomAttendeeRegistration",
                column: "roomsIdRoom");

            migrationBuilder.CreateIndex(
                name: "IX_eventOrganizerAssociation_eventsIdEvents",
                table: "eventOrganizerAssociation",
                column: "eventsIdEvents");

            migrationBuilder.CreateIndex(
                name: "IX_event_Attendee_Registration_attendeeIdAttendee",
                table: "event_Attendee_Registration",
                column: "attendeeIdAttendee");

            migrationBuilder.CreateIndex(
                name: "IX_event_Attendee_Registration_eventsIdEvents",
                table: "event_Attendee_Registration",
                column: "eventsIdEvents");

            migrationBuilder.AddForeignKey(
                name: "FK_event_Attendee_Registration_attendee_attendeeIdAttendee",
                table: "event_Attendee_Registration",
                column: "attendeeIdAttendee",
                principalTable: "attendee",
                principalColumn: "IdAttendee");

            migrationBuilder.AddForeignKey(
                name: "FK_event_Attendee_Registration_events_eventsIdEvents",
                table: "event_Attendee_Registration",
                column: "eventsIdEvents",
                principalTable: "events",
                principalColumn: "IdEvents");

            migrationBuilder.AddForeignKey(
                name: "FK_eventOrganizerAssociation_event_Organizers_event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                column: "event_OrganizersIdOrganizer",
                principalTable: "event_Organizers",
                principalColumn: "IdOrganizer");

            migrationBuilder.AddForeignKey(
                name: "FK_eventOrganizerAssociation_events_eventsIdEvents",
                table: "eventOrganizerAssociation",
                column: "eventsIdEvents",
                principalTable: "events",
                principalColumn: "IdEvents");

            migrationBuilder.AddForeignKey(
                name: "FK_roomAttendeeRegistration_attendee_attendeeIdAttendee",
                table: "roomAttendeeRegistration",
                column: "attendeeIdAttendee",
                principalTable: "attendee",
                principalColumn: "IdAttendee");

            migrationBuilder.AddForeignKey(
                name: "FK_roomAttendeeRegistration_rooms_roomsIdRoom",
                table: "roomAttendeeRegistration",
                column: "roomsIdRoom",
                principalTable: "rooms",
                principalColumn: "IdRoom");
        }
    }
}
