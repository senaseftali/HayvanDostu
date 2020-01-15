using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class BakimTedaviRezervasyon:IBaseEntity
    {
        public int RezervasyonID { get; set; }
        public int HizmetTipiID { get; set; }
        public HizmetTipi HizmetTipi { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        //public int KurumsalUyeID { get; set; }
        //public int BireyselUyeID { get; set; }

        //public BireyselUye BireyselUye { get; set; }
        //public KurumsalUye KurumsalUye { get; set; }
    }
}
