using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAISv1.Models;

public class Asset
{
    [Required][Key]
    public int TagId { get; set; }
    public int SerialNumber { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }
    public string? PlantName { get; set; }
    public string? EquipmentType { get; set; }
    public string? MaterialType { get; set; }
    [DataType(DataType.Date)]
    public DateTime PurchaseDate { get; set; }
    [Display(Name = "ReNewal Date")]
    [DataType(DataType.Date)]
    public DateTime RenewalDate { get; set; }
    public string? ManufacturerName { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}