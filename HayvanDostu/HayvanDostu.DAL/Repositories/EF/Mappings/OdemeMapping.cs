using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class OdemeMapping:EntityTypeConfiguration<Odeme>
    {
        public OdemeMapping()
        {
            this.HasKey(a => a.OdemeID);
            this.Property(a => a.KartNo).IsRequired();
            this.Property(a => a.GüvenlikKodu).IsRequired();
            this.Property(a => a.SonKullanmaTarihi).IsRequired();
            this.Property(a => a.KartSahibi).IsRequired();
            this.Property(a => a.OdemeSekli).IsRequired();

           
        }
    }
}
