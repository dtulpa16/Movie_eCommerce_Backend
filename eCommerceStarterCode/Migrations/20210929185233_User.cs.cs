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
                keyValue: "3331a0cd-aba2-48ff-bc0c-4446f447623b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecc5d198-4cbd-4421-9e90-e4d441221623");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "34063a13-4613-4447-827a-c583337e1788", "94f46798-3b74-4ac3-b8ab-7e16f6e08a6b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b0c27b1c-16de-45bb-bbd1-d35b825de6d3", "f0fee98e-d067-4043-a4bf-3c5203bd90cc", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34063a13-4613-4447-827a-c583337e1788");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0c27b1c-16de-45bb-bbd1-d35b825de6d3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecc5d198-4cbd-4421-9e90-e4d441221623", "005c7202-11fc-4a40-a8c9-c8a289293295", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3331a0cd-aba2-48ff-bc0c-4446f447623b", "b3ee4ca4-a27c-4d2d-b583-158b0fd62707", "Admin", "ADMIN" });
        }
    }
}
