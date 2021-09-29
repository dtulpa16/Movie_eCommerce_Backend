using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ShoppingCartscs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "9be981de-e654-414e-840f-ef668dc64b93", "94625d9b-b24a-4952-b3a7-e49ac4df09f6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81db04dc-2977-4405-9baa-29f1b1644177", "7884bf85-810c-46f6-a3f5-d47052e2a6cd", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81db04dc-2977-4405-9baa-29f1b1644177");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9be981de-e654-414e-840f-ef668dc64b93");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "222d2ef8-a619-44fa-b338-7985ad03a3e7", "975f62ec-eb34-4305-87d1-6e6bcff0dabc", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "906a2c73-4154-48f2-9641-0735f98b39f2", "66b77120-11ad-4735-9f83-ef0ad07b5b1f", "Admin", "ADMIN" });
        }
    }
}
