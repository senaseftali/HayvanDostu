using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class BireyselKonaklama:IBaseEntity
    {
        public BireyselKonaklama()
        {
            BireyselKonaklamaFotograf = new HashSet<BireyselKonaklamaFotograf>();
        }
        public int BireyselKonaklamaID { get; set; }
        public string Meslek { get; set; }
        public string EvcilHayvanlar { get; set; }
        public string BaktigiHayvanlar { get; set; }
        public int BireyselUyeID { get; set; }
        public string FiyatListesi { get; set; }
        //public int HizmetID { get; set; }
        public virtual ICollection<BireyselKonaklamaFotograf> BireyselKonaklamaFotograf { get; set; }
        public virtual BireyselUye BireyselUye { get; set; }
        //public virtual Hizmet Hizmet { get; set; } SENADAN GELECEK
    }
}
