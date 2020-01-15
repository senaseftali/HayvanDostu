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
    public class RolService:IRolService
    {
        IRolDAL _rolRepo;
        public RolService(IRolDAL repo)
        {
            _rolRepo = repo;
        }

        public bool Add(Rol entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetAll()
        {
            return _rolRepo.GetAll().ToList();
        }

        public Rol GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}
