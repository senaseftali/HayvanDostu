using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Hizmet:IBaseEntity
    {
        public int HizmetID { get; set; }
        public string HizmetAdi { get; set; }
        public int? HizmetTipiID { get; set; }

        public HizmetTipi HizmetTipi { get; set; }
    }
}
