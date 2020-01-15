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
    public class KurumsalUyeService : IKurumsalUyeService
    {
        IKurumsalUyeDal _kurumsalUyeRepo;

        public KurumsalUyeService(IKurumsalUyeDal repo)
        {
            _kurumsalUyeRepo = repo;
        }
        public bool Add(KurumsalUye entity)
        {
            if (entity != null)
            {
                try
                {
                    _kurumsalUyeRepo.Add(entity);
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

        public List<KurumsalUye> GetAll()
        {
            return _kurumsalUyeRepo.GetAll().ToList();
        }

        public KurumsalUye GetByID(int entityID)
        {
            throw new NotImplementedException();
        }

        public bool Update(KurumsalUye entity)
        {
            if (entity != null)
            {
                try
                {
                    _kurumsalUyeRepo.Update(entity);
                    return true;
                }
                catch
                {
                    throw new Exception("Beklenmedik bir hata oluştu.");
                }
            }
            else
            {
                throw new Exception("Boş veri eklenemez.");
            }
        }
    }
}
