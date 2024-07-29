﻿// <auto-generated />
using System;
using GRHs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GRHs.Data.First
{
    [DbContext(typeof(EmployeeManagementDbContext))]
    [Migration("20240728205053_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GRHs.Entities.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AdminID");

                    b.HasIndex("UserID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GRHs.Entities.Attestation", b =>
                {
                    b.Property<int>("AttestationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IssueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttestationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Attestations");
                });

            modelBuilder.Entity("GRHs.Entities.Calendar", b =>
                {
                    b.Property<int>("CalendarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("CalendarID");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("GRHs.Entities.CalendarHoliday", b =>
                {
                    b.Property<int>("CalendarID")
                        .HasColumnType("int");

                    b.Property<int>("HolidayID")
                        .HasColumnType("int");

                    b.HasKey("CalendarID", "HolidayID");

                    b.HasIndex("HolidayID");

                    b.ToTable("CalendarHolidays");
                });

            modelBuilder.Entity("GRHs.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PositionID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("PositionID");

                    b.HasIndex("UserID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("GRHs.Entities.Holiday", b =>
                {
                    b.Property<int>("HolidayID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HolidayID");

                    b.ToTable("Holidays");
                });

            modelBuilder.Entity("GRHs.Entities.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionID");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("GRHs.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GRHs.Entities.Admin", b =>
                {
                    b.HasOne("GRHs.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GRHs.Entities.Attestation", b =>
                {
                    b.HasOne("GRHs.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GRHs.Entities.CalendarHoliday", b =>
                {
                    b.HasOne("GRHs.Entities.Calendar", "Calendar")
                        .WithMany("CalendarHolidays")
                        .HasForeignKey("CalendarID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRHs.Entities.Holiday", "Holiday")
                        .WithMany("CalendarHolidays")
                        .HasForeignKey("HolidayID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GRHs.Entities.Employee", b =>
                {
                    b.HasOne("GRHs.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GRHs.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}