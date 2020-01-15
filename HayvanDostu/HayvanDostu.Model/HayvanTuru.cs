using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
 public class HayvanTuru:IBaseEntity
    {
        public HayvanTuru()
        {
            HayvanIrklari = new HashSet<HayvanIrk>();
        }
        public int HayvanTuruID { get; set; }
        public string HayvanTur { get; set; } //adını HayvanTuru idi ama classla aynı isim oldundan değiştirdim
        public int KRezarvasyonID { get; set; }
        public virtual  KonaklamaRezervasyon KonaklamaRezervasyon { get; set; }
        public virtual ICollection<HayvanIrk> HayvanIrklari { get; set; }
    }
}
