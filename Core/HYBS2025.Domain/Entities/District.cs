using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

public class District
{
    [Key]
    public int DistrictId { get; set; }
    public string DistrictName { get; set; }

    public ICollection<Structure> Structures { get; set; }
    public ICollection<OtherStructure> OtherStructures { get; set; }
}


