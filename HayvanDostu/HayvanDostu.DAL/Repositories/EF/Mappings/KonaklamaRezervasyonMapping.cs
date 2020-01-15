using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class KonaklamaRezervasyonMapping:EntityTypeConfiguration<KonaklamaRezervasyon>
    {
        public KonaklamaRezervasyonMapping()
        {
            this.HasKey(a => a.KRezervasyonID);
            this.Property(a => a.BaslangicTarihi).IsRequired();
            this.Property(a => a.BitisTarihi).IsRequired();
            this.Property(a => a.Adet).IsRequired();

            this.HasMany(a => a.HayvanTuruleri)
               .WithRequired(a => a.KonaklamaRezervasyon)
               .HasForeignKey(a =>a.KRezarvasyonID);

            this.HasMany(a => a.Odemeler)
              .WithRequired(a => a.KonaklamaRezervasyon)
              .HasForeignKey(a => a.KRezervasyonID);

        }
       
    }
}
