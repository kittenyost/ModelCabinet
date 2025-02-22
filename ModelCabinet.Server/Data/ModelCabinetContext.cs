﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ModelCabinet.Server.Models;

namespace ModelCabinet.Server.Data
{
    public class ModelCabinetContext : IdentityDbContext<ApplicationUser>
    {
        public ModelCabinetContext(DbContextOptions<ModelCabinetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DateTime dateTime = new DateTime(2024, 01, 01);
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectId = 1,
                    Name = "Test Project",
                    CreationDate = dateTime,
                    ModifiedDate = dateTime,
                    Description = "Description",
                    Author = "Author",
                    Version = "0.0.1",
                    ShortDescription = "Desc",
                    Slug = "nomen-est-omen",
                },
                new Project
                {
                    ProjectId = 2,
                    Name = "Test Project Two",
                    CreationDate = dateTime,
                    ModifiedDate = dateTime,
                    Description = "Description",
                    Author = "Author",
                    Version = "0.0.1",
                    ShortDescription = "Desc",
                    Slug = "nomen-est-bonum",
                }
            );

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    AssetId = 1,
                    Name = "Test Asset",
                    Path = Path.Combine("Assets", "TestProject", "HelloWorld.stl"),
                    DateCreation = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    FileSize = 446684,
                    ProjectId = 1
                },
                new Asset
                {
                    AssetId = 2,
                    Name = "Benchy",
                    Path = Path.Combine("Assets", "TestProject", "3DBenchy.stl"),
                    DateCreation = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    FileSize = 11285384,
                    ProjectId = 1
                }
            );


            // auto load any navigation properties using this pattern
            modelBuilder.Entity<Project>().Navigation(p => p.Assets).AutoInclude();

            // Ensures each slug is unique
            modelBuilder.Entity<Project>().HasIndex(p => p.Slug).IsUnique();
        }

        public DbSet<ModelCabinet.Server.Models.Project> Project { get; set; } = default!;
        public DbSet<ModelCabinet.Server.Models.Asset> Asset { get; set; } = default!;
    }
}
