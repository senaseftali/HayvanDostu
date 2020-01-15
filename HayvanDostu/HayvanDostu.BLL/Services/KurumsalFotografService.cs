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
    public class KurumsalFotografService : IKurumsalFotografService
    {
        IKurumsalFotografDAL _kurumsalFotografRepo;
        public KurumsalFotografService(IKurumsalFotografDAL _fotoRepo)
        {
            _kurumsalFotografRepo = _fotoRepo;
        }
        public bool Add(KurumsalFotograf entity)
        {
            if (entity != null)
            {
                try
                {
                    _kurumsalFotografRepo.Add(entity);
                    return true;
                }
                catch
                {
                    throw new Exception("Beklenmedik bir hata oluştu.");
                }
            }
            else
            {
                throw new Exception("Boş mesaj eklenemez.");
            }
        }

        public bool DeleteByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public List<KurumsalFotograf> GetAll()
        {
            throw new NotImplementedException();
        }

        public KurumsalFotograf GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(KurumsalFotograf entity)
        {
            throw new NotImplementedException();
        }
    }
}
