using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

public class Neighborhood
{
    [Key]
    public int NeighborhoodId { get; set; }
    public string NeighborhoodName { get; set; }

    public ICollection<Structure> Structures { get; set; }
    public ICollection<OtherStructure> OtherStructures { get; set; }
}