﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NordiskLuksusMVC.Models;

namespace NordiskLuksusMVC.Migrations
{
    [DbContext(typeof(MatContext))]
    [Migration("20190430143408_InitialNordisk")]
    partial class InitialNordisk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("NordiskLuksusMVC.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("UserID");

                    b.Property<string>("comment");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("NordiskLuksusMVC.Models.Mat", b =>
                {
                    b.Property<int>("MatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImgSrc")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("MatId");

                    b.ToTable("Mat");
                });

            modelBuilder.Entity("NordiskLuksusMVC.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NordiskLuksusMVC.Models.Comment", b =>
                {
                    b.HasOne("NordiskLuksusMVC.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
