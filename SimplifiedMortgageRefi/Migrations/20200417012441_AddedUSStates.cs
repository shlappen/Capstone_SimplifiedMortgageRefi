using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedUSStates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b10f50-ec7a-4e3a-8146-332f02956797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d2856c9-3c77-4256-9af1-b95ec43cb9d0");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");

            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Abbreviation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "888d7eb1-edfe-453d-ac90-ef411df295eb", "12ee3aee-5d34-45e5-a456-0d1421669c66", "Customer", "CUSTOMER" },
                    { "cb36fa99-fe2e-4256-85f8-d680ffa30597", "cb260c55-9c11-4edf-bb55-35b192f1b8a3", "Lender", "LENDER" }
                });

            migrationBuilder.InsertData(
                table: "Purposes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "lower my rate and payment." },
                    { 2, "tap into my equity." },
                    { 3, "shorten my term so I can pay less interest in the long run." },
                    { 4, "other" }
                });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "Id", "Abbreviation", "Name" },
                values: new object[,]
                {
                    { 36, "OH", "Ohio" },
                    { 35, "ND", "North Dakota" },
                    { 34, "NC", "North Carolina" },
                    { 33, "NY", "New York" },
                    { 30, "NH", "New Hampshire" },
                    { 31, "NJ", "New Jersey" },
                    { 37, "OK", "Oklahoma" },
                    { 29, "NV", "Nevada" },
                    { 28, "NE", "Nebraska" },
                    { 32, "NM", "New Mexico" },
                    { 38, "OR", "Oregon" },
                    { 41, "SC", "South Carolina" },
                    { 40, "RH", "Rhode Island" },
                    { 27, "MT", "Montana" },
                    { 42, "SD", "South Dakota" },
                    { 43, "TN", "Tennessee" },
                    { 44, "TX", "Texas" },
                    { 45, "UT", "Utah" },
                    { 46, "VT", "Vermont" },
                    { 47, "VA", "Virginia" },
                    { 48, "WA", "Washington" },
                    { 49, "WV", "West Virginia" },
                    { 39, "PA", "Pennsylvania" },
                    { 26, "MO", "Missouri" },
                    { 23, "MI", "Michigan" },
                    { 24, "MN", "Minnesota" },
                    { 1, "AL", "Alabama" },
                    { 2, "AK", "Alaska" },
                    { 3, "AZ", "Arizona" },
                    { 4, "AR", "Arkansas" },
                    { 5, "CA", "California" },
                    { 6, "CO", "Colorado" },
                    { 7, "CT", "Connecticut" },
                    { 8, "DC", "District of Columbia" },
                    { 9, "DE", "Delaware" },
                    { 10, "FL", "Florida" },
                    { 11, "GA", "Georgia" },
                    { 12, "HI", "Hawaii" },
                    { 13, "ID", "Idaho" },
                    { 14, "IL", "Illinois" },
                    { 15, "IN", "Indiana" },
                    { 16, "IA", "Iowa" },
                    { 17, "KS", "Kansas" },
                    { 18, "KY", "Kentucky" },
                    { 19, "LA", "Louisiana" },
                    { 20, "ME", "Maine" },
                    { 21, "MD", "Maryland" },
                    { 22, "MA", "Massachusetts" },
                    { 50, "WI", "Wisconsin" },
                    { 25, "MS", "Mississippi" },
                    { 51, "WY", "Wyoming" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_StateId",
                table: "Addresses",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_States_StateId",
                table: "Addresses",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_States_StateId",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_StateId",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "888d7eb1-edfe-453d-ac90-ef411df295eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb36fa99-fe2e-4256-85f8-d680ffa30597");

            migrationBuilder.DeleteData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purposes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Addresses");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31b10f50-ec7a-4e3a-8146-332f02956797", "326f0358-0937-42aa-bafd-ee23a707a214", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d2856c9-3c77-4256-9af1-b95ec43cb9d0", "197c8d0a-a484-4d82-aec5-920aa703f337", "Lender", "LENDER" });
        }
    }
}
