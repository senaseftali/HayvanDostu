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
    public class KurumsalTelefonService : IKurumsalTelefonService
    {
        IKurumsalTelefonDAL _kurumsalTelefonRepo;
        public KurumsalTelefonService(IKurumsalTelefonDAL _telRepo)
        {
            _kurumsalTelefonRepo = _telRepo;
        }
        public bool Add(KurumsalTelefon entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<KurumsalTelefon> GetAll()
        {
            throw new NotImplementedException();
        }

        public KurumsalTelefon GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(KurumsalTelefon entity)
        {
            throw new NotImplementedException();
        }
    }
}
