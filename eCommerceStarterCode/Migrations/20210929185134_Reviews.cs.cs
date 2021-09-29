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
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                keyValue: "80d639d9-63b3-4a58-8193-c421024a0f35");
=======
                keyValue: "12bd022e-5f53-4226-9174-c02d6e5b197f");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                keyValue: "ceeb1da3-e447-4c89-95e2-0fe70744840b");
=======
                keyValue: "e0675af5-e60c-47cf-a5dc-5ebb141f8116");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                values: new object[] { "222d2ef8-a619-44fa-b338-7985ad03a3e7", "975f62ec-eb34-4305-87d1-6e6bcff0dabc", "User", "USER" });
=======
                values: new object[] { "825f7e18-8791-43e7-9150-7129e2b47817", "190d252e-0c5b-4d3c-abbb-59f8a6a5b44e", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                values: new object[] { "906a2c73-4154-48f2-9641-0735f98b39f2", "66b77120-11ad-4735-9f83-ef0ad07b5b1f", "Admin", "ADMIN" });
=======
                values: new object[] { "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916", "b86830fc-9f58-45c2-b98c-a8ac6d58a495", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                keyValue: "222d2ef8-a619-44fa-b338-7985ad03a3e7");
=======
                keyValue: "825f7e18-8791-43e7-9150-7129e2b47817");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                keyValue: "906a2c73-4154-48f2-9641-0735f98b39f2");
=======
                keyValue: "aa34a7fd-bd4c-4c2c-aac2-d5e92148e916");
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                values: new object[] { "80d639d9-63b3-4a58-8193-c421024a0f35", "be4d8d18-f212-460a-9afa-aeca370dad41", "User", "USER" });
=======
                values: new object[] { "12bd022e-5f53-4226-9174-c02d6e5b197f", "16805ff8-1939-430e-bcc4-2f78c0b68a24", "User", "USER" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<< HEAD:eCommerceStarterCode/Migrations/20210929185718_Reviews.cs.cs
                values: new object[] { "ceeb1da3-e447-4c89-95e2-0fe70744840b", "ddbc533f-68f9-4c9e-835e-1d9946d7c6be", "Admin", "ADMIN" });
=======
                values: new object[] { "e0675af5-e60c-47cf-a5dc-5ebb141f8116", "8d6e839c-2fbc-4c1a-95d8-62b83d9d096a", "Admin", "ADMIN" });
>>>>>>> 3ec7c4ce8fda5343af7b9663a372ab4ba9929780:eCommerceStarterCode/Migrations/20210929185134_Reviews.cs.cs
        }
    }
}
