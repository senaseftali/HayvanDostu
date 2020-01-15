using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
  public class KonaklamaRezervasyon:IBaseEntity
    {
        public KonaklamaRezervasyon()
        {
            Odemeler = new HashSet<Odeme>();
            HayvanTuruleri = new HashSet<HayvanTuru>();
        }
        public int KRezervasyonID { get; set; }
        public int HizmetTipiID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int Adet { get; set; }
        public int HayvanTuruID { get; set; }
        public int KurumsalUyeID { get; set; }
        public int OdemeID { get; set; }


        public virtual KurumsalUye KurumsalUye { get; set; }

        public virtual  ICollection<Odeme> Odemeler { get; set; }
        public virtual ICollection<HayvanTuru> HayvanTuruleri { get; set; }


    }
}
