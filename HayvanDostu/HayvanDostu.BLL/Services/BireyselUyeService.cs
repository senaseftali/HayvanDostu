using HayvanDostu.BLL.Interfaces;
using HayvanDostu.DAL.Interfaces;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Services
{
    public class BireyselUyeService : IBireyselUyeService
    {
        IBireyselUyeDAL _bireyselUyeRepo;
        public BireyselUyeService(IBireyselUyeDAL repo)
        {
            _bireyselUyeRepo = repo;
        }

        public bool Add(BireyselUye entity)
        {
            _bireyselUyeRepo.Add(entity);
            return true;
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<BireyselUye> GetAll()
        {
            throw new NotImplementedException();
        }

        public BireyselUye GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(BireyselUye entity)
        {
            throw new NotImplementedException();
        }
    }
}
