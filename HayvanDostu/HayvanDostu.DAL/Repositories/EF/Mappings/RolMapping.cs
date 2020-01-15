using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class RolMapping:EntityTypeConfiguration<Rol>
    {
        public RolMapping()
        {
            this.HasKey(a => a.RolID);

            this.HasMany(a => a.Uyeler)
                .WithRequired(a => a.Rol)
                .HasForeignKey(a => a.RolID);
        }
    }
}
