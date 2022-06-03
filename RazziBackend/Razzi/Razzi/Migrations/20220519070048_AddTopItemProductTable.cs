﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Razzi.Migrations
{
    public partial class AddTopItemProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TopItem",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopItem",
                table: "Products");
        }
    }
}
