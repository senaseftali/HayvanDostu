using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class MesajDetay : IBaseEntity
    {
        public MesajDetay()
        {
            GonderilmeTarihi = DateTime.Now;
        }
        public int MesajDetayID { get; set; }
        public int MesajID { get; set; }
        public string MesajIcerik { get; set; }
        public DateTime GonderilmeTarihi { get; set; }
        public int GonderenID { get; set; }
        public virtual Mesaj Mesaj { get; set; }
    }
}
