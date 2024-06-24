using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAISv1.Models;

public class AssetParameterOptions
{
[Required][Key]
    public int ParaId { get; set; }
    public List<string> EquipmentTypes { get; set; }
    public List<string> AssetMaterialTypes { get; set; }
    public List<string> AssetRegions { get; set; }
    public List<string> LocationsOfOperation { get; set; }
    public List<string> LocationsWithRFID { get; set; }
    public List<string> Divisions { get; set; }
    public List<string> ManufacturerNames { get; set; }
    public List<string> SupplierNames { get; set; }

    
// Constructor to initialize the lists

}