using Microsoft.EntityFrameworkCore.Migrations;

namespace FMS.Data.Migrations
{
    public partial class Remove5thFloorFromPune : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Delete desks from pune 5th floor
            migrationBuilder.DeleteData(
            table: "DeskDetails",
            keyColumn: "FloorDetailId",
            keyValue: "6");

            // Delete wings from pune 5th floor
            migrationBuilder.DeleteData(
            table: "WingDetails",
            keyColumn: "FloorDetailId",
            keyValue: "6");

            // Delete pune 5th floor
            migrationBuilder.DeleteData(
            table: "FloorDetails",
            keyColumn: "Id",
            keyValue: "6");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
