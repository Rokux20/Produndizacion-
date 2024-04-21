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
    [Migration("20240421053737_ActualizacionDeleted")]
    partial class ActualizacionDeleted
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

                    b.HasKey("IdEventOrg");

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

                    b.HasKey("IdRegistration");

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

                    b.HasKey("IdAttendeeR");

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
#pragma warning restore 612, 618
        }
    }
}
