using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Interfaces
{
    public interface IUyeService : IServiceBase<Uye>
    {
        Uye GetByLogin(string kullaniciadi, string sifre);
        List<Uye> GetByOnay(bool onay);
        Uye GetByMail(string mail);
    }
}
