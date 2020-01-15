using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class MesajMapping : EntityTypeConfiguration<Mesaj>
    {
        public MesajMapping()
        {
            this.HasMany(a => a.MesajDetaylar)
                 .WithRequired(a => a.Mesaj)
                 .HasForeignKey(a => a.MesajID);
        }
    }
}
