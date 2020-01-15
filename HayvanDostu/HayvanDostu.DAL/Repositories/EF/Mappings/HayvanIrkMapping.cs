using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class HayvanIrkMapping : EntityTypeConfiguration<HayvanIrk>
    {
        public HayvanIrkMapping()
        {
            this.HasKey(a => a.HayvanIrkID);
            this.Property(a => a.HayvanIrki).IsRequired();

       
        }
    }
}
