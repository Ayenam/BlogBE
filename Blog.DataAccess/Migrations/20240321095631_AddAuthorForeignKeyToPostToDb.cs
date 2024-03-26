using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorForeignKeyToPostToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "author_user_id",
                table: "PostProperties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3551), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { null, new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 3, 21, 11, 56, 30, 397, DateTimeKind.Local).AddTicks(3614) });

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

            migrationBuilder.CreateIndex(
                name: "IX_PostProperties_author_user_id",
                table: "PostProperties",
                column: "author_user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties",
                column: "author_user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties");

            migrationBuilder.DropIndex(
                name: "IX_PostProperties_author_user_id",
                table: "PostProperties");

            migrationBuilder.AlterColumn<string>(
                name: "author_user_id",
                table: "PostProperties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "mamaleone", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "mamaleone", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1334), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "mamaleone", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1338), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "razvan", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1341) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "mamaleone", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1343), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "adrian", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1346), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "adrian", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "author_user_id", "created_at", "last_modified" },
                values: new object[] { "razvan", new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1351), new DateTime(2024, 3, 20, 3, 29, 41, 701, DateTimeKind.Local).AddTicks(1352) });

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
    }
}
