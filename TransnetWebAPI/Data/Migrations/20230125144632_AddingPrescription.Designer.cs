﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransnetWebAPI.Data;

#nullable disable

namespace TransnetWebAPI.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230125144632_AddingPrescription")]
    partial class AddingPrescription
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("TransnetWebAPI.Models.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TransnetWebAPI.Models.Prescription", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("doctor_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("medicine_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("patiant_id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("time")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
