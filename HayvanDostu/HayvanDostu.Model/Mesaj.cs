using HayvanDostu.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.Model
{
    public class Mesaj : IBaseEntity
    {
        public Mesaj()
        {
            MesajDetaylar = new HashSet<MesajDetay>();
            UyeMesajDurumu = false;
            AliciMesajDurumu = false;
            SonGuncelleme = DateTime.Now;
        }
        public int MesajID { get; set; }
        public int UyeID { get; set; }
        public int AliciID { get; set; }
        public bool UyeMesajDurumu { get; set; }
        public bool AliciMesajDurumu { get; set; }
        public DateTime SonGuncelleme { get; set; }
        public int SonMesajGonderenID { get; set; }
        public virtual Uye Uye { get; set; }
        public virtual ICollection<MesajDetay> MesajDetaylar { get; set; }
    }
}
