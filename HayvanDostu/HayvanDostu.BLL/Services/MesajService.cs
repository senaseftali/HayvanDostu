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
    public class MesajService : IMesajService
    {
        IMesajDAL _mesajRepo;
        public MesajService(IMesajDAL repo)
        {
            _mesajRepo = repo;
        }


        public bool Add(Mesaj entity)
        {
            if (entity != null)
            {
                try
                {
                    _mesajRepo.Add(entity);
                    return true;
                }
                catch (Exception)
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
                Mesaj mesaj = GetByID(entityID);
                try
                {
                    _mesajRepo.Delete(mesaj);
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

        public List<Mesaj> GetAll()
        {
            try
            {
                return _mesajRepo.GetAll().ToList();
            }
            catch
            {
                throw new Exception("Beklenmedik bir hata oluştu");
            }
        }

        public Mesaj GetByID(int entityID)
        {
            if (entityID != 0)
            {
                try
                {
                    return _mesajRepo.Get(a => a.MesajID == entityID);
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

        public Mesaj GetByMesajID(int uyeID,int aliciID)
        {
            return _mesajRepo.Get(a => (a.UyeID == uyeID && a.AliciID == aliciID) || (a.UyeID == aliciID && a.AliciID == uyeID));
        }

        public bool Update(Mesaj entity)
        {
            if (entity != null)
            {
                try
                {
                    _mesajRepo.Update(entity);
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
