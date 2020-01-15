using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HayvanDostu.Model
{
   public class KurumsalUye: IBaseEntity
    {
        public KurumsalUye()
        {
            Cizelgeler = new HashSet<Cizelge>();
            KurumsalFotograflar = new HashSet<KurumsalFotograf>();
            KurumsalTelefonlar = new HashSet<KurumsalTelefon>();
            KonaklamaRezervasyonlar = new HashSet<KonaklamaRezervasyon>();
        }
        public int KurumsalUyeID { get; set; }
        public string KurumAdi { get; set; }
        public int HizmetBaslangicYili { get; set; }
        public int HizmetID { get; set; }//bu baglı değil sorunlu düzeltilecek
        public virtual Hizmet Hizmet { get; set; }
        public virtual Uye Uye { get; set; }
        public virtual ICollection<Cizelge> Cizelgeler { get; set; }
        public virtual ICollection<KurumsalFotograf> KurumsalFotograflar { get; set; }
        public virtual ICollection<KurumsalTelefon> KurumsalTelefonlar { get; set; }
        public virtual ICollection<KonaklamaRezervasyon> KonaklamaRezervasyonlar { get; set; }

    }
}
