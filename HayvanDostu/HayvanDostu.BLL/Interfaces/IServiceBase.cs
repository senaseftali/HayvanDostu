using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.Interfaces
{
    public interface IServiceBase<T>
        where T:IBaseEntity
    {
        bool Add(T entity);
        bool Update(T entity);
        bool DeleteByID(int entityID);
        T GetByID(int entityID);
        List<T> GetAll();
    }
}
