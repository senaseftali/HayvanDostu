using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class VeterinerMapping : EntityTypeConfiguration<Veteriner>
    {
        public VeterinerMapping()
        {
            HasKey(a => a.VeterinerID);
            this.Property(a => a.Ad).HasMaxLength(50).IsRequired();
            this.Property(a => a.Soyad).HasMaxLength(50).IsRequired();
            this.Property(a => a.Mail).HasMaxLength(100).IsRequired();
            this.Property(a => a.Telefon).HasMaxLength(11).IsRequired();
            this.Property(a => a.MezunOlduguOkul).HasMaxLength(100).IsRequired();
            this.Property(a => a.Fotograf).HasMaxLength(200).IsRequired();
        }
    }
}
