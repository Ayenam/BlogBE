using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExtendingUserPropertiesViaIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserProperties");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_Admin",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "last_online",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "profile_description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1346), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1505), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1507) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "is_Admin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "last_online",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "profile_description",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "UserProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_Admin = table.Column<bool>(type: "bit", nullable: false),
                    last_online = table.Column<DateTime>(type: "datetime2", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profile_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProperties", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(220), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.InsertData(
                table: "UserProperties",
                columns: new[] { "Id", "created_at", "email", "is_Admin", "last_online", "password", "profile_description", "username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(33), "raymond@yahoo.com", true, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(74), "12345", "lalala 1 2 3", "mamaleone" },
                    { 2, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(77), "razvan@yahoo.com", true, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(78), "1223", "razvan 1 2 3", "razvan" },
                    { 3, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(81), "adrian@yahoo.com", false, new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(82), "123456", "adrian 1 2 3", "adrian" }
                });
        }
    }
}
