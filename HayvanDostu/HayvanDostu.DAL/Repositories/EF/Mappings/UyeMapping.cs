using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class UyeMapping : EntityTypeConfiguration<Uye>
    {
        public UyeMapping()
        {
            this.HasKey(a => a.UyeID)
                .HasOptional(a => a.KurumsalUye)
                .WithRequired(a => a.Uye);

            this.HasKey(a => a.UyeID)
                .HasOptional(a => a.BireyselUye)
                .WithRequired(a => a.Uye);

            this.Property(a => a.Sifre).IsRequired().HasMaxLength(8).IsFixedLength();

            this.Property(a => a.KullaniciAdi).IsRequired().HasMaxLength(15);

            this.HasMany(a => a.Mesajlar)
               .WithRequired(a => a.Uye)
               .HasForeignKey(a => a.UyeID);


            this.HasOptional(a => a.KurumsalUye).WithRequired(a => a.Uye);

        }
    }
}
