using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddFixToPostModelTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "post_replies",
                table: "PostProperties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_modified",
                table: "PostProperties",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6334), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6343), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6346), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6350), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6353), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6356), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6358), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6359), null });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6362), null });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6547) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "post_replies",
                table: "PostProperties",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "last_modified",
                table: "PostProperties",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3593), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3597), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3600), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3603), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3606), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3608), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3611), 0 });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified", "post_replies" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3614), 0 });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3785), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3788), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3822) });
        }
    }
}
