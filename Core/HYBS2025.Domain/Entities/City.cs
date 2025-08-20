using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

public class City
{
    [Key]
    public int CityId { get; set; }
    public string CityName { get; set; }

    // Navigation properties
    public ICollection<Structure> Structures { get; set; }
    public ICollection<OtherStructure> OtherStructures { get; set; }
}
