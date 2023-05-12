using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMS.Data.Migrations
{
    public partial class UserPreference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserPreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    UserPreferenceType = table.Column<int>(type: "integer", nullable: true),
                    LocationDetailId = table.Column<int>(type: "integer", nullable: true),
                    BuildingDetailId = table.Column<int>(type: "integer", nullable: true),
                    WingDetailId = table.Column<int>(type: "integer", nullable: true),
                    FloorDetailId = table.Column<int>(type: "integer", nullable: true),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreferences_BuildingDetails_BuildingDetailId",
                        column: x => x.BuildingDetailId,
                        principalTable: "BuildingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_FloorDetails_FloorDetailId",
                        column: x => x.FloorDetailId,
                        principalTable: "FloorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_LocationDetails_LocationDetailId",
                        column: x => x.LocationDetailId,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserPreferences_WingDetails_WingDetailId",
                        column: x => x.WingDetailId,
                        principalTable: "WingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_AuditState",
                table: "UserPreferences",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_BuildingDetailId",
                table: "UserPreferences",
                column: "BuildingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_CreatedBy",
                table: "UserPreferences",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_FloorDetailId",
                table: "UserPreferences",
                column: "FloorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_LocationDetailId",
                table: "UserPreferences",
                column: "LocationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_UpdatedBy",
                table: "UserPreferences",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_UserId",
                table: "UserPreferences",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreferences_WingDetailId",
                table: "UserPreferences",
                column: "WingDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPreferences");
        }
    }
}
