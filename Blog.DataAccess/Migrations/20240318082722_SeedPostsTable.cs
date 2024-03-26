using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedPostsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostProperties",
                columns: new[] { "Unique_Id_Post", "author_user_id", "content", "content_title", "created_at", "last_modified" },
                values: new object[,]
                {
                    { 1, "mamaleone", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "REACT FRONT?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1625), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1627) },
                    { 2, "mamaleone", "n looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WORLD OF WARCRAFT BEST MMO", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1629), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1630) },
                    { 3, "mamaleone", "Itoking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "SOMETHING", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1633) },
                    { 4, "razvan", "Iis a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WHY WHY WHY?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1636) },
                    { 5, "mamaleone", "It is a long established fact that a reader will be distr ", ".NET BLOG ?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1638), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1639) },
                    { 6, "adrian", "It is a long es ", "With whom should we use it?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1641), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1642) },
                    { 7, "adrian", "Lalala", "What is Lorem Impsum ?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1643), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1645) },
                    { 8, "razvan", "Ce sa faci atunci cand te doare capul ?  ", "Doare capul ?", new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1647) }
                });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1516), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 3, 18, 10, 27, 22, 109, DateTimeKind.Local).AddTicks(1520) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5026), new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5067), new DateTime(2024, 3, 17, 20, 51, 45, 997, DateTimeKind.Local).AddTicks(5068) });
        }
    }
}
