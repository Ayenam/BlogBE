using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserProperties",
                columns: new[] { "Id", "created_at", "email", "is_Admin", "last_online", "password", "profile_description", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5026), "raymond@yahoo.com", true, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5061), "12345", "lalala 1 2 3", "mamaleone" },
                    { 2, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5064), "razvan@yahoo.com", true, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5065), "1223", "razvan 1 2 3", "razvan" },
                    { 3, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5067), "adrian@yahoo.com", false, new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5068), "123456", "adrian 1 2 3", "adrian" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
