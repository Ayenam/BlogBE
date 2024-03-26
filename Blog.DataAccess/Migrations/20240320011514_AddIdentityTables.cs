using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(212), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(214) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(216), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(220), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(223), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 5,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(226), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 6,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(229), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 7,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(232), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "PostProperties",
                keyColumn: "Unique_Id_Post",
                keyValue: 8,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(235), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 1,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(262), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(272) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(33), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(77), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(78) });

            migrationBuilder.UpdateData(
                table: "UserProperties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "created_at", "last_online" },
                values: new object[] { new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(81), new DateTime(2024, 3, 20, 3, 15, 13, 547, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 2,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8187), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 3,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8190), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "PostReplyProperties",
                keyColumn: "PostReplyId",
                keyValue: 4,
                columns: new[] { "created_at", "last_modified" },
                values: new object[] { new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 3, 19, 22, 37, 52, 273, DateTimeKind.Local).AddTicks(8195) });

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
        }
    }
}
