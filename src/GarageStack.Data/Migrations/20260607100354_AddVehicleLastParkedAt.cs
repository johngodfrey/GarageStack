using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GarageStack.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleLastParkedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastParkedAt",
                table: "Vehicles",
                type: "timestamp with time zone",
                nullable: true);

            // IX_TelemetrySnapshots_VehicleId_RecordedAt already exists from InitialCreate;
            // do not recreate it here or upgrade will fail with a duplicate relation error.
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastParkedAt",
                table: "Vehicles");
        }
    }
}
