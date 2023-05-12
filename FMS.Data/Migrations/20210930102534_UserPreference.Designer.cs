﻿// <auto-generated />
using System;
using FMS.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FMS.Data.Migrations
{
    [DbContext(typeof(FMSContext))]
    [Migration("20210930102534_UserPreference")]
    partial class UserPreference
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FMS.Entities.Models.BookingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("BookedByUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("BookingFromDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("BookingToDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("BookingType")
                        .HasColumnType("integer");

                    b.Property<int?>("CancelledByUserId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CancelledDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Comments")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("DeskId")
                        .HasColumnType("integer");

                    b.Property<int?>("StatusTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("BookedByUserId");

                    b.HasIndex("CancelledByUserId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("DeskId");

                    b.HasIndex("StatusTypeId");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("UserId");

                    b.ToTable("BookingDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.BuildingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LocationDetailId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("LocationDetailId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("BuildingDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.DeskDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("BuildingDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FloorDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("LocationDetailId")
                        .HasColumnType("integer");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Section")
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int?>("StatusTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("WingDetailId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("BuildingDetailId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("FloorDetailId");

                    b.HasIndex("LocationDetailId");

                    b.HasIndex("StatusTypeId");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("WingDetailId");

                    b.ToTable("DeskDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.FloorDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("BuildingDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("BuildingDetailId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("FloorDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.LocationDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("LocationDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.StatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("StatusTypes");
                });

            modelBuilder.Entity("FMS.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<string>("CompanyEmailId")
                        .HasColumnType("text");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Department")
                        .HasColumnType("text");

                    b.Property<string>("Designation")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FMS.Entities.Models.UserPreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("BuildingDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FloorDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("LocationDetailId")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserPreferenceType")
                        .HasColumnType("integer");

                    b.Property<int?>("WingDetailId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("BuildingDetailId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("FloorDetailId");

                    b.HasIndex("LocationDetailId");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("UserId");

                    b.HasIndex("WingDetailId");

                    b.ToTable("UserPreferences");
                });

            modelBuilder.Entity("FMS.Entities.Models.WingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AuditState")
                        .HasColumnType("integer");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("FloorDetailId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(4000)
                        .HasColumnType("character varying(4000)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AuditState");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("FloorDetailId");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("WingDetails");
                });

            modelBuilder.Entity("FMS.Entities.Models.BookingDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "BookedByUser")
                        .WithMany()
                        .HasForeignKey("BookedByUserId");

                    b.HasOne("FMS.Entities.Models.User", "CancelledByUser")
                        .WithMany()
                        .HasForeignKey("CancelledByUserId");

                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.DeskDetail", "Desk")
                        .WithMany()
                        .HasForeignKey("DeskId");

                    b.HasOne("FMS.Entities.Models.StatusType", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusTypeId");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.HasOne("FMS.Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("BookedByUser");

                    b.Navigation("CancelledByUser");

                    b.Navigation("CreatedByUser");

                    b.Navigation("Desk");

                    b.Navigation("StatusType");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FMS.Entities.Models.BuildingDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.LocationDetail", "LocationDetail")
                        .WithMany()
                        .HasForeignKey("LocationDetailId");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("LocationDetail");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("FMS.Entities.Models.DeskDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.BuildingDetail", "BuildingDetail")
                        .WithMany()
                        .HasForeignKey("BuildingDetailId");

                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.FloorDetail", "FloorDetail")
                        .WithMany()
                        .HasForeignKey("FloorDetailId");

                    b.HasOne("FMS.Entities.Models.LocationDetail", "LocationDetail")
                        .WithMany()
                        .HasForeignKey("LocationDetailId");

                    b.HasOne("FMS.Entities.Models.StatusType", "StatusType")
                        .WithMany()
                        .HasForeignKey("StatusTypeId");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.HasOne("FMS.Entities.Models.WingDetail", "WingDetail")
                        .WithMany()
                        .HasForeignKey("WingDetailId");

                    b.Navigation("BuildingDetail");

                    b.Navigation("CreatedByUser");

                    b.Navigation("FloorDetail");

                    b.Navigation("LocationDetail");

                    b.Navigation("StatusType");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("WingDetail");
                });

            modelBuilder.Entity("FMS.Entities.Models.FloorDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.BuildingDetail", "BuildingDetail")
                        .WithMany()
                        .HasForeignKey("BuildingDetailId");

                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("BuildingDetail");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("FMS.Entities.Models.LocationDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("FMS.Entities.Models.StatusType", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("FMS.Entities.Models.User", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("FMS.Entities.Models.UserPreference", b =>
                {
                    b.HasOne("FMS.Entities.Models.BuildingDetail", "BuildingDetail")
                        .WithMany()
                        .HasForeignKey("BuildingDetailId");

                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.FloorDetail", "FloorDetail")
                        .WithMany()
                        .HasForeignKey("FloorDetailId");

                    b.HasOne("FMS.Entities.Models.LocationDetail", "LocationDetail")
                        .WithMany()
                        .HasForeignKey("LocationDetailId");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.HasOne("FMS.Entities.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("FMS.Entities.Models.WingDetail", "WingDetail")
                        .WithMany()
                        .HasForeignKey("WingDetailId");

                    b.Navigation("BuildingDetail");

                    b.Navigation("CreatedByUser");

                    b.Navigation("FloorDetail");

                    b.Navigation("LocationDetail");

                    b.Navigation("UpdatedByUser");

                    b.Navigation("User");

                    b.Navigation("WingDetail");
                });

            modelBuilder.Entity("FMS.Entities.Models.WingDetail", b =>
                {
                    b.HasOne("FMS.Entities.Models.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("FMS.Entities.Models.FloorDetail", "FloorDetail")
                        .WithMany()
                        .HasForeignKey("FloorDetailId");

                    b.HasOne("FMS.Entities.Models.User", "UpdatedByUser")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");

                    b.Navigation("CreatedByUser");

                    b.Navigation("FloorDetail");

                    b.Navigation("UpdatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
