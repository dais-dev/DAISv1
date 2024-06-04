using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAISv1.Models;

public class Asset
{
    [Required][Key]
    public int TagId { get; set; }
    public string? AssetMaterialType { get; set; }
    public string? EquipmentType { get; set; }
    public int AssetCode { get; set; }
    public int AssetQuantity { get; set; } = 1;
    public string? AssetRegion { get; set; }
    public string? LocationOfOperation { get; set; }
    public string? LocationWithRFID { get; set; }
    public string? Division { get; set; }
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }
    
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
    public DateTime YearOfInstallation { get; set; }
    [DataType(DataType.Date)]
    public DateTime DesignLifeDate { get; set; }
    [DataType(DataType.Date)]
    public DateTime EndOfPeriodLifeDate { get; set; }
    public string? ManufacturerName { get; set; }
    public string? SupplierName { get; set; }
    public int ModelSerialNumber    { get; set; }

}