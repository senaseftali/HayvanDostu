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
    public class KurumsalUyeController : Controller
    {
        IUyeService _uyeService;
        IRolService _rolService;
        IHizmetService _hizmetService;
        public KurumsalUyeController(IUyeService uyeService, IRolService rolService, IHizmetService hizmetService)
        {
            _uyeService = uyeService;
            _rolService = rolService;
            _hizmetService = hizmetService;
        }

        public ActionResult Index()
        {
            getir();
            return View();
        }
        void getir(){
            List<SelectListItem> hizmetListe = new List<SelectListItem>();
            foreach (Hizmet item in _hizmetService.GetAll())
            {
                hizmetListe.Add(new SelectListItem
                {
                    Text = item.HizmetAdi,
                    Value = item.HizmetID.ToString()
                });
            }

            ViewBag.HizmetListe = hizmetListe;
        }

        [HttpPost]
        public ActionResult Index(KurumsalUyeVM model)
        {
            try
            {
                Uye uye = new Uye();
                uye.KullaniciAdi = model.KullaniciAdi;
                uye.Mail = model.Mail;
                uye.Sifre = model.Sifre;
                uye.RolID = 3;
                uye.KurumsalUye = new KurumsalUye
                {
                    KurumAdi = model.KurumAdi,
                    HizmetBaslangicYili = model.HizmetBaslangicYili,
                    HizmetID = Convert.ToInt32(model.HizmetID)
                };
                uye.KurumsalUye.KurumsalTelefonlar.Add(new KurumsalTelefon { TelefonNo = model.KurumsalTelefon1 });
                if (model.KurumsalTelefon2 != null)
                {
                    uye.KurumsalUye.KurumsalTelefonlar.Add(new KurumsalTelefon { TelefonNo = model.KurumsalTelefon2 });
                }

                if (model.Files.Count() > 0)
                {
                    foreach (var item in model.Files)
                    {
                        string fotografAdi = Path.GetFileName(item.FileName);
                        string url = Path.Combine(Server.MapPath("~/Content/images/") + model.KurumAdi.Trim().Replace(" ", string.Empty) + item.FileName);
                        item.SaveAs(url);
                        uye.KurumsalUye.KurumsalFotograflar.Add(new KurumsalFotograf { Fotograf = url });
                    }
                }
                bool uyeBil = _uyeService.Add(uye);
                getir();
                return View();
            }
            catch (Exception)
            {
                return View("Hatalı giriş");
            }

        }

    }
}