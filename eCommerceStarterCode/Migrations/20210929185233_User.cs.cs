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
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                keyValue: "81db04dc-2977-4405-9baa-29f1b1644177");
=======
                keyValue: "3331a0cd-aba2-48ff-bc0c-4446f447623b");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                keyValue: "9be981de-e654-414e-840f-ef668dc64b93");
=======
                keyValue: "ecc5d198-4cbd-4421-9e90-e4d441221623");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                values: new object[] { "0e7c91cc-6ee2-423a-b500-7e43ef93c30c", "56732fc9-410f-4f79-b496-11a40e5db8b8", "User", "USER" });
=======
                values: new object[] { "34063a13-4613-4447-827a-c583337e1788", "94f46798-3b74-4ac3-b8ab-7e16f6e08a6b", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                values: new object[] { "8e1155ca-05a1-471c-91cb-d67605c3d990", "b3289b4c-075e-422c-94e6-9be79faa1736", "Admin", "ADMIN" });
=======
                values: new object[] { "b0c27b1c-16de-45bb-bbd1-d35b825de6d3", "f0fee98e-d067-4043-a4bf-3c5203bd90cc", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                keyValue: "0e7c91cc-6ee2-423a-b500-7e43ef93c30c");
=======
                keyValue: "34063a13-4613-4447-827a-c583337e1788");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                keyValue: "8e1155ca-05a1-471c-91cb-d67605c3d990");
=======
                keyValue: "b0c27b1c-16de-45bb-bbd1-d35b825de6d3");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                values: new object[] { "9be981de-e654-414e-840f-ef668dc64b93", "94625d9b-b24a-4952-b3a7-e49ac4df09f6", "User", "USER" });
=======
                values: new object[] { "ecc5d198-4cbd-4421-9e90-e4d441221623", "005c7202-11fc-4a40-a8c9-c8a289293295", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185922_User.cs.cs
                values: new object[] { "81db04dc-2977-4405-9baa-29f1b1644177", "7884bf85-810c-46f6-a3f5-d47052e2a6cd", "Admin", "ADMIN" });
=======
                values: new object[] { "3331a0cd-aba2-48ff-bc0c-4446f447623b", "b3ee4ca4-a27c-4d2d-b583-158b0fd62707", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185233_User.cs.cs
        }
    }
}
