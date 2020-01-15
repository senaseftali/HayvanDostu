using HayvanDostu.BLL.Interfaces;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace HayvanDostu.UI.WebMVC.Controllers
{
    public class AdminController : Controller
    {
        IAdminService _adminService;
        IUyeService _uyeService;
        public AdminController(IAdminService service,IUyeService uyeService)
        {
            _adminService = service;
            _uyeService = uyeService;
        }
        public ActionResult AdminAnaSayfa()
        {
            List<Uye> uyeler = _uyeService.GetAll();
            return View(uyeler);
        }
        public ActionResult AdminIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminIndex(Admin admin)
        {
            try
            {
                Admin yonetici = _adminService.GetByLogin(admin.KullaniciAdi, admin.Sifre);
                return RedirectToAction("AdminAnaSayfa", "Admin");
            }
            catch (Exception)
            {
                return View("Hatalı giriş");
            }
          
        }

        public ActionResult Talep()
        {
            List<Uye> onaylanmamisUyeler = _uyeService.GetByOnay(false);
            return View(onaylanmamisUyeler);
        }

        [HttpPost]
        public ActionResult Talep(Uye alici)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string mesaj = string.Empty;
                    var senderEmail = new MailAddress("hayvandostuapp@outlook.com", "");
                    var receivereEmail = new MailAddress(alici.Mail, "Receiver");
                    var password = 19061997+"Ilayda";
                    var konu = "Üyelik";
                    Uye uye = _uyeService.GetByMail(alici.Mail);
                    if (alici.Onay)
                    {
                        mesaj = "Üyelik talebiniz onaylanmıştır";                   
                        uye.Onay = true;
                        _uyeService.Update(uye);
                    }
                    else
                    {
                        mesaj = "Üyelik talebiniz reddedilmiştir.";
                        uye.Onay = false;
                    }
                    var body = mesaj;
                    var smtp = new SmtpClient
                    {
                        Host = "smtp-mail.outlook.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(senderEmail.Address, password)
                    };
                    using (var mess = new MailMessage(senderEmail, receivereEmail)
                    {
                        Subject = konu,
                        Body = body
                    })
                    {
                        smtp.Send(mess);
                    }
                    return Json("ok",JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception ex)
            {

                ViewBag.Error = ex.Message;
            }
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            _uyeService.DeleteByID(id);
            return Json("ok", JsonRequestBehavior.AllowGet);
        }
    }
}