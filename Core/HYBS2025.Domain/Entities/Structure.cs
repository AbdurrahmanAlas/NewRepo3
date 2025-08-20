using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Structure
    {
        [Key]
        public int StructureId { get; set; }

        public string CompanyName { get; set; }
        public string Reason { get; set; }
        public string PermitNumber { get; set; }
        public string VehiclePlaka { get; set; }
        public string UreticiName { get; set; }
        public string UreticiPhone { get; set; }
        public string UreticiAddress { get; set; }
        public int Island { get; set; }
        public int Parcel { get; set; }
        public string Blok { get; set; }
        public string DistrictName { get; set; }
        public string Mahalle { get; set; }
        public string Excavation { get; set; }
        public string Filling { get; set; }
        public string EmptyExcavation { get; set; }
        public string AtikCinsi { get; set; }
        public string Casting { get; set; }
        public string ExcavationAddress { get; set; }
        public string Note { get; set; }
        public string EnsonIslem { get; set; }
        public string BekleyenIslem { get; set; }
        //DENEME
        public decimal Kazi { get; set; }
        public decimal Dolgu { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPhoto { get; set; }
        public string DocumentTipi { get; set; }
        public DateTime OnayDate { get; set; }

        // Company ilişkisi
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        // City / District / Neighborhood ilişkileri
        public int CityId { get; set; }
        public City City { get; set; }

        public int DistrictId { get; set; }
        public District District { get; set; }

        public int NeighborhoodId { get; set; }
        public Neighborhood Neighborhood { get; set; }
    }
}
