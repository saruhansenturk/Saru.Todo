using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Saru.Todo.Migrations
{
    /// <inheritdoc />
    public partial class mig_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "Modified",
                table: "TodoItems",
                newName: "CreationTime");

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "TodoItems",
                type: "character varying(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatorId",
                table: "TodoItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraProperties",
                table: "TodoItems",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "TodoItems",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifierId",
                table: "TodoItems",
                type: "uuid",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "ExtraProperties",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "LastModifierId",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "TodoItems",
                newName: "Modified");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "TodoItems",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
