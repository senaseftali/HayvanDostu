using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HayvanDostu.Model.ViewModels
{
    public class BireyselUyeVM : IBaseEntity
    {
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
        public List<HttpPostedFileBase> Files { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }

    }
}
