using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class OtherStructure
    {
        [Key]
        public int OtherStructureId { get; set; }

        public string CompanyName { get; set; }
        public DateTime Tarih { get; set; }
        public string Mahalle { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }

        public int StartIsland { get; set; }
        public int FinishIsland { get; set; }   // Düzeltilmiş
        public int StartParcel { get; set; }
        public string StartDistrict { get; set; }
        public string FinishDistrict { get; set; }  // Düzeltilmiş

        public int VehicleNumber { get; set; }
        public string Vehicle { get; set; }
        public string TalepEden { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }

        // Foreign Keys
        public int CompanyId { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int NeighborhoodId { get; set; }

        // Navigation Properties
        public Company Company { get; set; }
        public City City { get; set; }
        public District District { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}
