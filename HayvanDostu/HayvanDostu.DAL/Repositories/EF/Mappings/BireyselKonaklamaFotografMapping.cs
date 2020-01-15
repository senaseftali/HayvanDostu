using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class BireyselKonaklamaFotografMapping : EntityTypeConfiguration<BireyselKonaklamaFotograf>
    {
        public BireyselKonaklamaFotografMapping()
        {
            HasKey(a => a.BireyselKonaklamaFotografID);

        }
    }
}
