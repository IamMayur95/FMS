using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMS.Data.Migrations
{
    public partial class UploadPhotoWithDetailsAndPhotoType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhotoType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsLocationRequired = table.Column<bool>(type: "boolean", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoType_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoType_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<string>(type: "varchar", nullable: true),
                    LocationId = table.Column<int>(type: "integer", nullable: true),
                    LocationDetailId = table.Column<int>(type: "integer", nullable: true),
                    BuildingId = table.Column<int>(type: "integer", nullable: true),
                    BuildingDetailId = table.Column<int>(type: "integer", nullable: true),
                    FloorId = table.Column<int>(type: "integer", nullable: true),
                    FloorDetailId = table.Column<int>(type: "integer", nullable: true),
                    WingId = table.Column<int>(type: "integer", nullable: true),
                    WingDetailId = table.Column<int>(type: "integer", nullable: true),
                    OtherDetails = table.Column<string>(type: "text", nullable: true),
                    MetaKeys = table.Column<string>(type: "text", nullable: true),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_BuildingDetails_BuildingDetailId",
                        column: x => x.BuildingDetailId,
                        principalTable: "BuildingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_FloorDetails_FloorDetailId",
                        column: x => x.FloorDetailId,
                        principalTable: "FloorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_LocationDetails_LocationDetailId",
                        column: x => x.LocationDetailId,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_PhotoType_Type",
                        column: x => x.Type,
                        principalTable: "PhotoType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoDetails_WingDetails_WingDetailId",
                        column: x => x.WingDetailId,
                        principalTable: "WingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_AuditState",
                table: "PhotoDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_BuildingDetailId",
                table: "PhotoDetails",
                column: "BuildingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_CreatedBy",
                table: "PhotoDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_FloorDetailId",
                table: "PhotoDetails",
                column: "FloorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_LocationDetailId",
                table: "PhotoDetails",
                column: "LocationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_Type",
                table: "PhotoDetails",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_UpdatedBy",
                table: "PhotoDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoDetails_WingDetailId",
                table: "PhotoDetails",
                column: "WingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoType_AuditState",
                table: "PhotoType",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoType_CreatedBy",
                table: "PhotoType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoType_UpdatedBy",
                table: "PhotoType",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhotoDetails");

            migrationBuilder.DropTable(
                name: "PhotoType");
        }
    }
}
