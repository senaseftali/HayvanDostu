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
    public class HizmetService:IHizmetService
    {
        IHizmetDAL _hizmetRepo;
        public HizmetService(IHizmetDAL repo)
        {
            _hizmetRepo = repo;
        }

        public bool Add(Hizmet entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<Hizmet> GetAll()
        {
            return _hizmetRepo.GetAll().ToList();
        }

        public Hizmet GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Hizmet entity)
        {
            throw new NotImplementedException();
        }
    }
}
