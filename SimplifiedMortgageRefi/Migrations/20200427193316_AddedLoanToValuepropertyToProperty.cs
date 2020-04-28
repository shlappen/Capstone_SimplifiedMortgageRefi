using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedLoanToValuepropertyToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a9822b1-d581-4295-968a-fa73d2f1847c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524894d7-c29d-40ed-bb43-92c2600021f9");

            migrationBuilder.AddColumn<double>(
                name: "LoanToValue",
                table: "Properties",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc5b4b16-fd2e-41b9-bd59-6d0f91f058e9", "55ebf964-fc5a-4f69-9e0b-86fb75230c0b", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6bd8df5-b51e-4379-9618-b6d2ec6bf970", "7d446626-2198-4bc8-9668-b16e031a0493", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6bd8df5-b51e-4379-9618-b6d2ec6bf970");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc5b4b16-fd2e-41b9-bd59-6d0f91f058e9");

            migrationBuilder.DropColumn(
                name: "LoanToValue",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "524894d7-c29d-40ed-bb43-92c2600021f9", "cd06ce19-6a40-4a3c-9591-3cfc11ba9e8c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a9822b1-d581-4295-968a-fa73d2f1847c", "1ae85572-354a-46e6-bc80-0fef72e053f7", "Lender", "LENDER" });
        }
    }
}
