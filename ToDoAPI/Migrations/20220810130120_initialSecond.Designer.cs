﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoAPI.Data;

namespace ToDoAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220810130120_initialSecond")]
    partial class initialSecond
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ToDoAPI.Model.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(2022, 8, 10, 14, 1, 13, 986, DateTimeKind.Local).AddTicks(6933),
                            FirstName = "Bello",
                            Gender = "male",
                            LastName = "Azeez"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2352),
                            FirstName = "Bolaji",
                            Gender = "male",
                            LastName = "Kola"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2485),
                            FirstName = "Maryam",
                            Gender = "female",
                            LastName = "Atinuke"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(2022, 8, 10, 14, 1, 13, 998, DateTimeKind.Local).AddTicks(2502),
                            FirstName = "John",
                            Gender = "male",
                            LastName = "Deji"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
