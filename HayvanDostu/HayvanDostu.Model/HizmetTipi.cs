using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class HizmetTipi:IBaseEntity
    {
        public int HizmetTipiID { get; set; }
        public string HizmetTipiAdi { get; set; }
    }
}
