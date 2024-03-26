using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPostReplyPropertiesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PostReplyProperties",
                columns: table => new
                {
                    PostReplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    last_online = table.Column<DateTime>(type: "datetime2", nullable: false),
                    likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReplyProperties", x => x.PostReplyId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostReplyProperties");

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(871), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(877), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(883), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(887), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(701), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(747), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 3, 18, 22, 0, 16, 331, DateTimeKind.Local).AddTicks(752) });
        }
    }
}
