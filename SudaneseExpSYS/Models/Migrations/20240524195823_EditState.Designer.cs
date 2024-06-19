﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SudaneseExpSYS.Data;

#nullable disable

namespace SudaneseExpSYS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240524195823_EditState")]
    partial class EditState
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SudaneseExpSYS.Models.Country", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"));

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SudaneseExpSYS.Models.Filed", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FId"));

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FId");

                    b.ToTable("fileds");
                });

            modelBuilder.Entity("SudaneseExpSYS.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Achievement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BrithDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("CId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExitDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("FId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NationalId")
                        .HasColumnType("real");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("dbImage")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("CId");

                    b.HasIndex("FId");

                    b.ToTable("profiles");
                });

            modelBuilder.Entity("SudaneseExpSYS.Models.State", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SId"));

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("SId");

                    b.ToTable("states");
                });

            modelBuilder.Entity("SudaneseExpSYS.Models.Profile", b =>
                {
                    b.HasOne("SudaneseExpSYS.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SudaneseExpSYS.Models.Filed", "Filed")
                        .WithMany()
                        .HasForeignKey("FId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");

                    b.Navigation("Filed");
                });
#pragma warning restore 612, 618
        }
    }
}
