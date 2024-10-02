using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class SomeEdits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_passengers_PassengerId",
                table: "passengertrips");

            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_trips_TripId",
                table: "passengertrips");

            migrationBuilder.DropForeignKey(
                name: "FK_trips_companies_CompanyId",
                table: "trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passengers",
                table: "passengers");

            migrationBuilder.DropColumn(
                name: "RandomField",
                table: "trips");

            migrationBuilder.RenameTable(
                name: "passengers",
                newName: "passenges");

            migrationBuilder.RenameColumn(
                name: "Plane",
                table: "trips",
                newName: "plane");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "trips",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TownTo",
                table: "trips",
                newName: "town_to");

            migrationBuilder.RenameColumn(
                name: "TownFrom",
                table: "trips",
                newName: "town_from");

            migrationBuilder.RenameColumn(
                name: "TimeOut",
                table: "trips",
                newName: "time_out");

            migrationBuilder.RenameColumn(
                name: "TimeIn",
                table: "trips",
                newName: "time_in");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "trips",
                newName: "company_id");

            migrationBuilder.RenameIndex(
                name: "IX_trips_Id",
                table: "trips",
                newName: "IX_trips_id");

            migrationBuilder.RenameIndex(
                name: "IX_trips_CompanyId",
                table: "trips",
                newName: "IX_trips_company_id");

            migrationBuilder.RenameColumn(
                name: "Place",
                table: "passengertrips",
                newName: "place");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "passengertrips",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TripId",
                table: "passengertrips",
                newName: "trip_id");

            migrationBuilder.RenameColumn(
                name: "PassengerId",
                table: "passengertrips",
                newName: "passenger_id");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_Id",
                table: "passengertrips",
                newName: "IX_passengertrips_id");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_TripId",
                table: "passengertrips",
                newName: "IX_passengertrips_trip_id");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_PassengerId",
                table: "passengertrips",
                newName: "IX_passengertrips_passenger_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "companies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "companies",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "passenges",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "passenges",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_passenges",
                table: "passenges",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_passenges_passenger_id",
                table: "passengertrips",
                column: "passenger_id",
                principalTable: "passenges",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_trips_trip_id",
                table: "passengertrips",
                column: "trip_id",
                principalTable: "trips",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trips_companies_company_id",
                table: "trips",
                column: "company_id",
                principalTable: "companies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_passenges_passenger_id",
                table: "passengertrips");

            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_trips_trip_id",
                table: "passengertrips");

            migrationBuilder.DropForeignKey(
                name: "FK_trips_companies_company_id",
                table: "trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_passenges",
                table: "passenges");

            migrationBuilder.RenameTable(
                name: "passenges",
                newName: "passengers");

            migrationBuilder.RenameColumn(
                name: "plane",
                table: "trips",
                newName: "Plane");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "trips",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "town_to",
                table: "trips",
                newName: "TownTo");

            migrationBuilder.RenameColumn(
                name: "town_from",
                table: "trips",
                newName: "TownFrom");

            migrationBuilder.RenameColumn(
                name: "time_out",
                table: "trips",
                newName: "TimeOut");

            migrationBuilder.RenameColumn(
                name: "time_in",
                table: "trips",
                newName: "TimeIn");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "trips",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_trips_id",
                table: "trips",
                newName: "IX_trips_Id");

            migrationBuilder.RenameIndex(
                name: "IX_trips_company_id",
                table: "trips",
                newName: "IX_trips_CompanyId");

            migrationBuilder.RenameColumn(
                name: "place",
                table: "passengertrips",
                newName: "Place");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "passengertrips",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "trip_id",
                table: "passengertrips",
                newName: "TripId");

            migrationBuilder.RenameColumn(
                name: "passenger_id",
                table: "passengertrips",
                newName: "PassengerId");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_id",
                table: "passengertrips",
                newName: "IX_passengertrips_Id");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_trip_id",
                table: "passengertrips",
                newName: "IX_passengertrips_TripId");

            migrationBuilder.RenameIndex(
                name: "IX_passengertrips_passenger_id",
                table: "passengertrips",
                newName: "IX_passengertrips_PassengerId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "companies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "companies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "passengers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "passengers",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "RandomField",
                table: "trips",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_passengers",
                table: "passengers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_passengers_PassengerId",
                table: "passengertrips",
                column: "PassengerId",
                principalTable: "passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_trips_TripId",
                table: "passengertrips",
                column: "TripId",
                principalTable: "trips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_trips_companies_CompanyId",
                table: "trips",
                column: "CompanyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
