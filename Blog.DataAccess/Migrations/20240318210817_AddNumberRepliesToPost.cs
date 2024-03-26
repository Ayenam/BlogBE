using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddNumberRepliesToPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "post_replies",
                table: "PostProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1457), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1459), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1463), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1466), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1467), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1469), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1471), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1474), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1476), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1477), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1480), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1483), 0 });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1516), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1331), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1335), new DateTime(2024, 3, 18, 23, 8, 16, 692, DateTimeKind.Local).AddTicks(1337) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "post_replies",
                table: "PostProperties");

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
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4887), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4890), new DateTime(2024, 3, 18, 22, 41, 29, 206, DateTimeKind.Local).AddTicks(4891) });

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
    }
}
