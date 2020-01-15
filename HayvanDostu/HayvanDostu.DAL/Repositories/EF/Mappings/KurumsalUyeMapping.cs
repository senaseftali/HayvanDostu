using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class KurumsalUyeMapping: EntityTypeConfiguration<KurumsalUye>
    {
        public KurumsalUyeMapping()
        { 
            this.HasKey(a => a.KurumsalUyeID).Property(a => a.KurumsalUyeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(a => a.KurumAdi).HasMaxLength(100).IsRequired();
            
            this.HasMany(a => a.KurumsalFotograflar)
                .WithRequired(a => a.KurumsalUye)
                .HasForeignKey(a => a.KurumsalUyeID);

            this.HasMany(a => a.KonaklamaRezervasyonlar)
                .WithRequired(a => a.KurumsalUye)
                .HasForeignKey(a => a.KurumsalUyeID);

            this.HasMany(a => a.KurumsalTelefonlar)
                .WithRequired(a => a.KurumsalUye)
                .HasForeignKey(a => a.KurumsalUyeID);

            this.HasMany(a => a.Cizelgeler)
              .WithRequired(a => a.KurumsalUye)
              .HasForeignKey(a => a.KurumsalUyeID);


        }
    }
}
