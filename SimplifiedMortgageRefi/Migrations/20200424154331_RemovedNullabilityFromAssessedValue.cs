using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class RemovedNullabilityFromAssessedValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "29613626-5006-4fbf-b4b4-3cd779121870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "332c3509-9b2f-4d6d-8cb8-c7da15a5de8e");

            migrationBuilder.AlterColumn<int>(
                name: "AssessedValue",
                table: "Properties",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b80326c-8db1-485b-b334-f19f19f8869f", "1c79eb43-e9d5-4136-8943-de577748b4c9", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b90c8048-ba81-4a34-9bf9-c73733835cc9", "5f078478-37ac-4d62-8ce0-43750ef16d48", "Lender", "LENDER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b80326c-8db1-485b-b334-f19f19f8869f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b90c8048-ba81-4a34-9bf9-c73733835cc9");

            migrationBuilder.AlterColumn<int>(
                name: "AssessedValue",
                table: "Properties",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "332c3509-9b2f-4d6d-8cb8-c7da15a5de8e", "0d07e467-5f0f-4483-9192-980070d5c301", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "29613626-5006-4fbf-b4b4-3cd779121870", "282e5ebd-1fc1-4171-8689-f174b81209ab", "Lender", "LENDER" });
        }
    }
}
