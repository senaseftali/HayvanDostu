using HayvanDostu.Model;
using HayvanDostu.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HayvanDostu.DAL.Interfaces;

namespace HayvanDostu.DAL.Repositories.EF.Mappings
{
    public class AdminRepository:EFRepository<Admin,HayvanDostuDbContext>,IAdminDAL
    {
    }
}
