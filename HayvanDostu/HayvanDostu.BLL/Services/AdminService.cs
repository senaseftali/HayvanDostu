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
    public class AdminService : IAdminService
    {
        IAdminDAL _adminRepo;

        public AdminService(IAdminDAL repo)
        {
            _adminRepo=repo;
        }
        public bool Add(Admin entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<Admin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Admin GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public Admin GetByLogin(string kullaniciadi, string sifre)
        {
            return _adminRepo.Get(a => a.KullaniciAdi == kullaniciadi && a.Sifre == sifre);
        }

        public bool Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
