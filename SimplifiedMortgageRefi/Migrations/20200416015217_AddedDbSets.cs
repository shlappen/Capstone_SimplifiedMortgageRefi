using Microsoft.EntityFrameworkCore.Migrations;

namespace SimplifiedMortgageRefi.Migrations
{
    public partial class AddedDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Customers_Application_ApplicationId",
                table: "Applications_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Customers_Customer_ApplicationId",
                table: "Applications_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Application_ApplicationId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Lender_LenderId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Properties_Customer_CustomerId",
                table: "Customers_Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Properties_Property_PropertyId",
                table: "Customers_Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Income_LoanProfile_LoanProfileId",
                table: "Income");

            migrationBuilder.DropForeignKey(
                name: "FK_Liability_Application_ApplicationId",
                table: "Liability");

            migrationBuilder.DropForeignKey(
                name: "FK_Liability_LiabilityType_LiabilityTypeId",
                table: "Liability");

            migrationBuilder.DropForeignKey(
                name: "FK_Liability_LoanProfile_LoanProfileId",
                table: "Liability");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProfile_Application_ApplicationId",
                table: "LoanProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProfile_Purpose_PurposeId",
                table: "LoanProfile");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_Address_AddressId",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_OccupancyType_OccupancyTypeId",
                table: "Property");

            migrationBuilder.DropForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeId",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purpose",
                table: "Purpose");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyType",
                table: "PropertyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Property",
                table: "Property");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OccupancyType",
                table: "OccupancyType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanProfile",
                table: "LoanProfile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LiabilityType",
                table: "LiabilityType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liability",
                table: "Liability");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lender",
                table: "Lender");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Income",
                table: "Income");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Application",
                table: "Application");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f6d7ece-8640-406c-9cbf-7fce71b90b74");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cad0610a-9faa-472d-9a11-4ce377beb1fb");

            migrationBuilder.RenameTable(
                name: "Purpose",
                newName: "Purposes");

            migrationBuilder.RenameTable(
                name: "PropertyType",
                newName: "PropertyTypes");

            migrationBuilder.RenameTable(
                name: "Property",
                newName: "Properties");

            migrationBuilder.RenameTable(
                name: "OccupancyType",
                newName: "OccupancyTypes");

            migrationBuilder.RenameTable(
                name: "LoanProfile",
                newName: "LoanProfiles");

            migrationBuilder.RenameTable(
                name: "LiabilityType",
                newName: "LiabilityTypes");

            migrationBuilder.RenameTable(
                name: "Liability",
                newName: "Liabilities");

            migrationBuilder.RenameTable(
                name: "Lender",
                newName: "Lenders");

            migrationBuilder.RenameTable(
                name: "Income",
                newName: "Incomes");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Application",
                newName: "Applications");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Property_PropertyTypeId",
                table: "Properties",
                newName: "IX_Properties_PropertyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_OccupancyTypeId",
                table: "Properties",
                newName: "IX_Properties_OccupancyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Property_AddressId",
                table: "Properties",
                newName: "IX_Properties_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanProfile_PurposeId",
                table: "LoanProfiles",
                newName: "IX_LoanProfiles_PurposeId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanProfile_ApplicationId",
                table: "LoanProfiles",
                newName: "IX_LoanProfiles_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Liability_LoanProfileId",
                table: "Liabilities",
                newName: "IX_Liabilities_LoanProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Liability_LiabilityTypeId",
                table: "Liabilities",
                newName: "IX_Liabilities_LiabilityTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Liability_ApplicationId",
                table: "Liabilities",
                newName: "IX_Liabilities_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Income_LoanProfileId",
                table: "Incomes",
                newName: "IX_Incomes_LoanProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customers",
                newName: "IX_Customers_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_LenderId",
                table: "Contacts",
                newName: "IX_Contacts_LenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_ApplicationId",
                table: "Contacts",
                newName: "IX_Contacts_ApplicationId");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Lenders",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purposes",
                table: "Purposes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyTypes",
                table: "PropertyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Properties",
                table: "Properties",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OccupancyTypes",
                table: "OccupancyTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanProfiles",
                table: "LoanProfiles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LiabilityTypes",
                table: "LiabilityTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lenders",
                table: "Lenders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Applications",
                table: "Applications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31b10f50-ec7a-4e3a-8146-332f02956797", "326f0358-0937-42aa-bafd-ee23a707a214", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d2856c9-3c77-4256-9af1-b95ec43cb9d0", "197c8d0a-a484-4d82-aec5-920aa703f337", "Lender", "LENDER" });

            migrationBuilder.CreateIndex(
                name: "IX_Lenders_IdentityUserId",
                table: "Lenders",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Customers_Applications_ApplicationId",
                table: "Applications_Customers",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Customers_Customers_ApplicationId",
                table: "Applications_Customers",
                column: "ApplicationId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Applications_ApplicationId",
                table: "Contacts",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Lenders_LenderId",
                table: "Contacts",
                column: "LenderId",
                principalTable: "Lenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Properties_Customers_CustomerId",
                table: "Customers_Properties",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Properties_Properties_PropertyId",
                table: "Customers_Properties",
                column: "PropertyId",
                principalTable: "Properties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_LoanProfiles_LoanProfileId",
                table: "Incomes",
                column: "LoanProfileId",
                principalTable: "LoanProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lenders_AspNetUsers_IdentityUserId",
                table: "Lenders",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Liabilities_Applications_ApplicationId",
                table: "Liabilities",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liabilities_LiabilityTypes_LiabilityTypeId",
                table: "Liabilities",
                column: "LiabilityTypeId",
                principalTable: "LiabilityTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liabilities_LoanProfiles_LoanProfileId",
                table: "Liabilities",
                column: "LoanProfileId",
                principalTable: "LoanProfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProfiles_Applications_ApplicationId",
                table: "LoanProfiles",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProfiles_Purposes_PurposeId",
                table: "LoanProfiles",
                column: "PurposeId",
                principalTable: "Purposes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Addresses_AddressId",
                table: "Properties",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_OccupancyTypes_OccupancyTypeId",
                table: "Properties",
                column: "OccupancyTypeId",
                principalTable: "OccupancyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId",
                principalTable: "PropertyTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Customers_Applications_ApplicationId",
                table: "Applications_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Customers_Customers_ApplicationId",
                table: "Applications_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Applications_ApplicationId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Lenders_LenderId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AspNetUsers_IdentityUserId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Properties_Customers_CustomerId",
                table: "Customers_Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Properties_Properties_PropertyId",
                table: "Customers_Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_LoanProfiles_LoanProfileId",
                table: "Incomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Lenders_AspNetUsers_IdentityUserId",
                table: "Lenders");

            migrationBuilder.DropForeignKey(
                name: "FK_Liabilities_Applications_ApplicationId",
                table: "Liabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Liabilities_LiabilityTypes_LiabilityTypeId",
                table: "Liabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Liabilities_LoanProfiles_LoanProfileId",
                table: "Liabilities");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProfiles_Applications_ApplicationId",
                table: "LoanProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_LoanProfiles_Purposes_PurposeId",
                table: "LoanProfiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Addresses_AddressId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_OccupancyTypes_OccupancyTypeId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_PropertyTypes_PropertyTypeId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purposes",
                table: "Purposes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertyTypes",
                table: "PropertyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Properties",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OccupancyTypes",
                table: "OccupancyTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LoanProfiles",
                table: "LoanProfiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LiabilityTypes",
                table: "LiabilityTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Liabilities",
                table: "Liabilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lenders",
                table: "Lenders");

            migrationBuilder.DropIndex(
                name: "IX_Lenders_IdentityUserId",
                table: "Lenders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Applications",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31b10f50-ec7a-4e3a-8146-332f02956797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d2856c9-3c77-4256-9af1-b95ec43cb9d0");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Lenders");

            migrationBuilder.RenameTable(
                name: "Purposes",
                newName: "Purpose");

            migrationBuilder.RenameTable(
                name: "PropertyTypes",
                newName: "PropertyType");

            migrationBuilder.RenameTable(
                name: "Properties",
                newName: "Property");

            migrationBuilder.RenameTable(
                name: "OccupancyTypes",
                newName: "OccupancyType");

            migrationBuilder.RenameTable(
                name: "LoanProfiles",
                newName: "LoanProfile");

            migrationBuilder.RenameTable(
                name: "LiabilityTypes",
                newName: "LiabilityType");

            migrationBuilder.RenameTable(
                name: "Liabilities",
                newName: "Liability");

            migrationBuilder.RenameTable(
                name: "Lenders",
                newName: "Lender");

            migrationBuilder.RenameTable(
                name: "Incomes",
                newName: "Income");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Applications",
                newName: "Application");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_PropertyTypeId",
                table: "Property",
                newName: "IX_Property_PropertyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_OccupancyTypeId",
                table: "Property",
                newName: "IX_Property_OccupancyTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_AddressId",
                table: "Property",
                newName: "IX_Property_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanProfiles_PurposeId",
                table: "LoanProfile",
                newName: "IX_LoanProfile_PurposeId");

            migrationBuilder.RenameIndex(
                name: "IX_LoanProfiles_ApplicationId",
                table: "LoanProfile",
                newName: "IX_LoanProfile_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Liabilities_LoanProfileId",
                table: "Liability",
                newName: "IX_Liability_LoanProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Liabilities_LiabilityTypeId",
                table: "Liability",
                newName: "IX_Liability_LiabilityTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Liabilities_ApplicationId",
                table: "Liability",
                newName: "IX_Liability_ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Incomes_LoanProfileId",
                table: "Income",
                newName: "IX_Income_LoanProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_IdentityUserId",
                table: "Customer",
                newName: "IX_Customer_IdentityUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_LenderId",
                table: "Contact",
                newName: "IX_Contact_LenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_ApplicationId",
                table: "Contact",
                newName: "IX_Contact_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purpose",
                table: "Purpose",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertyType",
                table: "PropertyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Property",
                table: "Property",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OccupancyType",
                table: "OccupancyType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LoanProfile",
                table: "LoanProfile",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LiabilityType",
                table: "LiabilityType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Liability",
                table: "Liability",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lender",
                table: "Lender",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Income",
                table: "Income",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Application",
                table: "Application",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f6d7ece-8640-406c-9cbf-7fce71b90b74", "089538f2-3067-48f4-be20-08b686bf8ad1", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cad0610a-9faa-472d-9a11-4ce377beb1fb", "894cb211-6d37-4bbf-8c83-554e21980358", "Lender", "LENDER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Customers_Application_ApplicationId",
                table: "Applications_Customers",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Customers_Customer_ApplicationId",
                table: "Applications_Customers",
                column: "ApplicationId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Application_ApplicationId",
                table: "Contact",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Lender_LenderId",
                table: "Contact",
                column: "LenderId",
                principalTable: "Lender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_AspNetUsers_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Properties_Customer_CustomerId",
                table: "Customers_Properties",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Properties_Property_PropertyId",
                table: "Customers_Properties",
                column: "PropertyId",
                principalTable: "Property",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Income_LoanProfile_LoanProfileId",
                table: "Income",
                column: "LoanProfileId",
                principalTable: "LoanProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liability_Application_ApplicationId",
                table: "Liability",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liability_LiabilityType_LiabilityTypeId",
                table: "Liability",
                column: "LiabilityTypeId",
                principalTable: "LiabilityType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Liability_LoanProfile_LoanProfileId",
                table: "Liability",
                column: "LoanProfileId",
                principalTable: "LoanProfile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProfile_Application_ApplicationId",
                table: "LoanProfile",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LoanProfile_Purpose_PurposeId",
                table: "LoanProfile",
                column: "PurposeId",
                principalTable: "Purpose",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_Address_AddressId",
                table: "Property",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_OccupancyType_OccupancyTypeId",
                table: "Property",
                column: "OccupancyTypeId",
                principalTable: "OccupancyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Property_PropertyType_PropertyTypeId",
                table: "Property",
                column: "PropertyTypeId",
                principalTable: "PropertyType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
