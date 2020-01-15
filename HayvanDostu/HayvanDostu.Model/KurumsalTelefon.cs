using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
   public class KurumsalTelefon:IBaseEntity
    {
        public int KurumsalTelefonID { get; set; }
        public int KurumsalUyeID { get; set; }
        public string TelefonNo { get; set; }

        public virtual KurumsalUye KurumsalUye { get; set; }
    }
}
