using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class UpdatedPropertyTypeAndOccupancyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "888d7eb1-edfe-453d-ac90-ef411df295eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb36fa99-fe2e-4256-85f8-d680ffa30597");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c9e0cea0-4ea4-48ca-8788-9dc2744f35ba", "f7478e90-55da-47dc-81fe-8bfefca97728", "Customer", "CUSTOMER" },
                    { "ff57c975-ab40-46bf-95ac-8f6e92e8f1c3", "c30b276d-9b78-462e-b454-d482ef3be223", "Lender", "LENDER" }
                });

            migrationBuilder.InsertData(
                table: "OccupancyTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Primary Residence" },
                    { 2, "Investment Property" },
                    { 3, "Second Home" },
                    { 4, "Family Member Lives Here" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "PropertyTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Single Family" },
                    { 2, "Condominium" },
                    { 3, "Townhouse" },
                    { 4, "Multi-Family" },
                    { 5, "Other" }
                });

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "lower my rate and payment");

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "tap into my equity");

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "shorten my term");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9e0cea0-4ea4-48ca-8788-9dc2744f35ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff57c975-ab40-46bf-95ac-8f6e92e8f1c3");

            migrationBuilder.DeleteData(
                table: "OccupancyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OccupancyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OccupancyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OccupancyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OccupancyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "888d7eb1-edfe-453d-ac90-ef411df295eb", "12ee3aee-5d34-45e5-a456-0d1421669c66", "Customer", "CUSTOMER" },
                    { "cb36fa99-fe2e-4256-85f8-d680ffa30597", "cb260c55-9c11-4edf-bb55-35b192f1b8a3", "Lender", "LENDER" }
                });

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "lower my rate and payment.");

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "tap into my equity.");

            migrationBuilder.UpdateData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "shorten my term so I can pay less interest in the long run.");
        }
    }
}
