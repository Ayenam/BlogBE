using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PossibleFixWithDatabaseConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties");

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

            migrationBuilder.AlterColumn<string>(
                name: "author_user_id",
                table: "PostProperties",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "created_at", "last_online", "profile_description" },
                values: new object[,]
                {
                    { "5867d2de-394f-42b1-9036-d388a7be86d8", 0, "d48785f8-4598-4675-a84e-5606766d2905", "User", null, false, false, null, "jijel", null, null, null, null, false, "ad4a463c-beb5-4f21-b3fe-ed341a77e8e0", false, null, new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4227), null, "razvan 1 2 3" },
                    { "b6f83aaf-6c57-44ff-abff-9a365f039f0d", 0, "16a7ee21-d701-4e67-9b57-b592d421a1f2", "User", null, false, false, null, "Adrian", null, null, null, null, false, "7ebbcde5-9b6d-48d3-8c0c-de4833085b49", false, null, new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4169), null, "lalala 1 2 3" },
                    { "f83af9de-0fb0-48e1-ae16-b1d99bf27a76", 0, "182647d4-718e-4331-8abb-1d86987efa7a", "User", null, false, false, null, "ciaciu", null, null, null, null, false, "1abffcab-e005-4a8c-bff9-1141ca1a2139", false, null, new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4232), null, "adrian 1 2 3" }
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "7e245a45-352d-4486-98c4-035eecf15875", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "a2eb4331-a44e-4652-aeee-140ce222f37e", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "bad532d4-d537-415b-bc4d-b4718a3dd162", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4366) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "e5a74233-81d1-4874-8fe7-a87e5fedb3d0", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "e5a74233-81d1-4874-8fe7-a87e5fedb3d0", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "62b303f6-6e23-4dd6-915b-8ec1559ebb48", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "a8adb7ad-d3c6-446b-898b-d26ccc26987d", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { "e37b1d7b-6928-4b4d-ae69-aa7cab3fd10f", new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4451), new DateTime(2024, 3, 22, 1, 53, 50, 343, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.AddForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties",
                column: "author_user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5867d2de-394f-42b1-9036-d388a7be86d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6f83aaf-6c57-44ff-abff-9a365f039f0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f83af9de-0fb0-48e1-ae16-b1d99bf27a76");

            migrationBuilder.AlterColumn<string>(
                name: "author_user_id",
                table: "PostProperties",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "created_at", "last_online", "profile_description" },
                values: new object[,]
                {
                    { "7fe2d98a-807a-4c83-ac01-7a97f7610d1c", 0, "8936054a-0667-4f19-b35f-efa8885168bd", "User", null, false, false, null, "jijel", null, null, null, null, false, "df584bf2-3d2b-4a8e-8850-9e0dd6564cef", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(244), null, "razvan 1 2 3" },
                    { "99a733de-3167-421a-a6dc-791ea2cb494a", 0, "6db83682-fa6d-4bce-bfc7-656ba7e94563", "User", null, false, false, null, "Adrian", null, null, null, null, false, "cfd11dbe-bdea-40f3-9c5e-f644f0f93a73", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(179), null, "lalala 1 2 3" },
                    { "ae40547a-6602-4349-8632-3218ac4bca7e", 0, "d173630f-fd93-4cbc-8d89-d6fe5d279022", "User", null, false, false, null, "ciaciu", null, null, null, null, false, "cbecb45c-974a-486a-860a-58a692729fe0", false, null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(253), null, "adrian 1 2 3" }
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "author_user_id", "created_at" },
                values: new object[] { null, new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(847), new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(879), new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(890), new DateTime(2024, 3, 21, 19, 39, 0, 335, DateTimeKind.Local).AddTicks(893) });

            migrationBuilder.AddForeignKey(
                name: "FK_PostProperties_AspNetUsers_author_user_id",
                table: "PostProperties",
                column: "author_user_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
