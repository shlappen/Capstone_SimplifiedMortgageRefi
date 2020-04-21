using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedClosingCostToLoanProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35739965-7001-49b6-9776-979e69a38960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58faa9e6-ba51-4842-881d-84929c79df09");

            migrationBuilder.AddColumn<double>(
                name: "ClosingCost",
                table: "LoanProfiles",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f409bf55-995e-4718-a6bb-568259f0662a", "cac862af-1a14-469c-b239-5e5f08485cec", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85fd18f0-74b5-4f0b-a66b-ca76f5066ead", "1b724da2-3987-44cf-bc62-ef98c2ec8b26", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85fd18f0-74b5-4f0b-a66b-ca76f5066ead");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f409bf55-995e-4718-a6bb-568259f0662a");

            migrationBuilder.DropColumn(
                name: "ClosingCost",
                table: "LoanProfiles");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58faa9e6-ba51-4842-881d-84929c79df09", "16205c61-2948-4c78-a0a8-dc5231e6c01d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35739965-7001-49b6-9776-979e69a38960", "f2657b7f-2769-4889-a2cc-0ae56cf75a41", "Lender", "LENDER" });
        }
    }
}
