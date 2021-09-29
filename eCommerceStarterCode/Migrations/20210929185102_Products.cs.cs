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
                keyValue: "6f3bb06b-e420-4f7c-babe-94ddbb3e1386");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "866d26b7-ee82-4540-a876-a612c280bdc2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12bd022e-5f53-4226-9174-c02d6e5b197f", "16805ff8-1939-430e-bcc4-2f78c0b68a24", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0675af5-e60c-47cf-a5dc-5ebb141f8116", "8d6e839c-2fbc-4c1a-95d8-62b83d9d096a", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12bd022e-5f53-4226-9174-c02d6e5b197f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0675af5-e60c-47cf-a5dc-5ebb141f8116");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f3bb06b-e420-4f7c-babe-94ddbb3e1386", "5fafa973-6bb7-43a4-af1a-5208f8b071b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "866d26b7-ee82-4540-a876-a612c280bdc2", "809cd948-7272-404d-8a36-1f3cc40949ca", "Admin", "ADMIN" });
        }
    }
}
