using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FatherIdToPostReplyModelAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "fatherId",
                table: "PostReplyProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4879), 4, new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4883), 4, new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4887), 4, new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4890), 4, new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4891) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4729), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4731) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fatherId",
                table: "PostReplyProperties");

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

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8556), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8557) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8560), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8566), new DateTime(2024, 3, 18, 22, 39, 57, 792, DateTimeKind.Local).AddTicks(8567) });

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
    }
}
