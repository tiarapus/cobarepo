﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D1Training.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingcreatedanduodatedatinmahasiswa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Mahasiswa",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateddAt",
                table: "Mahasiswa",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Mahasiswa");

            migrationBuilder.DropColumn(
                name: "UpdateddAt",
                table: "Mahasiswa");
        }
    }
}
