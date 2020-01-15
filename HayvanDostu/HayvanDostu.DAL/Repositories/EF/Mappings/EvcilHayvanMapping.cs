using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class EvcilHayvanMapping : EntityTypeConfiguration<EvcilHayvan>
    {
        public EvcilHayvanMapping()
        {
            this.HasKey(a => a.EvcilHayvanID);
            this.HasMany(a => a.HayvanFotograflar).WithRequired(a => a.EvcilHayvan).HasForeignKey(a => a.EvcilHayvanID);
            this.Property(a => a.Ad).HasColumnType("nvarchar").HasMaxLength(40).IsRequired();
            this.Property(a => a.Cinsiyet).HasColumnType("nchar").HasMaxLength(5).IsRequired();
            this.Property(a => a.Hikaye).HasColumnType("nvarchar").IsRequired();
        }
    }
}
