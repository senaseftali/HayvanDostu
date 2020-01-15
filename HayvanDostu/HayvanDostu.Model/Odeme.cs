using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Odeme:IBaseEntity
    {
        public int OdemeID { get; set; }
        public string KartNo { get; set; }
        public string GüvenlikKodu { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public string KartSahibi { get; set; }
        public int OdemeSekli { get; set; }
        public int KRezervasyonID { get; set; }

        public virtual KonaklamaRezervasyon KonaklamaRezervasyon { get; set; }

    }

}