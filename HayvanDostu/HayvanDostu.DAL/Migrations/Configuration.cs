namespace HayvanDostu.DAL.Migrations
{
    using HayvanDostu.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HayvanDostu.DAL.Repositories.EF.HayvanDostuDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(HayvanDostu.DAL.Repositories.EF.HayvanDostuDbContext context)
        {
            List<Rol> roller = new List<Rol>() { new Rol { RolAdi = "Admin" }, new Rol { RolAdi = "Bireysel" }, new Rol { RolAdi = "Kurumsal" } };
            context.Roller.AddRange(roller);
            List<Hizmet> hizmetler = new List<Hizmet>() { new Hizmet { HizmetAdi = "Bakım" }, new Hizmet { HizmetAdi = "Konaklama" }, new Hizmet { HizmetAdi = "Operasyon" } };
            context.Hizmetler.AddRange(hizmetler);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
