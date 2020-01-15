using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Cizelge:IBaseEntity
    {
        public int CizelgeID { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public bool DolulukDurumu { get; set; }
        public int KurumsalUyeID { get; set; }

        public KurumsalUye KurumsalUye { get; set; }
    }
}
