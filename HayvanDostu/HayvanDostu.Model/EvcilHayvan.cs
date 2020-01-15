using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class EvcilHayvan : IBaseEntity
    {
        public EvcilHayvan()
        {
            HayvanFotograflar = new HashSet<HayvanFotograf>();
        }
        public int EvcilHayvanID { get; set; }
        public string Ad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Hikaye { get; set; }
        public int HayvanIrkID { get; set; }
        public int BireyselUyeID { get; set; }
        public virtual ICollection<HayvanFotograf> HayvanFotograflar { get; set; }
        public virtual BireyselUye BireyselUye { get; set; }
        public virtual HayvanIrk HayvanIrk { get; set; }
    }
}
