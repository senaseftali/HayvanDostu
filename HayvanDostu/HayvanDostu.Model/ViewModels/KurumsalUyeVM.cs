using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HayvanDostu.Model.ViewModels
{
 public  class KurumsalUyeVM:IBaseEntity
    {
        public int KurumsalUyeID { get; set; }
        public string KurumAdi { get; set; }
        public int HizmetBaslangicYili { get; set; }
        public string Adres { get; set; }
        public string KurumsalTelefon1 { get; set; }
        public string KurumsalTelefon2 { get; set; }
        public string VerdigiHizmetler { get; set; }
        public string HizmetVerdigiHayvanTurleri { get; set; }
        public string KurumTuru { get; set; }
        public List<HttpPostedFileBase> Files { get; set; }
        public int HizmetID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Mail { get; set; }

    }
}
