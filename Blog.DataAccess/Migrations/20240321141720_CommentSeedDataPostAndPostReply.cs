using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CommentSeedDataPostAndPostReply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostProperties",
                columns: new[] { "Unique_Id_Post", "author_user_id", "content", "content_title", "created_at", "last_modified", "post_replies" },
                values: new object[,]
                {
                    { 1, null, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "REACT FRONT?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6334), null },
                    { 2, null, "n looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WORLD OF WARCRAFT BEST MMO", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6342), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6343), null },
                    { 3, null, "Itoking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "SOMETHING", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6345), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6346), null },
                    { 4, null, "Iis a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WHY WHY WHY?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6350), null },
                    { 5, null, "It is a long established fact that a reader will be distr ", ".NET BLOG ?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6353), null },
                    { 6, null, "It is a long es ", "With whom should we use it?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6355), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6356), null },
                    { 7, null, "Lalala", "What is Lorem Impsum ?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6358), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6359), null },
                    { 8, null, "Ce sa faci atunci cand te doare capul ?  ", "Doare capul ?", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6362), null }
                });

            migrationBuilder.InsertData(
                table: "PostReplyProperties",
                columns: new[] { "PostReplyId", "PostId", "content", "created_at", "fatherId", "last_modified", "likes", "username" },
                values: new object[,]
                {
                    { 1, 4, " !!!!!!! CE TAREE EEEE!", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6532), 0, new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6536), 0, "adrian" },
                    { 2, 2, " haha, ce tare !", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6539), 0, new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6540), 0, "adrian" },
                    { 3, 3, " wow, incredibil", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6542), 0, new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6544), 1, "razvan" },
                    { 4, 4, " haha, senzational!", new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6546), 0, new DateTime(2024, 3, 21, 16, 15, 38, 44, DateTimeKind.Local).AddTicks(6547), 1, "raymond" }
                });
        }
    }
}
