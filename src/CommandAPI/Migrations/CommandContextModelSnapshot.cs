﻿// <auto-generated />
using CommandAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CommandAPI.Migrations
{
    [DbContext(typeof(CommandContext))]
    partial class CommandContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CommandAPI.Models.CommandAPI", b =>
                {
                    b.Property<string>("HowTo")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("CommandLine")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("HowTo");

                    b.ToTable("CommandItems");
                });
#pragma warning restore 612, 618
        }
    }
}
