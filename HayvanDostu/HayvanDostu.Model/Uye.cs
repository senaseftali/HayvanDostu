using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Uye:IBaseEntity
    {
        public Uye()
        {
            Mesajlar = new HashSet<Mesaj>();
            Onay = false;
        }
        public int UyeID { get; set; }
        public int RolID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }
        public bool Onay { get; set; }
        public virtual Rol Rol { get; set; }
        public virtual KurumsalUye KurumsalUye { get; set; }
        public virtual BireyselUye BireyselUye { get; set; }
        public ICollection<Mesaj> Mesajlar { get; set; }

    }
}
