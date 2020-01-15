using HayvanDostu.BLL.Interfaces;
using HayvanDostu.BLL.Services;
using HayvanDostu.DAL.Interfaces;
using HayvanDostu.DAL.Repositories;
using HayvanDostu.DAL.Repositories.EF;
using HayvanDostu.DAL.Repositories.EF.Mappings;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.BLL.IOC.Ninject
{
    public class DALModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<IRezervasyonDAL>().To<RezervasyonRepository>(); // şeklinde eklenicek
            Bind<IUyeDAL>().To<UyeRepository>();
            Bind<IHizmetDAL>().To<HizmetRepository>();
            Bind<IAdminDAL>().To<AdminRepository>();
            Bind<IKurumsalUyeDal>().To<KurumsalUyeRepository>();
            Bind<IKurumsalFotografDAL>().To<KurumsalFotografRepository>();
            Bind<IKonaklamaRezervasyonDAL>().To<KonaklamaRezervasyonRepository>();
            Bind<IKurumsalTelefonDAL>().To<KurumsalTelefonRepository>();
            Bind<ICizelgeDAL>().To<CizelgeRepository>();
            Bind<IOdemeDAL>().To<OdemeRepository>();
            Bind<IHayvanIrkDAL>().To<HayvanIrkRepository>();
            Bind<IHayvanTuruDAL>().To<HayvanTuruRepository>();
            Bind<IMesajDAL>().To<MesajRepository>();
            Bind<IMesajDetayDAL>().To<MesajDetayRepository>();
            Bind<IRolDAL>().To<RolRepository>();
            Bind<IBireyselUyeDAL>().To<BireyselUyeRepository>();

        }
    }
    
}
