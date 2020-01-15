using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HayvanDostu.Model
{
   public class KurumsalFotograf:IBaseEntity
    {
        public int KurumsalFotografID { get; set; }
        public int KurumsalUyeID { get; set; }
        public string Fotograf { get; set; }
        public virtual KurumsalUye KurumsalUye { get; set; }
    }
}
