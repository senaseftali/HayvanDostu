using HayvanDostu.BLL.Interfaces;
using HayvanDostu.Model;
using HayvanDostu.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.WebMVC.Controllers
{
    public class BireyselUyeController : Controller
    {
        IUyeService _uyeService;
        public BireyselUyeController(IUyeService service)
        {
            _uyeService = service;
        }
        public ActionResult UyeKayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UyeKayit(BireyselUyeVM model)
        {

            try
            {
                Uye uye = new Uye();
                uye.KullaniciAdi = model.KullaniciAdi;
                uye.Mail = model.Mail;
                uye.Sifre = model.Sifre;
                uye.RolID = 2;
                string url = string.Empty;
                if (model.Files.Count() > 0)
                {
                    foreach (var item in model.Files)
                    {
                        string fotografAdi = Path.GetFileName(item.FileName);
                        url = Path.Combine(Server.MapPath("~/Content/images/") + model.Ad.Trim().Replace(" ", string.Empty) + item.FileName);
                        item.SaveAs(url);
                    }
                }
                uye.BireyselUye = new BireyselUye
                {
                    Ad = model.Ad,
                    Soyad = model.Soyad,
                    //DogumTarihi = model.DogumTarihi,
                    //Cinsiyet = model.Cinsiyet,
                    //Telefon = model.Telefon,
                    //Adres = model.Adres,
                    //EvcilHayvanVarMi = model.EvcilHayvanVarMi,
                    //Adet = model.Adet,
                    //Fotograf = url
                };
                _uyeService.Add(uye);


            }
            catch
            {
                throw new Exception("Hatalı kayıt");
            }
            return View();
        }
    }
}