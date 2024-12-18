﻿// <auto-generated />
using System;
using EntityFrameworkApp.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFrameworkApp.Migrations
{
    [DbContext(typeof(MyAppContext))]
    [Migration("20241116160936_NewSeed")]
    partial class NewSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-rc.2.24474.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DepartmentUser", b =>
                {
                    b.Property<int>("DepartmentsIdDepartment")
                        .HasColumnType("integer");

                    b.Property<int>("UsersIdUser")
                        .HasColumnType("integer");

                    b.HasKey("DepartmentsIdDepartment", "UsersIdUser");

                    b.HasIndex("UsersIdUser");

                    b.ToTable("DepartmentUser");
                });

            modelBuilder.Entity("EntityFrameworkApp.Entities.Department", b =>
                {
                    b.Property<int>("IdDepartment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdDepartment"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainMail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MainWww")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdDepartment");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            IdDepartment = 1,
                            Address = "123 Main St, Cityville",
                            DepartmentName = "HR",
                            Description = "Handles human resources tasks",
                            MainMail = "hr@company.com",
                            MainPhone = "123-456-7890",
                            MainWww = "www.hr.company.com"
                        },
                        new
                        {
                            IdDepartment = 2,
                            Address = "456 Elm St, Townsville",
                            DepartmentName = "IT",
                            Description = "Responsible for IT infrastructure",
                            MainMail = "it@company.com",
                            MainPhone = "987-654-3210",
                            MainWww = "www.it.company.com"
                        });
                });

            modelBuilder.Entity("EntityFrameworkApp.Entities.Payment", b =>
                {
                    b.Property<int>("IdPayment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdPayment"));

                    b.Property<float>("Bonus")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateOfPayment")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("IdUser")
                        .HasColumnType("integer");

                    b.Property<float>("Pay")
                        .HasColumnType("real");

                    b.HasKey("IdPayment");

                    b.HasIndex("IdUser");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            IdPayment = 1,
                            Bonus = 0f,
                            DateOfPayment = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 1,
                            Pay = 3000f
                        },
                        new
                        {
                            IdPayment = 2,
                            Bonus = 0f,
                            DateOfPayment = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 2,
                            Pay = 2500f
                        },
                        new
                        {
                            IdPayment = 3,
                            Bonus = 0f,
                            DateOfPayment = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 3,
                            Pay = 2800f
                        },
                        new
                        {
                            IdPayment = 4,
                            Bonus = 300f,
                            DateOfPayment = new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 4,
                            Pay = 2800f
                        },
                        new
                        {
                            IdPayment = 5,
                            Bonus = 150f,
                            DateOfPayment = new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 4,
                            Pay = 2800f
                        },
                        new
                        {
                            IdPayment = 6,
                            Bonus = 250f,
                            DateOfPayment = new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            IdUser = 4,
                            Pay = 2800f
                        });
                });

            modelBuilder.Entity("EntityFrameworkApp.Entities.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdUser");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            Description = "",
                            FirstName = "Stefan",
                            LastName = "Kowalski",
                            Password = "qwerty",
                            Username = "nick123"
                        },
                        new
                        {
                            IdUser = 2,
                            Description = "",
                            FirstName = "Anna",
                            LastName = "Nowak",
                            Password = "asdfgh",
                            Username = "anna456"
                        },
                        new
                        {
                            IdUser = 3,
                            Description = "",
                            FirstName = "John",
                            LastName = "Smith",
                            Password = "zxcvbn",
                            Username = "john789"
                        },
                        new
                        {
                            IdUser = 4,
                            Description = "",
                            FirstName = "Maria",
                            LastName = "Garcia",
                            Password = "poiuyt",
                            Username = "maria654"
                        },
                        new
                        {
                            IdUser = 5,
                            Description = "",
                            FirstName = "James",
                            LastName = "Brown",
                            Password = "lkjhgf",
                            Username = "james321"
                        },
                        new
                        {
                            IdUser = 6,
                            Description = "",
                            FirstName = "Emily",
                            LastName = "Davis",
                            Password = "mnbvcx",
                            Username = "emily987"
                        },
                        new
                        {
                            IdUser = 7,
                            Description = "",
                            FirstName = "Michael",
                            LastName = "Taylor",
                            Password = "trewq",
                            Username = "mike741"
                        },
                        new
                        {
                            IdUser = 8,
                            Description = "",
                            FirstName = "Sophia",
                            LastName = "Martinez",
                            Password = "gfdsa",
                            Username = "sophia852"
                        },
                        new
                        {
                            IdUser = 9,
                            Description = "",
                            FirstName = "David",
                            LastName = "Wilson",
                            Password = "plokij",
                            Username = "david963"
                        },
                        new
                        {
                            IdUser = 10,
                            Description = "",
                            FirstName = "Olivia",
                            LastName = "Thomas",
                            Password = "vfrtgb",
                            Username = "olivia159"
                        });
                });

            modelBuilder.Entity("DepartmentUser", b =>
                {
                    b.HasOne("EntityFrameworkApp.Entities.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsIdDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFrameworkApp.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFrameworkApp.Entities.Payment", b =>
                {
                    b.HasOne("EntityFrameworkApp.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EntityFrameworkApp.Entities.User", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
