using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedOriginalMortgageBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42f5fc64-1150-4bf6-8b5e-9b9219c13ff4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ca0c24-f3c8-4b6b-b00e-f72ee1dabd3f");

            migrationBuilder.AddColumn<double>(
                name: "OriginalMortgageBalance",
                table: "Properties",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58faa9e6-ba51-4842-881d-84929c79df09", "16205c61-2948-4c78-a0a8-dc5231e6c01d", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "35739965-7001-49b6-9776-979e69a38960", "f2657b7f-2769-4889-a2cc-0ae56cf75a41", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35739965-7001-49b6-9776-979e69a38960");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58faa9e6-ba51-4842-881d-84929c79df09");

            migrationBuilder.DropColumn(
                name: "OriginalMortgageBalance",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88ca0c24-f3c8-4b6b-b00e-f72ee1dabd3f", "83f0e3a5-0fec-4687-89a8-82249fa59369", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42f5fc64-1150-4bf6-8b5e-9b9219c13ff4", "ff982105-5e7b-45f8-a96b-06093cfaa310", "Lender", "LENDER" });
        }
    }
}
