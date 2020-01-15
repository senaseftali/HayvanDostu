using HayvanDostu.Core.DataAccess.EntityFramework;
using HayvanDostu.DAL.Repositories.EF;
using HayvanDostu.Model;
using HayvanDostu.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories
{
   public class KurumsalUyeRepository:EFRepository<KurumsalUye,HayvanDostuDbContext>,IKurumsalUyeDal
    {
     
    }
}
