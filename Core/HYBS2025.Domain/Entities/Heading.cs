﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
 
        public string HeadingName { get; set; }
        public string HeadingAdres { get; set; }
        public string HeadingAda { get; set; }
        public string HeadingParsel { get; set; }
        public string Phone { get; set; }
        public string VehiclePlaka { get; set; }
        public DateTime HeadingDate { get; set; }
        public bool HeadingStatus { get; set; }
        public ICollection<Content> Contents { get; set; }
        public string AddedByUserName { get; set; }
        public string AddedByUserNamee { get; set; }
    }
}
