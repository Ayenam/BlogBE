using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedPostReplyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "last_online",
                table: "PostReplyProperties",
                newName: "last_modified");

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8516), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8520), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8533), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8534) });

            migrationBuilder.InsertData(
                table: "PostReplyProperties",
                columns: new[] { "PostReplyId", "content", "created_at", "last_modified", "likes", "username" },
                values: new object[,]
                {
                    { 1, " !!!!!!! CE TAREE EEEE!", new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8556), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8557), 0, "adrian" },
                    { 2, " haha, ce tare !", new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8561), 0, "adrian" },
                    { 3, " wow, incredibil", new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8564), 1, "razvan" },
                    { 4, " haha, senzational!", new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8567), 1, "raymond" }
                });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8338), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8384), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8389) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "last_modified",
                table: "PostReplyProperties",
                newName: "last_online");

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2117), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2122), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2125), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2131), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2135), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2138), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2141), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(1997), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2001), new DateTime(2024, 3, 18, 22, 32, 56, 256, DateTimeKind.Local).AddTicks(2002) });
        }
    }
}
