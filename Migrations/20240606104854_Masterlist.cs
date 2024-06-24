using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAISv1.Migrations
{
    /// <inheritdoc />
    public partial class Masterlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssetMaterialTypes",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AssetRegions",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Divisions",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentTypes",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocationsOfOperation",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LocationsWithRFID",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerNames",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupplierNames",
                table: "Asset",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssetMaterialTypes",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "AssetRegions",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "Divisions",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "EquipmentTypes",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "LocationsOfOperation",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "LocationsWithRFID",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "ManufacturerNames",
                table: "Asset");

            migrationBuilder.DropColumn(
                name: "SupplierNames",
                table: "Asset");
        }
    }
}
