﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoGameApi.Data;

#nullable disable

namespace VideoGameApi.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    partial class VideoGameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VideoGameApi.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("videoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Developer 1",
                            Platform = "Platform 1",
                            Publisher = "Publisher 1",
                            Title = "title 1"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Developer 2",
                            Platform = "Platform 2",
                            Publisher = "Publisher 2",
                            Title = "title 2"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "Developer 3",
                            Platform = "Platform 3",
                            Publisher = "Publisher 3",
                            Title = "title 3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}