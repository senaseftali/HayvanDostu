using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HayvanDostu.Model
{
    public class BireyselUye : IBaseEntity
    {
        public BireyselUye()
        {
            EvcilHayvanlar = new HashSet<EvcilHayvan>();
            BireyselKonaklama = new HashSet<BireyselKonaklama>();
        }
        public int BireyselUyeID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public bool EvcilHayvanVarMi { get; set; }
        public string Adet { get; set; }
        public string Fotograf { get; set; }
        public virtual Uye Uye { get; set; }
        public virtual ICollection<EvcilHayvan> EvcilHayvanlar { get; set; }
        public virtual ICollection<BireyselKonaklama> BireyselKonaklama { get; set; }
    }
}
