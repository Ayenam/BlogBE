using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeyRelationAndSeedToPostReplyPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProperties_PostReplyProperties_fatherId",
                table: "PostProperties");

            migrationBuilder.DropIndex(
                name: "IX_PostProperties_fatherId",
                table: "PostProperties");

            migrationBuilder.DropColumn(
                name: "fatherId",
                table: "PostProperties");

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "PostReplyProperties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8097), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8100), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8103), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8106), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8107) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8109), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8112), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8115), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "PostId", "created_at", "fatherId", "last_modified" },
                values: new object[] { 4, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8183), 0, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "PostId", "created_at", "fatherId", "last_modified" },
                values: new object[] { 2, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8187), 0, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "PostId", "created_at", "fatherId", "last_modified" },
                values: new object[] { 3, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8190), 0, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "PostId", "created_at", "fatherId", "last_modified" },
                values: new object[] { 4, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8193), 0, new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7938), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7987), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.CreateIndex(
                name: "IX_PostReplyProperties_PostId",
                table: "PostReplyProperties",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostReplyProperties_PostProperties_PostId",
                table: "PostReplyProperties",
                column: "PostId",
                principalTable: "PostProperties",
                principalColumn: "Unique_Id_Post",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostReplyProperties_PostProperties_PostId",
                table: "PostReplyProperties");

            migrationBuilder.DropIndex(
                name: "IX_PostReplyProperties_PostId",
                table: "PostReplyProperties");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "PostReplyProperties");

            migrationBuilder.AddColumn<int>(
                name: "fatherId",
                table: "PostProperties",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9424), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9431), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9435), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9438), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9442), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9445), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9449), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9452), null, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9477), 4, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9481), 4, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9485), 4, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "fatherId", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9490), 4, new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9242), new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9292), new DateTime(2024, 3, 19, 19, 15, 14, 180, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.CreateIndex(
                name: "IX_PostProperties_fatherId",
                table: "PostProperties",
                column: "fatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostProperties_PostReplyProperties_fatherId",
                table: "PostProperties",
                column: "fatherId",
                principalTable: "PostReplyProperties",
                principalColumn: "PostReplyId");
        }
    }
}
