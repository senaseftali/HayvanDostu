using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class HizmetMapping : EntityTypeConfiguration<Hizmet>
    {
        public HizmetMapping()
        {
            this.HasKey(a => a.HizmetID);
            this.Property(a => a.HizmetAdi).HasColumnType("nvarchar").HasMaxLength(20);
        }
    }
}
