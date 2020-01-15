using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
   public class HayvanTuruMapping:EntityTypeConfiguration<HayvanTuru>
    {
        public HayvanTuruMapping()
        {
            this.HasKey(a => a.HayvanTuruID);
            this.Property(a => a.HayvanTur).IsRequired();
        

            this.HasMany(a => a.HayvanIrklari)
                .WithRequired(a => a.HayvanTuru)
                .HasForeignKey(a => a.HayvanTuruID);
        }
        
           
    }
}
