﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebShopApp_MVC.Models;

#nullable disable

namespace WebShopApp_MVC.Migrations
{
    [DbContext(typeof(MyDataBaseContext))]
    [Migration("20231025180626_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebShopApp_MVC.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Leiras")
                        .HasColumnType("longtext");

                    b.Property<string>("Nev")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("WebShopApp_MVC.Models.Termek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Ar")
                        .HasColumnType("double");

                    b.Property<bool>("Elerheto")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FenykepUtvonal")
                        .HasColumnType("longtext");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Leiras")
                        .HasColumnType("longtext");

                    b.Property<string>("Nev")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Termek");
                });
#pragma warning restore 612, 618
        }
    }
}