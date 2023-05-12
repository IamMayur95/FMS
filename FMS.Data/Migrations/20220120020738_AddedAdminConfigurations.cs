using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMS.Data.Migrations
{
    public partial class AddedAdminConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminConfiguration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminConfiguration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminConfiguration_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminConfiguration_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeskAllocateDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeskId = table.Column<int>(type: "integer", nullable: false),
                    Department = table.Column<string>(type: "text", nullable: true),
                    OtherDepartmentOrTeam = table.Column<string>(type: "text", nullable: true),
                    IsBlock = table.Column<bool>(type: "boolean", nullable: false),
                    AuditState = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: true),
                    UpdatedBy = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeskAllocateDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeskAllocateDetail_Users_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeskAllocateDetail_Users_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminConfiguration_AuditState",
                table: "AdminConfiguration",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_AdminConfiguration_CreatedBy",
                table: "AdminConfiguration",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdminConfiguration_UpdatedBy",
                table: "AdminConfiguration",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DeskAllocateDetail_AuditState",
                table: "DeskAllocateDetail",
                column: "AuditState");

            migrationBuilder.CreateIndex(
                name: "IX_DeskAllocateDetail_CreatedBy",
                table: "DeskAllocateDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DeskAllocateDetail_UpdatedBy",
                table: "DeskAllocateDetail",
                column: "UpdatedBy");

            migrationBuilder.InsertData(table: "AdminConfiguration",
            columns: new[] { "Key", "Value", "AuditState", "CreatedDate" },
            values: new object[]
            {
                "MaxDaysForDeskBooking",
                "5",
                "1",
                DateTime.Now
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminConfiguration");

            migrationBuilder.DropTable(
                name: "DeskAllocateDetail");
        }
    }
}
