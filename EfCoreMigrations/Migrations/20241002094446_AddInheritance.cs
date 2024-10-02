using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddInheritance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_passengertrips_passenges_passenger_id",
                table: "passengertrips");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "trips",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "trips",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "state_owned_companies",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyCountry = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state_owned_companies", x => x.id);
                    table.ForeignKey(
                        name: "FK_state_owned_companies_companies_id",
                        column: x => x.id,
                        principalTable: "companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vip_passengers",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    VipBeforeDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vip_passengers", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "state_owned_companies");

            migrationBuilder.DropTable(
                name: "vip_passengers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "trips");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "trips");

            migrationBuilder.AddForeignKey(
                name: "FK_passengertrips_passenges_passenger_id",
                table: "passengertrips",
                column: "passenger_id",
                principalTable: "passenges",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
