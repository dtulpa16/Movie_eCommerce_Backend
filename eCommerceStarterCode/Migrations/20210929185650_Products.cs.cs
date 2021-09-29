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
                keyValue: "514cd79e-0f09-49a7-89fe-e3cccd5f35a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b34da58-cd9e-44fc-9ab3-5bdfef0c8df0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80d639d9-63b3-4a58-8193-c421024a0f35", "be4d8d18-f212-460a-9afa-aeca370dad41", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ceeb1da3-e447-4c89-95e2-0fe70744840b", "ddbc533f-68f9-4c9e-835e-1d9946d7c6be", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80d639d9-63b3-4a58-8193-c421024a0f35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceeb1da3-e447-4c89-95e2-0fe70744840b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "514cd79e-0f09-49a7-89fe-e3cccd5f35a7", "34d4ee88-6d43-454b-acd1-00f12f6279fe", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b34da58-cd9e-44fc-9ab3-5bdfef0c8df0", "93f9fce2-5def-4b19-a085-798e473dfb24", "Admin", "ADMIN" });
        }
    }
}
