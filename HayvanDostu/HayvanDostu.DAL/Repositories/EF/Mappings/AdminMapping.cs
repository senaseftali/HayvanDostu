using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF
{
    class AdminMapping:EntityTypeConfiguration<Admin>
    {
        public AdminMapping()
        {
            this.HasKey(a => a.AdminID);
            this.Property(a => a.KullaniciAdi).IsRequired();
            
           
        }
    }
}
