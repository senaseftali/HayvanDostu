using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class BireyselKonaklamaFotograf : IBaseEntity
    {
        public int BireyselKonaklamaFotografID { get; set; }
        //public int FotografID { get; set; }
        //public string FotografYolu { get; set; }
        public int BireyselKonaklamaID { get; set; }

        public virtual BireyselKonaklama BireyselKonaklama { get; set; }
    }
}
