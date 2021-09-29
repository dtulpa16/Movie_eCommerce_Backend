using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Userscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a96ef81-06a2-4512-af80-290a78177f90");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf0a53e4-aed5-4c57-a086-798a083158d7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "74c51dca-1ce5-44e7-ac23-a3a34c6e1062", "f21cb7dc-2448-4322-b2db-52b4e338ab98", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5d336be-1d11-47e1-ae73-950b8e2a900b", "d303e072-5c97-4c73-9853-effe696a359f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74c51dca-1ce5-44e7-ac23-a3a34c6e1062");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5d336be-1d11-47e1-ae73-950b8e2a900b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf0a53e4-aed5-4c57-a086-798a083158d7", "b4f8f66b-a83f-4df3-aa62-0369c1bc97fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a96ef81-06a2-4512-af80-290a78177f90", "84b4842f-b2af-47b4-b8ac-3e43655e94c1", "Admin", "ADMIN" });
        }
    }
}
