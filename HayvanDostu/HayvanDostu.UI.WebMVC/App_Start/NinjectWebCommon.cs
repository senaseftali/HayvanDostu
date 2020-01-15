[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HayvanDostu.UI.WebMVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(HayvanDostu.UI.WebMVC.App_Start.NinjectWebCommon), "Stop")]

namespace HayvanDostu.UI.WebMVC.App_Start
{
    using System;
    using System.Web;
    using HayvanDostu.BLL.Interfaces;
    using HayvanDostu.BLL.IOC.Ninject;
    using HayvanDostu.BLL.Services;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUyeService>().To<UyeService>();
            kernel.Bind<IAdminService>().To<AdminService>();
            kernel.Bind<IKurumsalUyeService>().To<KurumsalUyeService>();
            kernel.Bind<IMesajService>().To<MesajService>();
            kernel.Bind<IMesajDetayService>().To<MesajDetayService>();
            kernel.Bind<IKurumsalFotografService>().To<KurumsalFotografService>();
            kernel.Bind<IKurumsalTelefonService>().To<KurumsalTelefonService>();
            kernel.Bind<IRolService>().To<RolService>();
            kernel.Bind<IHizmetService>().To<HizmetService>();
            kernel.Bind<IBireyselUyeService>().To<BireyselUyeService>();
            kernel.Load<DALModule>();
        }        
    }
}
