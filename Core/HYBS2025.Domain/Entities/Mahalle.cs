using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Mahalle
    {

        public int MahalleID { get; set; }
        public string MahalleAdi { get; set; }
        public int IlceID { get; set; }
        public Ilce Ilce { get; set; }
    }
}
