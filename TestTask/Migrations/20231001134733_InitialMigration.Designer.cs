﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.Data;

#nullable disable

namespace TestTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231001134733_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestTask.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 10,
                            ProductName = "Apple",
                            Quantity = 5,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Price = 30,
                            ProductName = "Lemon",
                            Quantity = 2,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Price = 5,
                            ProductName = "Cucumber",
                            Quantity = 10,
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Price = 7,
                            ProductName = "Cabbage",
                            Quantity = 2,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Price = 8,
                            ProductName = "Onion",
                            Quantity = 6,
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Price = 9,
                            ProductName = "Carrot",
                            Quantity = 5,
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            Price = 40,
                            ProductName = "Mango",
                            Quantity = 2,
                            UserId = 3
                        },
                        new
                        {
                            Id = 8,
                            Price = 45,
                            ProductName = "Orange",
                            Quantity = 5,
                            UserId = 4
                        },
                        new
                        {
                            Id = 9,
                            Price = 100,
                            ProductName = "Watermelon",
                            Quantity = 1,
                            UserId = 4
                        },
                        new
                        {
                            Id = 10,
                            Price = 8,
                            ProductName = "Garlic",
                            Quantity = 12,
                            UserId = 4
                        },
                        new
                        {
                            Id = 11,
                            Price = 3,
                            ProductName = "Potato",
                            Quantity = 100,
                            UserId = 7
                        },
                        new
                        {
                            Id = 12,
                            Price = 9,
                            ProductName = "Carrot",
                            Quantity = 15,
                            UserId = 7
                        },
                        new
                        {
                            Id = 13,
                            Price = 8,
                            ProductName = "Onion",
                            Quantity = 15,
                            UserId = 7
                        },
                        new
                        {
                            Id = 14,
                            Price = 50,
                            ProductName = "Pumpkin",
                            Quantity = 1,
                            UserId = 7
                        },
                        new
                        {
                            Id = 15,
                            Price = 100,
                            ProductName = "Watermelon",
                            Quantity = 12,
                            UserId = 7
                        });
                });

            modelBuilder.Entity("TestTask.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Email = "user3@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Email = "user4@gmail.com",
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Email = "user5@gmail.com",
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            Email = "user6@gmail.com",
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            Email = "user7@gmail.com",
                            Status = 0
                        });
                });

            modelBuilder.Entity("TestTask.Models.Order", b =>
                {
                    b.HasOne("TestTask.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TestTask.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
