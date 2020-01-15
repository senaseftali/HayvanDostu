using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class HayvanFotograf : IBaseEntity
    {
        public int HayvanFotografID { get; set; }
        public int EvcilHayvanID { get; set; }
        public string FotografYolu { get; set; }
        public virtual EvcilHayvan EvcilHayvan { get; set; }

    }
}
