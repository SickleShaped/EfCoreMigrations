using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreMigrations.Migrations
{
    /// <inheritdoc />
    public partial class AddJson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VipBeforeDate",
                table: "vip_passengers",
                newName: "vip_before_date");

            migrationBuilder.AddColumn<string>(
                name: "JsonData",
                table: "vip_passengers",
                type: "jsonb",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JsonData",
                table: "vip_passengers");

            migrationBuilder.RenameColumn(
                name: "vip_before_date",
                table: "vip_passengers",
                newName: "VipBeforeDate");
        }
    }
}
