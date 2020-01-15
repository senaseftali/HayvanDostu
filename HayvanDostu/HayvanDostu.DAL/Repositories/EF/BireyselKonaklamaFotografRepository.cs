using HayvanDostu.DAL.Interfaces;
using HayvanDostu.Model;
using HayvanDostu.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF
{
    public class BireyselKonaklamaFotografRepository: EFRepository<BireyselKonaklamaFotograf, HayvanDostuDbContext>,IBireyselKonaklamaFotografDAL
    {
    }
}
