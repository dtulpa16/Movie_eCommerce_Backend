using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Reviewscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7523f598-1c3e-4a0b-8bd6-6834eb69c8e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4398cac-8a56-4ab1-8baa-6f5c86029d88");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f2dd3e5-8c56-4a00-ab63-3143e3302873", "f4c59376-a653-48ff-9879-b127278163f8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f24da0c2-ebca-4a8d-99d5-bab222c72a91", "96b32f50-988f-48f5-a79a-ac40700de03a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2dd3e5-8c56-4a00-ab63-3143e3302873");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f24da0c2-ebca-4a8d-99d5-bab222c72a91");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7523f598-1c3e-4a0b-8bd6-6834eb69c8e4", "33558c59-0a8a-45d7-ad87-f2c63c7e8239", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4398cac-8a56-4ab1-8baa-6f5c86029d88", "aaf86f81-fb8a-4bf4-bb9b-8a436e7eb564", "Admin", "ADMIN" });
        }
    }
}
