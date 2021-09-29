using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ApplicationDbContextModelSnapshotcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01a73aa3-dcb8-49bc-ab75-48571ba41249");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8c356f8-7010-4eae-8328-e2071b937c68");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "beafbe54-7186-4693-ac45-e4b6219d8522", "489132b1-5ebd-4b09-9f5c-7f59dea44dda", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "08cd62dc-c685-4a93-9687-d3a672d9bf10", "6ff9db1d-cb70-4cf0-b579-d1e7789ab38b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08cd62dc-c685-4a93-9687-d3a672d9bf10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "beafbe54-7186-4693-ac45-e4b6219d8522");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d8c356f8-7010-4eae-8328-e2071b937c68", "8db81caa-5cd2-432c-bad1-6436f0934ebb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "01a73aa3-dcb8-49bc-ab75-48571ba41249", "1adc717a-e734-49fc-8c1e-6f633007bb3d", "Admin", "ADMIN" });
        }
    }
}
