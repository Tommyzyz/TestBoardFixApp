﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestBoardFixApp;

#nullable disable

namespace TestBoardFixApp.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20231205133527_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestBoardFixApp.Model.FixFileData", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("ID"));

                    b.Property<string>("AbnormalString")
                        .HasColumnType("text");

                    b.Property<string>("Abnormalphenomena")
                        .HasColumnType("text");

                    b.Property<string>("BoardName")
                        .HasColumnType("text");

                    b.Property<string>("BoardNum")
                        .HasColumnType("text");

                    b.Property<string>("FixWay")
                        .HasColumnType("text");

                    b.Property<bool>("IsFixed")
                        .HasColumnType("boolean");

                    b.Property<string>("Other")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<string>("RegisteredPerson")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartFixDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TestMachingNum")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("TestMachingType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("T_FixFileData", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
