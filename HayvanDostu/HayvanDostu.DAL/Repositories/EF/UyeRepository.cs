using HayvanDostu.Core.DataAccess.EntityFramework;
using HayvanDostu.DAL.Interfaces;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class UyeRepository: EFRepository<Uye, HayvanDostuDbContext>,IUyeDAL
    {
        
    }
}
