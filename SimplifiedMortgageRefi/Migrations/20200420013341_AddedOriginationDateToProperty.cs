using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedOriginationDateToProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "085c30f2-b4a3-4a97-8821-16fc8b70cb66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8383162f-20b8-4fe4-96d9-f14cd2f1b965");

            migrationBuilder.AddColumn<DateTime>(
                name: "OriginationDate",
                table: "Properties",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "88ca0c24-f3c8-4b6b-b00e-f72ee1dabd3f", "83f0e3a5-0fec-4687-89a8-82249fa59369", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42f5fc64-1150-4bf6-8b5e-9b9219c13ff4", "ff982105-5e7b-45f8-a96b-06093cfaa310", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42f5fc64-1150-4bf6-8b5e-9b9219c13ff4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88ca0c24-f3c8-4b6b-b00e-f72ee1dabd3f");

            migrationBuilder.DropColumn(
                name: "OriginationDate",
                table: "Properties");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8383162f-20b8-4fe4-96d9-f14cd2f1b965", "4d2dbd75-0edd-4035-9856-9d63df86820a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "085c30f2-b4a3-4a97-8821-16fc8b70cb66", "661b1828-b7f3-4d4e-b4a0-86c19fc63f65", "Lender", "LENDER" });
        }
    }
}
