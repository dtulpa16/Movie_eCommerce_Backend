using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Usercs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81db04dc-2977-4405-9baa-29f1b1644177");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be981de-e654-414e-840f-ef668dc64b93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e7c91cc-6ee2-423a-b500-7e43ef93c30c", "56732fc9-410f-4f79-b496-11a40e5db8b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e1155ca-05a1-471c-91cb-d67605c3d990", "b3289b4c-075e-422c-94e6-9be79faa1736", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e7c91cc-6ee2-423a-b500-7e43ef93c30c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e1155ca-05a1-471c-91cb-d67605c3d990");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9be981de-e654-414e-840f-ef668dc64b93", "94625d9b-b24a-4952-b3a7-e49ac4df09f6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81db04dc-2977-4405-9baa-29f1b1644177", "7884bf85-810c-46f6-a3f5-d47052e2a6cd", "Admin", "ADMIN" });
        }
    }
}
