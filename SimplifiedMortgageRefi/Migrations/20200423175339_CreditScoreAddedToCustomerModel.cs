using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class CreditScoreAddedToCustomerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1320a4c8-e25d-4b3e-8744-f36b8138b662");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae150da3-c3de-464e-a197-3a097db20d81");

            migrationBuilder.DropColumn(
                name: "CreditScore",
                table: "LoanProfiles");

            migrationBuilder.AddColumn<int>(
                name: "CreditScore",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a02ddb28-20ff-49d9-8569-ea69186a7c79", "058c2a8e-1505-41cf-8c40-19516f3d02a3", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ed31d1b6-7d29-4a25-b9e8-a53afa387ea2", "cfb9b369-04b2-4f87-8d54-29290de4c5b7", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a02ddb28-20ff-49d9-8569-ea69186a7c79");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed31d1b6-7d29-4a25-b9e8-a53afa387ea2");

            migrationBuilder.DropColumn(
                name: "CreditScore",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "CreditScore",
                table: "LoanProfiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae150da3-c3de-464e-a197-3a097db20d81", "6c0b1a81-d11a-45da-82ae-23c634d1c257", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1320a4c8-e25d-4b3e-8744-f36b8138b662", "f8bf3f7c-9bc3-4aa5-b22b-b3f8b3c1e7b2", "Lender", "LENDER" });
        }
    }
}
