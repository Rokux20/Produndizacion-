﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase.Migrations
{
    /// <inheritdoc />
    public partial class Prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "event_Attendee_Registration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "event_Attendee_Registration");
        }
    }
}
