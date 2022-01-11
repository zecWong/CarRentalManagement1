using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "75db0b5f-d67e-4f07-8cf9-2201d43ec9e8", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "41aabf76-f407-4b44-8c43-f9820bc55006", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c3e5e41a-ae9e-49c8-98f7-8455891676a2", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAELe46837wyos6q8iYNWoYwo/tUFclV4y0PU9IZAY6LwVLcAfS6Cztzv7PvAhqdnN0Q==", null, false, "f3f7631c-5b8b-4b98-98d1-4039ebd080a6", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 15, 49, 54, 444, DateTimeKind.Local).AddTicks(1366), new DateTime(2021, 11, 30, 15, 49, 54, 445, DateTimeKind.Local).AddTicks(7239), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 15, 49, 54, 445, DateTimeKind.Local).AddTicks(9097), new DateTime(2021, 11, 30, 15, 49, 54, 445, DateTimeKind.Local).AddTicks(9108), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(1004), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(1017), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(1023), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(1025), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6218), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6229), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6233), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6235), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6237), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6239), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6242), new DateTime(2021, 11, 30, 15, 49, 54, 448, DateTimeKind.Local).AddTicks(6244), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
