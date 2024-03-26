using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedCorrectionPostAndPostReply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_Admin",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "created_at", "last_online", "profile_description" },
                values: new object[,]
                {
                    { "7fe2d98a-807a-4c83-ac01-7a97f7610d1c", 0, "8936054a-0667-4f19-b35f-efa8885168bd", "User", null, false, false, null, "jijel", null, null, null, null, false, "df584bf2-3d2b-4a8e-8850-9e0dd6564cef", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(244), null, "razvan 1 2 3" },
                    { "99a733de-3167-421a-a6dc-791ea2cb494a", 0, "6db83682-fa6d-4bce-bfc7-656ba7e94563", "User", null, false, false, null, "Adrian", null, null, null, null, false, "cfd11dbe-bdea-40f3-9c5e-f644f0f93a73", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(179), null, "lalala 1 2 3" },
                    { "ae40547a-6602-4349-8632-3218ac4bca7e", 0, "d173630f-fd93-4cbc-8d89-d6fe5d279022", "User", null, false, false, null, "ciaciu", null, null, null, null, false, "cbecb45c-974a-486a-860a-58a692729fe0", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(253), null, "adrian 1 2 3" }
                });

            migrationBuilder.InsertData(
                table: "PostProperties",
                columns: new[] { "Unique_Id_Post", "author_user_id", "content", "content_title", "created_at", "last_modified", "post_replies" },
                values: new object[,]
                {
                    { 1, null, "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "REACT FRONT?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(576), null, null },
                    { 2, null, "n looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WORLD OF WARCRAFT BEST MMO", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(581), null, null },
                    { 3, null, "Itoking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "SOMETHING", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(584), null, null },
                    { 4, null, "Iis a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. ", "WHY WHY WHY?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(587), null, null },
                    { 5, null, "It is a long established fact that a reader will be distr ", ".NET BLOG ?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(590), null, null },
                    { 6, null, "It is a long es ", "With whom should we use it?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(593), null, null },
                    { 7, null, "Lalala", "What is Lorem Impsum ?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(596), null, null },
                    { 8, null, "Ce sa faci atunci cand te doare capul ?  ", "Doare capul ?", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(599), null, null }
                });

            migrationBuilder.InsertData(
                table: "PostReplyProperties",
                columns: new[] { "PostReplyId", "PostId", "content", "created_at", "fatherId", "last_modified", "likes", "username" },
                values: new object[,]
                {
                    { 1, 4, " !!!!!!! CE TAREE EEEE!", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(847), 0, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(874), 0, "adrian" },
                    { 2, 2, " haha, ce tare !", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(879), 0, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(881), 0, "adrian" },
                    { 3, 3, " wow, incredibil", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(885), 0, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(887), 1, "razvan" },
                    { 4, 4, " haha, senzational!", new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(890), 0, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(893), 1, "raymond" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fe2d98a-807a-4c83-ac01-7a97f7610d1c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99a733de-3167-421a-a6dc-791ea2cb494a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae40547a-6602-4349-8632-3218ac4bca7e");

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

            migrationBuilder.AddColumn<bool>(
                name: "is_Admin",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);
        }
    }
}
