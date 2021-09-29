using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ShoppingCartcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "bf0a53e4-aed5-4c57-a086-798a083158d7", "b4f8f66b-a83f-4df3-aa62-0369c1bc97fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a96ef81-06a2-4512-af80-290a78177f90", "84b4842f-b2af-47b4-b8ac-3e43655e94c1", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7f2dd3e5-8c56-4a00-ab63-3143e3302873", "f4c59376-a653-48ff-9879-b127278163f8", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f24da0c2-ebca-4a8d-99d5-bab222c72a91", "96b32f50-988f-48f5-a79a-ac40700de03a", "Admin", "ADMIN" });
        }
    }
}
