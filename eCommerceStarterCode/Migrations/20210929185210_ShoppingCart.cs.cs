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
                keyValue: "825f7e18-8791-43e7-9150-7129e2b47817");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecc5d198-4cbd-4421-9e90-e4d441221623", "005c7202-11fc-4a40-a8c9-c8a289293295", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3331a0cd-aba2-48ff-bc0c-4446f447623b", "b3ee4ca4-a27c-4d2d-b583-158b0fd62707", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "825f7e18-8791-43e7-9150-7129e2b47817", "190d252e-0c5b-4d3c-abbb-59f8a6a5b44e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916", "b86830fc-9f58-45c2-b98c-a8ac6d58a495", "Admin", "ADMIN" });
        }
    }
}
