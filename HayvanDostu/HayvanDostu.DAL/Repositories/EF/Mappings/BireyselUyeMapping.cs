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
    public class BireyselUyeMapping : EntityTypeConfiguration<BireyselUye>
    {
        public BireyselUyeMapping()
        {
            this.HasKey(a => a.BireyselUyeID).Property(a => a.BireyselUyeID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.HasMany(a => a.EvcilHayvanlar).WithRequired(a => a.BireyselUye).HasForeignKey(a => a.BireyselUyeID);
            this.HasMany(a => a.BireyselKonaklama).WithRequired(a => a.BireyselUye).HasForeignKey(a => a.BireyselUyeID);
            this.Property(a => a.Ad).HasMaxLength(50).IsRequired();
            this.Property(a => a.Soyad).HasMaxLength(50).IsRequired();
            this.Property(a => a.Adres).HasMaxLength(200).IsRequired();
            this.Property(a => a.Adet).HasMaxLength(200).IsRequired();
            this.Property(a => a.Cinsiyet).HasMaxLength(5).IsRequired();
        }

    }
}
