﻿// <auto-generated />
using System;
using DAL.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(EntityContext))]
    [Migration("20240126202910_addCategories")]
    partial class addCategories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entity.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ProcessingTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SicilId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId")
                        .IsUnique()
                        .HasFilter("[CreatedUserId] IS NOT NULL");

                    b.HasIndex("LastUpdatedUserId")
                        .IsUnique()
                        .HasFilter("[LastUpdatedUserId] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entity.Vehicle.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<bool>("Headlight")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometer")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("LastUpdatedUserId");

                    b.ToTable("Boats");
                });

            modelBuilder.Entity("Entity.Vehicle.Buse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<bool>("Headlight")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometer")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("LastUpdatedUserId");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("Entity.Vehicle.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<bool>("Headlight")
                        .HasColumnType("bit");

                    b.Property<int>("Kilometer")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessingTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("LastUpdatedUserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Entity.Vehicle.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ProcessingTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreatedUserId");

                    b.HasIndex("LastUpdatedUserId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Entity.Users.User", b =>
                {
                    b.HasOne("Entity.Users.User", "CreatedUser")
                        .WithOne()
                        .HasForeignKey("Entity.Users.User", "CreatedUserId");

                    b.HasOne("Entity.Users.User", "LastUpdatedUser")
                        .WithOne()
                        .HasForeignKey("Entity.Users.User", "LastUpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("LastUpdatedUser");
                });

            modelBuilder.Entity("Entity.Vehicle.Boat", b =>
                {
                    b.HasOne("Entity.Users.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Entity.Users.User", "LastUpdatedUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("LastUpdatedUser");
                });

            modelBuilder.Entity("Entity.Vehicle.Buse", b =>
                {
                    b.HasOne("Entity.Users.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Entity.Users.User", "LastUpdatedUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("LastUpdatedUser");
                });

            modelBuilder.Entity("Entity.Vehicle.Car", b =>
                {
                    b.HasOne("Entity.Users.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Entity.Users.User", "LastUpdatedUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("LastUpdatedUser");
                });

            modelBuilder.Entity("Entity.Vehicle.Categories", b =>
                {
                    b.HasOne("Entity.Users.User", "CreatedUser")
                        .WithMany()
                        .HasForeignKey("CreatedUserId");

                    b.HasOne("Entity.Users.User", "LastUpdatedUser")
                        .WithMany()
                        .HasForeignKey("LastUpdatedUserId");

                    b.Navigation("CreatedUser");

                    b.Navigation("LastUpdatedUser");
                });
#pragma warning restore 612, 618
        }
    }
}
