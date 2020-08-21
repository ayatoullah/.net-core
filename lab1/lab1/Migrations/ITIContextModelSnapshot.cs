﻿// <auto-generated />
using lab1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab1.Migrations
{
    [DbContext(typeof(ITIContext))]
    partial class ITIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab1.Models.Student", b =>
                {
                    b.Property<int>("St_Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("St_Age");

                    b.Property<string>("St_Name")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("St_Id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
