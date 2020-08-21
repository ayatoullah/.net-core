using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace lab_2.Migrations
{
    public partial class e : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_departmentid",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "DeptID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "departmentid",
                table: "Students",
                newName: "departmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Students_departmentid",
                table: "Students",
                newName: "IX_Students_departmentID");

            migrationBuilder.AlterColumn<int>(
                name: "departmentID",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_departmentID",
                table: "Students",
                column: "departmentID",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_departmentID",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "departmentID",
                table: "Students",
                newName: "departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_Students_departmentID",
                table: "Students",
                newName: "IX_Students_departmentid");

            migrationBuilder.AlterColumn<int>(
                name: "departmentid",
                table: "Students",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DeptID",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_departmentid",
                table: "Students",
                column: "departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
