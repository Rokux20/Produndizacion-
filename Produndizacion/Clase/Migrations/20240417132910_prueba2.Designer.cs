﻿// <auto-generated />
using System;
using Clase.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Clase.Migrations
{
    [DbContext(typeof(ProyectbContext))]
    [Migration("20240417132910_prueba2")]
    partial class prueba2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Clase.Models.Attendee", b =>
                {
                    b.Property<int>("IdAttendee")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAttendee"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAttendee");

                    b.ToTable("attendee");
                });

            modelBuilder.Entity("Clase.Models.EventOrganizerAssociation", b =>
                {
                    b.Property<int>("IdEventOrg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEventOrg"));

                    b.Property<int>("IdEvents")
                        .HasColumnType("int");

                    b.Property<int>("IdOrganizer")
                        .HasColumnType("int");

                    b.Property<int?>("event_OrganizersIdOrganizer")
                        .HasColumnType("int");

                    b.Property<int?>("eventsIdEvents")
                        .HasColumnType("int");

                    b.HasKey("IdEventOrg");

                    b.HasIndex("event_OrganizersIdOrganizer");

                    b.HasIndex("eventsIdEvents");

                    b.ToTable("eventOrganizerAssociation");
                });

            modelBuilder.Entity("Clase.Models.Event_Attendee_Registration", b =>
                {
                    b.Property<int>("IdRegistration")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRegistration"));

                    b.Property<int>("IdAttendee")
                        .HasColumnType("int");

                    b.Property<int>("IdEvents")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("attendeeIdAttendee")
                        .HasColumnType("int");

                    b.Property<int?>("eventsIdEvents")
                        .HasColumnType("int");

                    b.HasKey("IdRegistration");

                    b.HasIndex("attendeeIdAttendee");

                    b.HasIndex("eventsIdEvents");

                    b.ToTable("event_Attendee_Registration");
                });

            modelBuilder.Entity("Clase.Models.Event_Organizers", b =>
                {
                    b.Property<int>("IdOrganizer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOrganizer"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOrganizer");

                    b.ToTable("event_Organizers");
                });

            modelBuilder.Entity("Clase.Models.Events", b =>
                {
                    b.Property<int>("IdEvents")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEvents"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEvents");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Clase.Models.RoomAttendeeRegistration", b =>
                {
                    b.Property<int>("IdAttendeeR")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAttendeeR"));

                    b.Property<int>("IdAttendee")
                        .HasColumnType("int");

                    b.Property<int>("IdRoom")
                        .HasColumnType("int");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("attendeeIdAttendee")
                        .HasColumnType("int");

                    b.Property<int?>("roomsIdRoom")
                        .HasColumnType("int");

                    b.HasKey("IdAttendeeR");

                    b.HasIndex("attendeeIdAttendee");

                    b.HasIndex("roomsIdRoom");

                    b.ToTable("roomAttendeeRegistration");
                });

            modelBuilder.Entity("Clase.Models.Rooms", b =>
                {
                    b.Property<int>("IdRoom")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRoom"));

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRoom");

                    b.ToTable("rooms");
                });

            modelBuilder.Entity("Clase.Models.EventOrganizerAssociation", b =>
                {
                    b.HasOne("Clase.Models.Event_Organizers", "event_Organizers")
                        .WithMany("eventOrganizerAssociation")
                        .HasForeignKey("event_OrganizersIdOrganizer");

                    b.HasOne("Clase.Models.Events", "events")
                        .WithMany("eventOrganizerAssociation")
                        .HasForeignKey("eventsIdEvents");

                    b.Navigation("event_Organizers");

                    b.Navigation("events");
                });

            modelBuilder.Entity("Clase.Models.Event_Attendee_Registration", b =>
                {
                    b.HasOne("Clase.Models.Attendee", "attendee")
                        .WithMany("event_Attendee_Registration")
                        .HasForeignKey("attendeeIdAttendee");

                    b.HasOne("Clase.Models.Events", "events")
                        .WithMany("event_Attendee_Registration")
                        .HasForeignKey("eventsIdEvents");

                    b.Navigation("attendee");

                    b.Navigation("events");
                });

            modelBuilder.Entity("Clase.Models.RoomAttendeeRegistration", b =>
                {
                    b.HasOne("Clase.Models.Attendee", "attendee")
                        .WithMany("roomAttendeeRegistration")
                        .HasForeignKey("attendeeIdAttendee");

                    b.HasOne("Clase.Models.Rooms", "rooms")
                        .WithMany("roomAttendeeRegistration")
                        .HasForeignKey("roomsIdRoom");

                    b.Navigation("attendee");

                    b.Navigation("rooms");
                });

            modelBuilder.Entity("Clase.Models.Attendee", b =>
                {
                    b.Navigation("event_Attendee_Registration");

                    b.Navigation("roomAttendeeRegistration");
                });

            modelBuilder.Entity("Clase.Models.Event_Organizers", b =>
                {
                    b.Navigation("eventOrganizerAssociation");
                });

            modelBuilder.Entity("Clase.Models.Events", b =>
                {
                    b.Navigation("eventOrganizerAssociation");

                    b.Navigation("event_Attendee_Registration");
                });

            modelBuilder.Entity("Clase.Models.Rooms", b =>
                {
                    b.Navigation("roomAttendeeRegistration");
                });
#pragma warning restore 612, 618
        }
    }
}
