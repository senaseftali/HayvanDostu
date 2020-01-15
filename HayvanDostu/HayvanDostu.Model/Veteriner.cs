using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Veteriner : IBaseEntity
    {
        public int VeterinerID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Fotograf { get; set; }
        public string MezunOlduguOkul { get; set; }
        //public int KurumsalUyeID { get; set; }
        //public virtual KurumsalUye KurumsalUye { get; set; } 
    }
}
