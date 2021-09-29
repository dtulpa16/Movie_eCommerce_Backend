using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Productscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bfcdb7-346a-484a-afe5-518fa1ca1164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2465032-18db-4596-aea7-ad986b6a5ffa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7523f598-1c3e-4a0b-8bd6-6834eb69c8e4", "33558c59-0a8a-45d7-ad87-f2c63c7e8239", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d4398cac-8a56-4ab1-8baa-6f5c86029d88", "aaf86f81-fb8a-4bf4-bb9b-8a436e7eb564", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "35bfcdb7-346a-484a-afe5-518fa1ca1164", "ff394db5-c17e-46af-a2e3-806702a2b9f0", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c2465032-18db-4596-aea7-ad986b6a5ffa", "fece83f5-5f35-4e05-8bd0-5abe215d2a90", "Admin", "ADMIN" });
        }
    }
}
