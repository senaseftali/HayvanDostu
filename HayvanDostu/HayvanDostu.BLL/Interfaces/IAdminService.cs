using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Interfaces
{
    public interface IAdminService:IServiceBase<Admin>
    {
        Admin GetByLogin(string kullaniciadi, string sifre);
    }
}
