using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMS.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeeId = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    CompanyEmailId = table.Column<string>(type: "text", nullable: true),
                    Department = table.Column<string>(type: "text", nullable: true),
                    Designation = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LocationDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LocationDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StatusTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusTypes_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatusTypes_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuildingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    LocationDetailId = table.Column<int>(type: "integer", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuildingDetails_LocationDetails_LocationDetailId",
                        column: x => x.LocationDetailId,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuildingDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FloorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    BuildingDetailId = table.Column<int>(type: "integer", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FloorDetails_BuildingDetails_BuildingDetailId",
                        column: x => x.BuildingDetailId,
                        principalTable: "BuildingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FloorDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FloorDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: false),
                    FloorDetailId = table.Column<int>(type: "integer", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WingDetails_FloorDetails_FloorDetailId",
                        column: x => x.FloorDetailId,
                        principalTable: "FloorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WingDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WingDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeskDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Section = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    SeatNumber = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    LocationDetailId = table.Column<int>(type: "integer", nullable: true),
                    BuildingDetailId = table.Column<int>(type: "integer", nullable: true),
                    WingDetailId = table.Column<int>(type: "integer", nullable: true),
                    FloorDetailId = table.Column<int>(type: "integer", nullable: true),
                    StatusTypeId = table.Column<int>(type: "integer", nullable: true),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeskDetails_BuildingDetails_BuildingDetailId",
                        column: x => x.BuildingDetailId,
                        principalTable: "BuildingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_FloorDetails_FloorDetailId",
                        column: x => x.FloorDetailId,
                        principalTable: "FloorDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_LocationDetails_LocationDetailId",
                        column: x => x.LocationDetailId,
                        principalTable: "LocationDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_StatusTypes_StatusTypeId",
                        column: x => x.StatusTypeId,
                        principalTable: "StatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskDetails_WingDetails_WingDetailId",
                        column: x => x.WingDetailId,
                        principalTable: "WingDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    DeskId = table.Column<int>(type: "integer", nullable: true),
                    BookingFromDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    BookingToDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    BookedByUserId = table.Column<int>(type: "integer", nullable: true),
                    CancelledByUserId = table.Column<int>(type: "integer", nullable: true),
                    CancelledDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    BookingType = table.Column<int>(type: "integer", nullable: false),
                    Comments = table.Column<string>(type: "character varying(4000)", maxLength: 4000, nullable: true),
                    StatusTypeId = table.Column<int>(type: "integer", nullable: true),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingDetails_DeskDetails_DeskId",
                        column: x => x.DeskId,
                        principalTable: "DeskDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_StatusTypes_StatusTypeId",
                        column: x => x.StatusTypeId,
                        principalTable: "StatusTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Users_BookedByUserId",
                        column: x => x.BookedByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Users_CancelledByUserId",
                        column: x => x.CancelledByUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_AuditState",
                table: "BookingDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_BookedByUserId",
                table: "BookingDetails",
                column: "BookedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_CancelledByUserId",
                table: "BookingDetails",
                column: "CancelledByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_CreatedBy",
                table: "BookingDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_DeskId",
                table: "BookingDetails",
                column: "DeskId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_StatusTypeId",
                table: "BookingDetails",
                column: "StatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_UpdatedBy",
                table: "BookingDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetails_UserId",
                table: "BookingDetails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDetails_AuditState",
                table: "BuildingDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDetails_CreatedBy",
                table: "BuildingDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDetails_LocationDetailId",
                table: "BuildingDetails",
                column: "LocationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BuildingDetails_UpdatedBy",
                table: "BuildingDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_AuditState",
                table: "DeskDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_BuildingDetailId",
                table: "DeskDetails",
                column: "BuildingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_CreatedBy",
                table: "DeskDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_FloorDetailId",
                table: "DeskDetails",
                column: "FloorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_LocationDetailId",
                table: "DeskDetails",
                column: "LocationDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_StatusTypeId",
                table: "DeskDetails",
                column: "StatusTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_UpdatedBy",
                table: "DeskDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DeskDetails_WingDetailId",
                table: "DeskDetails",
                column: "WingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_FloorDetails_AuditState",
                table: "FloorDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_FloorDetails_BuildingDetailId",
                table: "FloorDetails",
                column: "BuildingDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_FloorDetails_CreatedBy",
                table: "FloorDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_FloorDetails_UpdatedBy",
                table: "FloorDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_AuditState",
                table: "LocationDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_CreatedBy",
                table: "LocationDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_LocationDetails_UpdatedBy",
                table: "LocationDetails",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StatusTypes_AuditState",
                table: "StatusTypes",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_StatusTypes_CreatedBy",
                table: "StatusTypes",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StatusTypes_UpdatedBy",
                table: "StatusTypes",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AuditState",
                table: "Users",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreatedBy",
                table: "Users",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UpdatedBy",
                table: "Users",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WingDetails_AuditState",
                table: "WingDetails",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_WingDetails_CreatedBy",
                table: "WingDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WingDetails_FloorDetailId",
                table: "WingDetails",
                column: "FloorDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_WingDetails_UpdatedBy",
                table: "WingDetails",
                column: "UpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetails");

            migrationBuilder.DropTable(
                name: "DeskDetails");

            migrationBuilder.DropTable(
                name: "StatusTypes");

            migrationBuilder.DropTable(
                name: "WingDetails");

            migrationBuilder.DropTable(
                name: "FloorDetails");

            migrationBuilder.DropTable(
                name: "BuildingDetails");

            migrationBuilder.DropTable(
                name: "LocationDetails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}