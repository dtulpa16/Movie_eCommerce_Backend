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
                keyValue: "12bd022e-5f53-4226-9174-c02d6e5b197f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0675af5-e60c-47cf-a5dc-5ebb141f8116");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "825f7e18-8791-43e7-9150-7129e2b47817", "190d252e-0c5b-4d3c-abbb-59f8a6a5b44e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916", "b86830fc-9f58-45c2-b98c-a8ac6d58a495", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "825f7e18-8791-43e7-9150-7129e2b47817");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12bd022e-5f53-4226-9174-c02d6e5b197f", "16805ff8-1939-430e-bcc4-2f78c0b68a24", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e0675af5-e60c-47cf-a5dc-5ebb141f8116", "8d6e839c-2fbc-4c1a-95d8-62b83d9d096a", "Admin", "ADMIN" });
        }
    }
}
