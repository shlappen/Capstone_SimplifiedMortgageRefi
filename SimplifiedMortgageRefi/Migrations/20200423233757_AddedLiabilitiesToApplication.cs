using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedLiabilitiesToApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02ddb28-20ff-49d9-8569-ea69186a7c79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed31d1b6-7d29-4a25-b9e8-a53afa387ea2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "332c3509-9b2f-4d6d-8cb8-c7da15a5de8e", "0d07e467-5f0f-4483-9192-980070d5c301", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29613626-5006-4fbf-b4b4-3cd779121870", "282e5ebd-1fc1-4171-8689-f174b81209ab", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29613626-5006-4fbf-b4b4-3cd779121870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "332c3509-9b2f-4d6d-8cb8-c7da15a5de8e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a02ddb28-20ff-49d9-8569-ea69186a7c79", "058c2a8e-1505-41cf-8c40-19516f3d02a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed31d1b6-7d29-4a25-b9e8-a53afa387ea2", "cfb9b369-04b2-4f87-8d54-29290de4c5b7", "Lender", "LENDER" });
        }
    }
}
