using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class Creaciontablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "attendee",
                columns: table => new
                {
                    IdAttendee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendee", x => x.IdAttendee);
                });

            migrationBuilder.CreateTable(
                name: "event_Organizers",
                columns: table => new
                {
                    IdOrganizer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_Organizers", x => x.IdOrganizer);
                });

            migrationBuilder.CreateTable(
                name: "events",
                columns: table => new
                {
                    IdEvents = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_events", x => x.IdEvents);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    IdRoom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.IdRoom);
                });

            migrationBuilder.CreateTable(
                name: "event_Attendee_Registration",
                columns: table => new
                {
                    IdRegistration = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAttendee = table.Column<int>(type: "int", nullable: false),
                    attendeeIdAttendee = table.Column<int>(type: "int", nullable: true),
                    IdEvents = table.Column<int>(type: "int", nullable: false),
                    eventsIdEvents = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_event_Attendee_Registration", x => x.IdRegistration);
                    table.ForeignKey(
                        name: "FK_event_Attendee_Registration_attendee_attendeeIdAttendee",
                        column: x => x.attendeeIdAttendee,
                        principalTable: "attendee",
                        principalColumn: "IdAttendee");
                    table.ForeignKey(
                        name: "FK_event_Attendee_Registration_events_eventsIdEvents",
                        column: x => x.eventsIdEvents,
                        principalTable: "events",
                        principalColumn: "IdEvents");
                });

            migrationBuilder.CreateTable(
                name: "eventOrganizerAssociation",
                columns: table => new
                {
                    IdEventOrg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEvents = table.Column<int>(type: "int", nullable: false),
                    eventsIdEvents = table.Column<int>(type: "int", nullable: true),
                    IdOrganizer = table.Column<int>(type: "int", nullable: false),
                    event_OrganizersIdOrganizer = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventOrganizerAssociation", x => x.IdEventOrg);
                    table.ForeignKey(
                        name: "FK_eventOrganizerAssociation_event_Organizers_event_OrganizersIdOrganizer",
                        column: x => x.event_OrganizersIdOrganizer,
                        principalTable: "event_Organizers",
                        principalColumn: "IdOrganizer");
                    table.ForeignKey(
                        name: "FK_eventOrganizerAssociation_events_eventsIdEvents",
                        column: x => x.eventsIdEvents,
                        principalTable: "events",
                        principalColumn: "IdEvents");
                });

            migrationBuilder.CreateTable(
                name: "roomAttendeeRegistration",
                columns: table => new
                {
                    IdRegistration = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAttendee = table.Column<int>(type: "int", nullable: false),
                    attendeeIdAttendee = table.Column<int>(type: "int", nullable: true),
                    IdRoom = table.Column<int>(type: "int", nullable: false),
                    roomsIdRoom = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomAttendeeRegistration", x => x.IdRegistration);
                    table.ForeignKey(
                        name: "FK_roomAttendeeRegistration_attendee_attendeeIdAttendee",
                        column: x => x.attendeeIdAttendee,
                        principalTable: "attendee",
                        principalColumn: "IdAttendee");
                    table.ForeignKey(
                        name: "FK_roomAttendeeRegistration_rooms_roomsIdRoom",
                        column: x => x.roomsIdRoom,
                        principalTable: "rooms",
                        principalColumn: "IdRoom");
                });

            migrationBuilder.CreateIndex(
                name: "IX_event_Attendee_Registration_attendeeIdAttendee",
                table: "event_Attendee_Registration",
                column: "attendeeIdAttendee");

            migrationBuilder.CreateIndex(
                name: "IX_event_Attendee_Registration_eventsIdEvents",
                table: "event_Attendee_Registration",
                column: "eventsIdEvents");

            migrationBuilder.CreateIndex(
                name: "IX_eventOrganizerAssociation_event_OrganizersIdOrganizer",
                table: "eventOrganizerAssociation",
                column: "event_OrganizersIdOrganizer");

            migrationBuilder.CreateIndex(
                name: "IX_eventOrganizerAssociation_eventsIdEvents",
                table: "eventOrganizerAssociation",
                column: "eventsIdEvents");

            migrationBuilder.CreateIndex(
                name: "IX_roomAttendeeRegistration_attendeeIdAttendee",
                table: "roomAttendeeRegistration",
                column: "attendeeIdAttendee");

            migrationBuilder.CreateIndex(
                name: "IX_roomAttendeeRegistration_roomsIdRoom",
                table: "roomAttendeeRegistration",
                column: "roomsIdRoom");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "event_Attendee_Registration");

            migrationBuilder.DropTable(
                name: "eventOrganizerAssociation");

            migrationBuilder.DropTable(
                name: "roomAttendeeRegistration");

            migrationBuilder.DropTable(
                name: "event_Organizers");

            migrationBuilder.DropTable(
                name: "events");

            migrationBuilder.DropTable(
                name: "attendee");

            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
