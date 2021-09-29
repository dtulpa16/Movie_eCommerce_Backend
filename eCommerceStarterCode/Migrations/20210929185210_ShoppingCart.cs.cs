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
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                keyValue: "0e7c91cc-6ee2-423a-b500-7e43ef93c30c");
=======
                keyValue: "825f7e18-8791-43e7-9150-7129e2b47817");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                keyValue: "8e1155ca-05a1-471c-91cb-d67605c3d990");
=======
                keyValue: "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                values: new object[] { "ab0463ff-323d-4057-b032-eb96f465ba6e", "a3b5d7fd-5a97-42e3-a990-ec2731c16433", "User", "USER" });
=======
                values: new object[] { "ecc5d198-4cbd-4421-9e90-e4d441221623", "005c7202-11fc-4a40-a8c9-c8a289293295", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                values: new object[] { "6c94ab76-66e2-4ead-a9ea-90e5c31a5a79", "a79b53e8-0dc7-4b64-bdaa-8bc6fe3ed5f9", "Admin", "ADMIN" });
=======
                values: new object[] { "3331a0cd-aba2-48ff-bc0c-4446f447623b", "b3ee4ca4-a27c-4d2d-b583-158b0fd62707", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                keyValue: "6c94ab76-66e2-4ead-a9ea-90e5c31a5a79");
=======
                keyValue: "3331a0cd-aba2-48ff-bc0c-4446f447623b");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                keyValue: "ab0463ff-323d-4057-b032-eb96f465ba6e");
=======
                keyValue: "ecc5d198-4cbd-4421-9e90-e4d441221623");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                values: new object[] { "0e7c91cc-6ee2-423a-b500-7e43ef93c30c", "56732fc9-410f-4f79-b496-11a40e5db8b8", "User", "USER" });
=======
                values: new object[] { "825f7e18-8791-43e7-9150-7129e2b47817", "190d252e-0c5b-4d3c-abbb-59f8a6a5b44e", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929190023_SeedRoles.cs.cs
                values: new object[] { "8e1155ca-05a1-471c-91cb-d67605c3d990", "b3289b4c-075e-422c-94e6-9be79faa1736", "Admin", "ADMIN" });
=======
                values: new object[] { "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916", "b86830fc-9f58-45c2-b98c-a8ac6d58a495", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185210_ShoppingCart.cs.cs
        }
    }
}
