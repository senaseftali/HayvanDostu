using HayvanDostu.BLL.Interfaces;
using HayvanDostu.Model;
using HayvanDostu.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.WebMVC.Controllers
{
    public class HomeController : Controller
    {
        IUyeService _uyeService;
        IKurumsalUyeService _kurumsalService;
        public HomeController(IUyeService service,IKurumsalUyeService kurumsalService)
        {
            _uyeService = service;
            _kurumsalService = kurumsalService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
            return View();
        }

        public ActionResult AnlasmaliKurumlar()
        {
            List<KurumsalUye> anlasmaliKurumlar = _kurumsalService.GetAll();
            return View(anlasmaliKurumlar);
        }
        [HttpPost]
        public ActionResult Index(GirisVM uye)
        {
            try
            {
                Uye kullanici = _uyeService.GetByLogin(uye.KullaniciAdi, uye.Sifre);

                if (kullanici.Rol.RolAdi == "KurumsalUye")
                {
                    return RedirectToAction("Index", "KurumsalUye");
                }
                //else
                //{
                //    return RedirectToAction("Index", "KurumsalUye");
                //}


            }
            catch (Exception)
            {
                return View("Hatalı giriş");
            }
            return View();
        }
    }
}