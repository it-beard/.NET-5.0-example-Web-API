﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Itbeard.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TargetUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortGuid = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urls_ShortGuid",
                table: "Urls",
                column: "ShortGuid",
                unique: true,
                filter: "[ShortGuid] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urls");
        }
    }
}
