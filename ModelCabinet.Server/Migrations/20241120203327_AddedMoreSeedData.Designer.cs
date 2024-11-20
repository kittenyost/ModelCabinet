﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModelCabinet.Server.Data;

#nullable disable

namespace ModelCabinet.Server.Migrations
{
    [DbContext(typeof(ModelCabinetContext))]
    [Migration("20241120203327_AddedMoreSeedData")]
    partial class AddedMoreSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ModelCabinet.Server.Models.Asset", b =>
                {
                    b.Property<int>("AssetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssetId"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("AssetId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Asset");

                    b.HasData(
                        new
                        {
                            AssetId = 1,
                            DateCreation = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9003),
                            DateUpdated = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9006),
                            FileSize = 446684L,
                            Name = "Test Asset",
                            Path = "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl",
                            ProjectId = 1
                        },
                        new
                        {
                            AssetId = 2,
                            DateCreation = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9013),
                            DateUpdated = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(9015),
                            FileSize = 11285384L,
                            Name = "Benchy",
                            Path = "C:\\Users\\jesse.harlan\\Desktop\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl",
                            ProjectId = 1
                        });
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8805),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8850),
                            Name = "Test Project",
                            Version = "0.0.1",
                            shortDescription = "Desc"
                        },
                        new
                        {
                            ProjectId = 2,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8856),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 11, 20, 12, 33, 26, 724, DateTimeKind.Local).AddTicks(8858),
                            Name = "Test Project Two",
                            Version = "0.0.1",
                            shortDescription = "Desc"
                        });
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Asset", b =>
                {
                    b.HasOne("ModelCabinet.Server.Models.Project", null)
                        .WithMany("Assets")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModelCabinet.Server.Models.Project", b =>
                {
                    b.Navigation("Assets");
                });
#pragma warning restore 612, 618
        }
    }
}