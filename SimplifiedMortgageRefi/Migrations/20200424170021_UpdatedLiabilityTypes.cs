using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class UpdatedLiabilityTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b80326c-8db1-485b-b334-f19f19f8869f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90c8048-ba81-4a34-9bf9-c73733835cc9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f366fded-6115-499f-84ef-ddbc0c882244", "79bd7dca-39e5-45c4-a8ad-58d81bccbeb2", "Customer", "CUSTOMER" },
                    { "f0abe82e-0e34-4341-b9e8-843d37f46ef0", "c44e891d-ee40-426c-a9e1-ad79e815cde7", "Lender", "LENDER" }
                });

            migrationBuilder.InsertData(
                table: "LiabilityTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Credit Card" },
                    { 2, "Loan" },
                    { 3, "Lease" },
                    { 4, "Mortgage" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0abe82e-0e34-4341-b9e8-843d37f46ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f366fded-6115-499f-84ef-ddbc0c882244");

            migrationBuilder.DeleteData(
                table: "LiabilityTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LiabilityTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LiabilityTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LiabilityTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b80326c-8db1-485b-b334-f19f19f8869f", "1c79eb43-e9d5-4136-8943-de577748b4c9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b90c8048-ba81-4a34-9bf9-c73733835cc9", "5f078478-37ac-4d62-8ce0-43750ef16d48", "Lender", "LENDER" });
        }
    }
}
