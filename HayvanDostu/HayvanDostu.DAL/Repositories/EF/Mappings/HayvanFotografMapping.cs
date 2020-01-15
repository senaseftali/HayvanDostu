using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class HayvanFotografMapping : EntityTypeConfiguration<HayvanFotograf>
    {
        public HayvanFotografMapping()
        {
            HasKey(a => a.HayvanFotografID);
        }
    }
}
