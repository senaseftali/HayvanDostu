using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class HayvanIrk:IBaseEntity
    {
        public int HayvanIrkID { get; set; }
        public string HayvanIrki { get; set; }
        public int HayvanTuruID { get; set; }

        public virtual HayvanTuru HayvanTuru { get; set; }
    }
}
