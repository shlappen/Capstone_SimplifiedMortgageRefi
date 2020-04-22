using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class RemovedIncomeClassForSimplification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85fd18f0-74b5-4f0b-a66b-ca76f5066ead");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f409bf55-995e-4718-a6bb-568259f0662a");

            migrationBuilder.AddColumn<double>(
                name: "MonthlyIncome",
                table: "Customers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0252a57-f73b-47ec-a3d3-7e9b51be14e7", "23d585ab-f1e2-4b2b-b437-5fc49541e5b0", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f4d38bac-88b0-4e23-9ef2-e74cc6874b54", "446ddb7a-71c3-4dd3-a8f4-307c74f5e736", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0252a57-f73b-47ec-a3d3-7e9b51be14e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4d38bac-88b0-4e23-9ef2-e74cc6874b54");

            migrationBuilder.DropColumn(
                name: "MonthlyIncome",
                table: "Customers");

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsIncluded = table.Column<bool>(type: "bit", nullable: false),
                    LoanProfileId = table.Column<int>(type: "int", nullable: false),
                    MonthlyGross = table.Column<double>(type: "float", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_LoanProfiles_LoanProfileId",
                        column: x => x.LoanProfileId,
                        principalTable: "LoanProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f409bf55-995e-4718-a6bb-568259f0662a", "cac862af-1a14-469c-b239-5e5f08485cec", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85fd18f0-74b5-4f0b-a66b-ca76f5066ead", "1b724da2-3987-44cf-bc62-ef98c2ec8b26", "Lender", "LENDER" });

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_LoanProfileId",
                table: "Incomes",
                column: "LoanProfileId");
        }
    }
}
