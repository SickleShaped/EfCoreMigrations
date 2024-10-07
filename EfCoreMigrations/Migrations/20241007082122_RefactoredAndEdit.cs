using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class RefactoredAndEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_trips_trip_id",
                table: "passengertrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengertrips",
                table: "passengertrips");

            migrationBuilder.DropIndex(
                name: "IX_passengertrips_id",
                table: "passengertrips");

            migrationBuilder.DropIndex(
                name: "IX_passengertrips_trip_id",
                table: "passengertrips");

            migrationBuilder.DropColumn(
                name: "id",
                table: "passengertrips");

            migrationBuilder.RenameTable(
                name: "passengertrips",
                newName: "passengerTrips");

            migrationBuilder.RenameColumn(
                name: "VipStatus",
                table: "vip_passengers",
                newName: "vip_status");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_passenger_id",
                table: "passengerTrips",
                newName: "IX_passengerTrips_passenger_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengerTrips",
                table: "passengerTrips",
                columns: new[] { "trip_id", "passenger_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_passengerTrips_trips_trip_id",
                table: "passengerTrips",
                column: "trip_id",
                principalTable: "trips",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengerTrips_trips_trip_id",
                table: "passengerTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengerTrips",
                table: "passengerTrips");

            migrationBuilder.RenameTable(
                name: "passengerTrips",
                newName: "passengertrips");

            migrationBuilder.RenameColumn(
                name: "vip_status",
                table: "vip_passengers",
                newName: "VipStatus");

            migrationBuilder.RenameIndex(
                name: "IX_passengerTrips_passenger_id",
                table: "passengertrips",
                newName: "IX_passengertrips_passenger_id");

            migrationBuilder.AddColumn<Guid>(
                name: "id",
                table: "passengertrips",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengertrips",
                table: "passengertrips",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_passengertrips_id",
                table: "passengertrips",
                column: "id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_passengertrips_trip_id",
                table: "passengertrips",
                column: "trip_id");

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_trips_trip_id",
                table: "passengertrips",
                column: "trip_id",
                principalTable: "trips",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
