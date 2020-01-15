using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Rol:IBaseEntity
    {
        public Rol()
        {
            Adminler = new HashSet<Admin>();
            Uyeler = new HashSet<Uye>();
        }
        public int RolID { get; set; }
        public string RolAdi { get; set; }
        public virtual ICollection<Admin> Adminler { get; set; }
        public virtual ICollection<Uye> Uyeler { get; set; }
    }
}
