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
    [Migration("20241127203130_UncommentedSlug")]
    partial class UncommentedSlug
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
                            DateCreation = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3778),
                            DateUpdated = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3786),
                            FileSize = 446684L,
                            Name = "Test Asset",
                            Path = "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\HelloWorld.stl",
                            ProjectId = 1
                        },
                        new
                        {
                            AssetId = 2,
                            DateCreation = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3800),
                            DateUpdated = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3804),
                            FileSize = 11285384L,
                            Name = "Benchy",
                            Path = "C:\\Users\\gaski\\source\\repos\\ModelCabinet\\ModelCabinet.Server\\bin\\Debug\\net8.0\\Assets\\TestProject\\3DBenchy.stl",
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

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3181),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3290),
                            Name = "Test Project",
                            ShortDescription = "Desc",
                            Slug = "nomen est omen",
                            Version = "0.0.1"
                        },
                        new
                        {
                            ProjectId = 2,
                            Author = "Author",
                            CreationDate = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3300),
                            Description = "Description",
                            ModifiedDate = new DateTime(2024, 11, 27, 12, 31, 28, 793, DateTimeKind.Local).AddTicks(3305),
                            Name = "Test Project Two",
                            ShortDescription = "Desc",
                            Slug = "nomen est omen",
                            Version = "0.0.1"
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
