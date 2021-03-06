﻿// <auto-generated />
using lab_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace lab_2.Migrations
{
    [DbContext(typeof(ITIDB))]
    [Migration("20180503112615_e")]
    partial class e
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lab_2.Models.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Dept_Name");

                    b.HasKey("id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("lab_2.Models.Student", b =>
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

                    b.Property<int>("departmentID");

                    b.HasKey("St_Id");

                    b.HasIndex("departmentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("lab_2.Models.Student", b =>
                {
                    b.HasOne("lab_2.Models.Department", "department")
                        .WithMany("Students")
                        .HasForeignKey("departmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
