using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class addedDEbtToINCOMETOPROPERTY : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6bd8df5-b51e-4379-9618-b6d2ec6bf970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc5b4b16-fd2e-41b9-bd59-6d0f91f058e9");

            migrationBuilder.AddColumn<double>(
                name: "DebtToIncome",
                table: "Properties",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3b4b17dd-68ee-4415-bcfc-27e7fb3205dc", "2eece0fd-02c2-47e6-b623-0b25e76d9d38", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "06867653-de16-40f8-9cb3-5241a81b7334", "78a7ff44-fb5b-4ae9-a675-ec6db3c3b12a", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06867653-de16-40f8-9cb3-5241a81b7334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b4b17dd-68ee-4415-bcfc-27e7fb3205dc");

            migrationBuilder.DropColumn(
                name: "DebtToIncome",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc5b4b16-fd2e-41b9-bd59-6d0f91f058e9", "55ebf964-fc5a-4f69-9e0b-86fb75230c0b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6bd8df5-b51e-4379-9618-b6d2ec6bf970", "7d446626-2198-4bc8-9668-b16e031a0493", "Lender", "LENDER" });
        }
    }
}
