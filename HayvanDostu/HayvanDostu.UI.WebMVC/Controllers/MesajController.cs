using HayvanDostu.BLL.Interfaces;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.WebMVC.Controllers
{
    public class MesajController : Controller
    {
        // GET: Mesaj
        IMesajService _mesajService;
        IMesajDetayService _mesajDetayService;
        IUyeService _uyeService;

        public MesajController(IMesajService mesajService,IMesajDetayService mesajDetayService,IUyeService uyeService)
        {
            _mesajDetayService = mesajDetayService;
            _mesajService = mesajService;
            _uyeService = uyeService;
        }
        public ActionResult YeniIleti()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniIleti(int UyeID = 6)
        {
            string email = Request.Form["email"];
            string mesaj = Request.Form["mesaj"];
            Uye uye = _uyeService.GetByMail(email);
            Mesaj msj = new Mesaj();
            msj.AliciID = uye.UyeID;
            msj.UyeID = UyeID;
            msj.SonMesajGonderenID = UyeID;
            Mesaj varMi = _mesajService.GetByMesajID(UyeID, uye.UyeID);
            if (varMi==null) 
            {
                msj.MesajDetaylar.Add(new MesajDetay
                {
                    MesajID = msj.MesajID,
                    GonderenID = UyeID,
                    MesajIcerik = mesaj
                });
                _mesajService.Add(msj);
            }
            else
            {
                //msj.UyeID = UyeID;
                //msj.AliciID = uye.UyeID;

                //_mesajService.Update(msj);
                _mesajDetayService.Add(new MesajDetay 
                { 
                GonderenID=UyeID,
                MesajIcerik = mesaj,
                MesajID=varMi.MesajID
                });

            }


            return View();
        }
        public ActionResult GelenKutusu()
        {
            return View();
        }
        public ActionResult GidenKutusu()
        {
            return View();
        }
    }
}