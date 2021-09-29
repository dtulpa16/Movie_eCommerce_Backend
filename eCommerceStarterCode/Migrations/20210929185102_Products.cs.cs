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
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                keyValue: "514cd79e-0f09-49a7-89fe-e3cccd5f35a7");
=======
                keyValue: "6f3bb06b-e420-4f7c-babe-94ddbb3e1386");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                keyValue: "9b34da58-cd9e-44fc-9ab3-5bdfef0c8df0");
=======
                keyValue: "866d26b7-ee82-4540-a876-a612c280bdc2");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                values: new object[] { "80d639d9-63b3-4a58-8193-c421024a0f35", "be4d8d18-f212-460a-9afa-aeca370dad41", "User", "USER" });
=======
                values: new object[] { "12bd022e-5f53-4226-9174-c02d6e5b197f", "16805ff8-1939-430e-bcc4-2f78c0b68a24", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                values: new object[] { "ceeb1da3-e447-4c89-95e2-0fe70744840b", "ddbc533f-68f9-4c9e-835e-1d9946d7c6be", "Admin", "ADMIN" });
=======
                values: new object[] { "e0675af5-e60c-47cf-a5dc-5ebb141f8116", "8d6e839c-2fbc-4c1a-95d8-62b83d9d096a", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                keyValue: "80d639d9-63b3-4a58-8193-c421024a0f35");
=======
                keyValue: "12bd022e-5f53-4226-9174-c02d6e5b197f");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                keyValue: "ceeb1da3-e447-4c89-95e2-0fe70744840b");
=======
                keyValue: "e0675af5-e60c-47cf-a5dc-5ebb141f8116");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                values: new object[] { "514cd79e-0f09-49a7-89fe-e3cccd5f35a7", "34d4ee88-6d43-454b-acd1-00f12f6279fe", "User", "USER" });
=======
                values: new object[] { "6f3bb06b-e420-4f7c-babe-94ddbb3e1386", "5fafa973-6bb7-43a4-af1a-5208f8b071b8", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185650_Products.cs.cs
                values: new object[] { "9b34da58-cd9e-44fc-9ab3-5bdfef0c8df0", "93f9fce2-5def-4b19-a085-798e473dfb24", "Admin", "ADMIN" });
=======
                values: new object[] { "866d26b7-ee82-4540-a876-a612c280bdc2", "809cd948-7272-404d-8a36-1f3cc40949ca", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185102_Products.cs.cs
        }
    }
}
