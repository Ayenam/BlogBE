using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DisplayNameChangesToPostTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2448b460-025a-4fd3-bde2-bd10acb8ef21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9777d107-e7f5-4ae5-adda-58fd21cb12b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4f32622-fb00-40b3-a850-74a297fe380d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "created_at", "last_online", "profile_description" },
                values: new object[,]
                {
                    { "273312f8-7f28-44d8-b3c8-1c84aee01a5d", 0, "f9051ced-fed2-4e20-8381-a680815bcc51", "User", null, false, false, null, "jijel", null, null, null, null, false, "9d019b65-78ad-40cf-9b2c-9dc580f581f9", false, null, new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5635), null, "razvan 1 2 3" },
                    { "ae6d2843-e8b9-485e-be56-9107ffd8777e", 0, "cfe37f2e-fb09-4c3a-b87c-b7f27675ba94", "User", null, false, false, null, "Adrian", null, null, null, null, false, "93afa3db-9df7-4294-84d5-5da31d9bb813", false, null, new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5573), null, "lalala 1 2 3" },
                    { "d77061e1-33cd-4822-aa21-02fa06926bde", 0, "fcb137f1-0d48-43ff-8e9e-652582d7786b", "User", null, false, false, null, "ciaciu", null, null, null, null, false, "6988ed72-9d73-4ce3-bf1c-b80d167136ca", false, null, new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5640), null, "adrian 1 2 3" }
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5786), new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5790), new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5793), new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5797), new DateTime(2024, 3, 25, 13, 1, 54, 807, DateTimeKind.Local).AddTicks(5799) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "273312f8-7f28-44d8-b3c8-1c84aee01a5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae6d2843-e8b9-485e-be56-9107ffd8777e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d77061e1-33cd-4822-aa21-02fa06926bde");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "created_at", "last_online", "profile_description" },
                values: new object[,]
                {
                    { "2448b460-025a-4fd3-bde2-bd10acb8ef21", 0, "9c7d39f2-7437-43df-b6c1-4607e07e2129", "User", null, false, false, null, "jijel", null, null, null, null, false, "4df616d1-afb6-4bf9-966d-3615c680578d", false, null, new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9194), null, "razvan 1 2 3" },
                    { "9777d107-e7f5-4ae5-adda-58fd21cb12b9", 0, "346c7e65-916f-47d8-9c25-fff7ec181141", "User", null, false, false, null, "ciaciu", null, null, null, null, false, "bf8c3e1f-70dc-4b8c-b013-b2a68a4b7094", false, null, new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9202), null, "adrian 1 2 3" },
                    { "a4f32622-fb00-40b3-a850-74a297fe380d", 0, "4b73a983-c675-413a-a1da-494d8fd980e2", "User", null, false, false, null, "Adrian", null, null, null, null, false, "d16461db-91bc-4444-8405-b4d0f167740d", false, null, new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9136), null, "lalala 1 2 3" }
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                column: "created_at",
                value: new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9416), new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9434), new DateTime(2024, 3, 22, 15, 4, 59, 542, DateTimeKind.Local).AddTicks(9436) });
        }
    }
}
