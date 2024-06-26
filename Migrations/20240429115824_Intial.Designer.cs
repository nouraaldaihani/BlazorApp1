﻿// <auto-generated />
using System;
using BlazorApp1.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(TodoContext))]
    [Migration("20240429115824_Intial")]
    partial class Intial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("BlazorApp1.Model.Entity.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Complete all Coded Assignments",
                            DueDate = new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsCompleted = false
                        },
                        new
                        {
                            Id = 2,
                            Description = "Appartment Rent",
                            IsCompleted = true
                        },
                        new
                        {
                            Id = 3,
                            Description = "Clean My Room",
                            IsCompleted = false
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
