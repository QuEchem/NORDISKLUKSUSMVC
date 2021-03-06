﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NordiskLuksusMVC.Models;

namespace NordiskLuksusMVC.Migrations
{
    [DbContext(typeof(MatContext))]
    [Migration("20190427233142_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("NordiskLuksusMVC.Models.Mat", b =>
                {
                    b.Property<int>("MatId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImgSrc");

                    b.Property<string>("Name");

                    b.HasKey("MatId");

                    b.ToTable("Mat");
                });
#pragma warning restore 612, 618
        }
    }
}
