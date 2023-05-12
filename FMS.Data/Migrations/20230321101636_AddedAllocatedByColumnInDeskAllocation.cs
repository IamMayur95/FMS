using Microsoft.EntityFrameworkCore.Migrations;

namespace FMS.Data.Migrations
{
    public partial class AddedAllocatedByColumnInDeskAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AllocatedByUserId",
                table: "DeskAllocateDetail",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeskAllocateDetail_AllocatedByUserId",
                table: "DeskAllocateDetail",
                column: "AllocatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeskAllocateDetail_Users_AllocatedByUserId",
                table: "DeskAllocateDetail",
                column: "AllocatedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeskAllocateDetail_Users_AllocatedByUserId",
                table: "DeskAllocateDetail");

            migrationBuilder.DropIndex(
                name: "IX_DeskAllocateDetail_AllocatedByUserId",
                table: "DeskAllocateDetail");

            migrationBuilder.DropColumn(
                name: "AllocatedByUserId",
                table: "DeskAllocateDetail");
        }
    }
}
