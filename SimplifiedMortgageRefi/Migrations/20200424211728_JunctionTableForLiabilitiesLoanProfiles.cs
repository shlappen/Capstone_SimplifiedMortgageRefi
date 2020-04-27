using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class JunctionTableForLiabilitiesLoanProfiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Liabilities_LoanProfiles_LoanProfileId",
                table: "Liabilities");

            migrationBuilder.DropIndex(
                name: "IX_Liabilities_LoanProfileId",
                table: "Liabilities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0abe82e-0e34-4341-b9e8-843d37f46ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f366fded-6115-499f-84ef-ddbc0c882244");

            migrationBuilder.DropColumn(
                name: "LoanProfileId",
                table: "Liabilities");

            migrationBuilder.CreateTable(
                name: "Liabilities_LoanProfiles",
                columns: table => new
                {
                    LiabilityId = table.Column<int>(nullable: false),
                    LoanProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liabilities_LoanProfiles", x => new { x.LiabilityId, x.LoanProfileId });
                    table.ForeignKey(
                        name: "FK_Liabilities_LoanProfiles_Liabilities_LiabilityId",
                        column: x => x.LiabilityId,
                        principalTable: "Liabilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Liabilities_LoanProfiles_LoanProfiles_LoanProfileId",
                        column: x => x.LoanProfileId,
                        principalTable: "LoanProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "524894d7-c29d-40ed-bb43-92c2600021f9", "cd06ce19-6a40-4a3c-9591-3cfc11ba9e8c", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0a9822b1-d581-4295-968a-fa73d2f1847c", "1ae85572-354a-46e6-bc80-0fef72e053f7", "Lender", "LENDER" });

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_LoanProfiles_LoanProfileId",
                table: "Liabilities_LoanProfiles",
                column: "LoanProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liabilities_LoanProfiles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a9822b1-d581-4295-968a-fa73d2f1847c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "524894d7-c29d-40ed-bb43-92c2600021f9");

            migrationBuilder.AddColumn<int>(
                name: "LoanProfileId",
                table: "Liabilities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f366fded-6115-499f-84ef-ddbc0c882244", "79bd7dca-39e5-45c4-a8ad-58d81bccbeb2", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0abe82e-0e34-4341-b9e8-843d37f46ef0", "c44e891d-ee40-426c-a9e1-ad79e815cde7", "Lender", "LENDER" });

            migrationBuilder.CreateIndex(
                name: "IX_Liabilities_LoanProfileId",
                table: "Liabilities",
                column: "LoanProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Liabilities_LoanProfiles_LoanProfileId",
                table: "Liabilities",
                column: "LoanProfileId",
                principalTable: "LoanProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
