using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAISv1.Migrations
{
    /// <inheritdoc />
    public partial class NewParameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Asset");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "Asset",
                newName: "ModelSerialNumber");

            migrationBuilder.RenameColumn(
                name: "RenewalDate",
                table: "Asset",
                newName: "YearOfInstallation");

            migrationBuilder.RenameColumn(
                name: "PlantName",
                table: "Asset",
                newName: "SupplierName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Asset",
                newName: "LocationWithRFID");

            migrationBuilder.RenameColumn(
                name: "MaterialType",
                table: "Asset",
                newName: "LocationOfOperation");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Asset",
                newName: "Division");

            migrationBuilder.AddColumn<int>(
                name: "AssetCode",
                table: "Asset",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AssetMaterialType",
                table: "Asset",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssetQuantity",
                table: "Asset",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AssetRegion",
                table: "Asset",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DesignLifeDate",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndOfPeriodLifeDate",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetCode",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetMaterialType",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetQuantity",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetRegion",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "DesignLifeDate",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "EndOfPeriodLifeDate",
                table: "Asset");

            migrationBuilder.RenameColumn(
                name: "YearOfInstallation",
                table: "Asset",
                newName: "RenewalDate");

            migrationBuilder.RenameColumn(
                name: "SupplierName",
                table: "Asset",
                newName: "PlantName");

            migrationBuilder.RenameColumn(
                name: "ModelSerialNumber",
                table: "Asset",
                newName: "SerialNumber");

            migrationBuilder.RenameColumn(
                name: "LocationWithRFID",
                table: "Asset",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LocationOfOperation",
                table: "Asset",
                newName: "MaterialType");

            migrationBuilder.RenameColumn(
                name: "Division",
                table: "Asset",
                newName: "Location");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Asset",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
