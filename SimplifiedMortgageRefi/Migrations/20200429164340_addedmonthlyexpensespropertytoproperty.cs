using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class addedmonthlyexpensespropertytoproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06867653-de16-40f8-9cb3-5241a81b7334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b4b17dd-68ee-4415-bcfc-27e7fb3205dc");

            migrationBuilder.AddColumn<double>(
                name: "MonthlyExpenses",
                table: "Properties",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "194fc574-9adf-45e2-b796-be016c02b48e", "3eb290e0-7f12-4bf4-ac3e-47884b3db560", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87a30f1f-1dc7-47f1-bbd7-8a1666e74b14", "4ffc5ddc-e2a4-4dd9-93df-88ac270a9001", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "194fc574-9adf-45e2-b796-be016c02b48e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87a30f1f-1dc7-47f1-bbd7-8a1666e74b14");

            migrationBuilder.DropColumn(
                name: "MonthlyExpenses",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b4b17dd-68ee-4415-bcfc-27e7fb3205dc", "2eece0fd-02c2-47e6-b623-0b25e76d9d38", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06867653-de16-40f8-9cb3-5241a81b7334", "78a7ff44-fb5b-4ae9-a675-ec6db3c3b12a", "Lender", "LENDER" });
        }
    }
}
