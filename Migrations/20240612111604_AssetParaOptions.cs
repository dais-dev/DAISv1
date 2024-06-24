using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAISv1.Migrations
{
    /// <inheritdoc />
    public partial class AssetParaOptions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AssetParameterOptions",
                columns: table => new
                {
                    ParaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EquipmentTypes = table.Column<string>(type: "TEXT", nullable: false),
                    AssetMaterialTypes = table.Column<string>(type: "TEXT", nullable: false),
                    AssetRegions = table.Column<string>(type: "TEXT", nullable: false),
                    LocationsOfOperation = table.Column<string>(type: "TEXT", nullable: false),
                    LocationsWithRFID = table.Column<string>(type: "TEXT", nullable: false),
                    Divisions = table.Column<string>(type: "TEXT", nullable: false),
                    ManufacturerNames = table.Column<string>(type: "TEXT", nullable: false),
                    SupplierNames = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetParameterOptions", x => x.ParaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetParameterOptions");

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
    }
}
