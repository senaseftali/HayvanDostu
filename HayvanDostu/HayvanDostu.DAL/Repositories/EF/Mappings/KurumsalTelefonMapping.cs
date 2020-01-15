using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    class KurumsalTelefonMapping:EntityTypeConfiguration<KurumsalTelefon>
    {
        public KurumsalTelefonMapping()
        {
            this.HasKey(a => a.KurumsalTelefonID);
            this.Property(a => a.TelefonNo).IsRequired();
        }
    }
}
