﻿// <auto-generated />
using System;
using CostManeger.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CostManeger.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CostManeger.Models.Banks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("CostManeger.Models.Installments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Parcelamento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "1x - Preço à vista.",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            Description = "2x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            Description = "3x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 4,
                            Description = "4x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 5,
                            Description = "5x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 6,
                            Description = "6x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 7,
                            Description = "7x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 8,
                            Description = "8x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 9,
                            Description = "9x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 10,
                            Description = "10x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 11,
                            Description = "11x - ",
                            IsActive = true
                        },
                        new
                        {
                            Id = 12,
                            Description = "12x - ",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("CostManeger.Models.Payments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstallmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("PaidOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("InstallmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("CostManeger.Models.Profiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Perfis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8183), new TimeSpan(0, -3, 0, 0, 0)),
                            Description = "General",
                            IsActive = true
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8187), new TimeSpan(0, -3, 0, 0, 0)),
                            Description = "Viewer",
                            IsActive = true
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTimeOffset(new DateTime(2024, 1, 28, 18, 48, 40, 502, DateTimeKind.Unspecified).AddTicks(8189), new TimeSpan(0, -3, 0, 0, 0)),
                            Description = "Administrator",
                            IsActive = true
                        });
                });

            modelBuilder.Entity("CostManeger.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("BirthDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreateOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Profile")
                        .HasColumnType("int");

                    b.Property<string>("RG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CostManeger.Models.Payments", b =>
                {
                    b.HasOne("CostManeger.Models.Banks", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CostManeger.Models.Installments", "Installment")
                        .WithMany()
                        .HasForeignKey("InstallmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CostManeger.Models.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");

                    b.Navigation("Installment");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
