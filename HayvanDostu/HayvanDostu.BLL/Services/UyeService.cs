using HayvanDostu.BLL.Interfaces;
using HayvanDostu.DAL.Interfaces;
using HayvanDostu.Model;
using HayvanDostu.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Services
{
    public class UyeService:IUyeService
    {
        IUyeDAL _uyeRepo;
        public UyeService(IUyeDAL repo)
        {
            _uyeRepo = repo;
        }

        public bool Add(Uye entity)
        {
            UyeKontrol(entity);
            try
            {
                _uyeRepo.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        public List<Uye> GetByOnay(bool onay)
        {
           return _uyeRepo.GetAll(a => a.Onay == onay).ToList();
        }
        public bool DeleteByID(int entityID)
        {
            Uye uye = GetByID(entityID);
            _uyeRepo.Delete(uye);
            return true;
        }

        public List<Uye> GetAll()
        {
            return _uyeRepo.GetAll().ToList();
        }
        //bura yeni eklendi
        public Uye GetByMail(string mail)
        {
            return _uyeRepo.Get(a => a.Mail == mail);
        }
        public Uye GetByID(int entityID)
        {
            Uye uye= _uyeRepo.Get(a => a.UyeID == entityID);
            //if (uye==null)
            //{

            //}
            return uye;
        }

        public Uye GetByLogin(string kullaniciadi,string sifre)
        {
            Uye uye=_uyeRepo.Get(a => a.KullaniciAdi == kullaniciadi && a.Sifre == sifre);
            if (uye!=null)
            {
                if (uye.Onay)
                {
                    return uye;
                }
                else
                {
                    throw new Exception("Üyeliğiniz onaylanmadı");
                }
                
            }
            else
            {
                throw new Exception("Kullanıcı adı yada şifre uyuşmuyor.");
            }
        }

        public bool Update(Uye entity)
        {
            _uyeRepo.Update(entity);
            return true;
        }
        private void UyeKontrol(Uye entity)
        {
            if (string.IsNullOrWhiteSpace(entity.KullaniciAdi) || string.IsNullOrWhiteSpace(entity.Sifre) || string.IsNullOrWhiteSpace(entity.Mail))
            {
                throw new Exception("Lütfen gerekli alanları doldurunuz.");

            }
        }
    }
}
