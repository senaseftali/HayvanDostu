using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class BireyselKonaklamaMapping : EntityTypeConfiguration<BireyselKonaklama>
    {
        public BireyselKonaklamaMapping()
        {
            this.HasMany(a => a.BireyselKonaklamaFotograf)
                .WithRequired(a => a.BireyselKonaklama)
                .HasForeignKey(a => a.BireyselKonaklamaID);

            this.Property(a => a.Meslek).HasMaxLength(50).IsRequired();
            this.Property(a => a.BaktigiHayvanlar).HasMaxLength(200).IsRequired();
            this.Property(a => a.EvcilHayvanlar).HasMaxLength(200).IsRequired();
        }
    }
}
