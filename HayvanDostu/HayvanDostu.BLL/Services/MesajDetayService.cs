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
    public class MesajDetayService:IMesajDetayService
    {
        IMesajDetayDAL _mesajDetayRepo;
        public MesajDetayService(IMesajDetayDAL repo)
        {
            _mesajDetayRepo = repo;
        }

        public bool Add(MesajDetay entity)
        {
            if (entity != null)
            {
                try
                {
                    _mesajDetayRepo.Add(entity);
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
            if (entityID != 0)
            {
                MesajDetay mesajDetay = GetByID(entityID);
                try
                {
                    _mesajDetayRepo.Delete(mesajDetay);
                    return true;
                }
                catch
                {
                    throw new Exception("Beklenmedik bir hata oluştu.");
                }
            }
            else
            {
                throw new Exception("Mesaj Silinemedi.Lütfen geçerli bir ID değeri girin.");
            }
        }

        public List<MesajDetay> GetAll()
        {
            try
            {
                return _mesajDetayRepo.GetAll().ToList();
            }
            catch
            {
                throw new Exception("Beklenmedik bir hata oluştu");
            }
        }

        public MesajDetay GetByID(int entityID)
        {
            if (entityID != 0)
            {
                try
                {
                    return _mesajDetayRepo.Get(a => a.MesajDetayID == entityID);
                }
                catch
                {
                    throw new Exception("Beklenmedik bir hata oluştu.");
                }
            }
            else
            {
                throw new Exception("Mesaj Silinemedi.Lütfen geçerli bir ID değeri girin.");
            }
        }

        public bool Update(MesajDetay entity)
        {
            if (entity != null)
            {
                try
                {
                    _mesajDetayRepo.Update(entity);
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
