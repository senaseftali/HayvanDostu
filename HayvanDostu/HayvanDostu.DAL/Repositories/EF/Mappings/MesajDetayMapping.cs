using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class MesajDetayMapping : EntityTypeConfiguration<MesajDetay>
    {
        public MesajDetayMapping()
        {
            this.Property(a => a.MesajIcerik).HasColumnType("nvarchar");
        }
    }
}
