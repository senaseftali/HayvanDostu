using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class CizelgeMapping:EntityTypeConfiguration<Cizelge>
    {
        public CizelgeMapping()
        {
            this.HasKey(a => a.CizelgeID);
            this.Property(a => a.DolulukDurumu).IsRequired();
            this.Property(a => a.Tarih).IsRequired();
            this.Property(a => a.Saat).IsRequired();
        }
    }
}
