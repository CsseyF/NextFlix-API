﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NextFlixAPI.Database;

#nullable disable

namespace NextflixAPI.Migrations
{
    [DbContext(typeof(BaseContext))]
    partial class BaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NextFlixAPI.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BannerPath")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("Identity")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Maturity")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("movie");
                });
#pragma warning restore 612, 618
        }
    }
}
