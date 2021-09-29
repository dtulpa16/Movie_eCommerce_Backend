using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class SeedRolescs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "ab0463ff-323d-4057-b032-eb96f465ba6e", "a3b5d7fd-5a97-42e3-a990-ec2731c16433", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c94ab76-66e2-4ead-a9ea-90e5c31a5a79", "a79b53e8-0dc7-4b64-bdaa-8bc6fe3ed5f9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c94ab76-66e2-4ead-a9ea-90e5c31a5a79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab0463ff-323d-4057-b032-eb96f465ba6e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0e7c91cc-6ee2-423a-b500-7e43ef93c30c", "56732fc9-410f-4f79-b496-11a40e5db8b8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e1155ca-05a1-471c-91cb-d67605c3d990", "b3289b4c-075e-422c-94e6-9be79faa1736", "Admin", "ADMIN" });
        }
    }
}
