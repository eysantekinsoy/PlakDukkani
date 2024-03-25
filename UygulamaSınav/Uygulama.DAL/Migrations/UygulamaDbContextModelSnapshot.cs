﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uygulama.DAL.Context;

#nullable disable

namespace Uygulama.DAL.Migrations
{
    [DbContext(typeof(UygulamaDbContext))]
    partial class UygulamaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Uygulama.DAL.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AlbumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AlbumCikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Fiyati")
                        .HasColumnType("int");

                    b.Property<int>("SanatciId")
                        .HasColumnType("int");

                    b.Property<int>("SatisDurum")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("indirim")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SanatciId");

                    b.ToTable("Albums");
                });

            modelBuilder.Entity("Uygulama.DAL.Entities.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("Uygulama.DAL.Entities.Sanatci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sanatcis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Barış Manço",
                            CreatedDate = new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5658),
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Adi = "Barış Akarsu",
                            CreatedDate = new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5674),
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Adi = "Sıla",
                            CreatedDate = new DateTime(2024, 3, 25, 16, 59, 22, 787, DateTimeKind.Local).AddTicks(5675),
                            Status = 0
                        });
                });

            modelBuilder.Entity("Uygulama.DAL.Entities.Album", b =>
                {
                    b.HasOne("Uygulama.DAL.Entities.Sanatci", "Sanatci")
                        .WithMany("Albums")
                        .HasForeignKey("SanatciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sanatci");
                });

            modelBuilder.Entity("Uygulama.DAL.Entities.Sanatci", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
