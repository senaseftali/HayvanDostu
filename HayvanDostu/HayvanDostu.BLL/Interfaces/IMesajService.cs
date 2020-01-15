using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Interfaces
{
    public interface IMesajService : IServiceBase<Mesaj>
    {
        Mesaj GetByMesajID(int uyeID,int aliciID);
    }
}
