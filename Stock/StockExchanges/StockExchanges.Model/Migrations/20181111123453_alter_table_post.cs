using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockExchanges.Model.Migrations
{
    public partial class alter_table_post : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Post",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Post",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Post",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Post",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Post",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Post");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Post",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Post",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2048);
        }
    }
}
