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
                keyValue: "80d639d9-63b3-4a58-8193-c421024a0f35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ceeb1da3-e447-4c89-95e2-0fe70744840b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "222d2ef8-a619-44fa-b338-7985ad03a3e7", "975f62ec-eb34-4305-87d1-6e6bcff0dabc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "906a2c73-4154-48f2-9641-0735f98b39f2", "66b77120-11ad-4735-9f83-ef0ad07b5b1f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "222d2ef8-a619-44fa-b338-7985ad03a3e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "906a2c73-4154-48f2-9641-0735f98b39f2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80d639d9-63b3-4a58-8193-c421024a0f35", "be4d8d18-f212-460a-9afa-aeca370dad41", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ceeb1da3-e447-4c89-95e2-0fe70744840b", "ddbc533f-68f9-4c9e-835e-1d9946d7c6be", "Admin", "ADMIN" });
        }
    }
}
