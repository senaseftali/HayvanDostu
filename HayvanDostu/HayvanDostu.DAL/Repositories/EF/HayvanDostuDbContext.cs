using HayvanDostu.DAL.Repositories.EF.Mappings;
using HayvanDostu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HayvanDostu.DAL.Repositories.EF
{
    public class HayvanDostuDbContext : DbContext
    {
        public HayvanDostuDbContext() : base("Server=LAPTOP-U43TGSUE\\ILAYDA;Database=HayvanDostu97;Trusted_Connection=True")
        {

        }
        //public DbSet<Yorum> Yorum { get; set; } // bu şekilde eklenicek
        public DbSet<Admin> Adminler { get; set; }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<KurumsalUye> KurumsalUyeler { get; set; }
        public DbSet<KurumsalFotograf> KurumsalFotograflar { get; set; }
        public DbSet<Cizelge> Cizelgeler { get; set; }
        public DbSet<EvcilHayvan> EvcilHayvanlar { get; set; }
        public DbSet<HayvanTuru> HayvanTurleri { get; set; }
        public DbSet<KonaklamaRezervasyon> KonaklamaRezervasyonlar { get; set; }
        public DbSet<KurumsalTelefon> KurumsalTelefonlar { get; set; }
        public DbSet<HayvanIrk> HayvanIrklar { get; set; }
        public DbSet<Odeme> Odemeler { get; set; }
        public DbSet<Rol> Roller { get; set; }
        public DbSet<Mesaj> Mesajlar { get; set; }
        public DbSet<MesajDetay> MesajDetaylar { get; set; }
        public DbSet<BireyselUye> BireyselUyeler { get; set; }
        public DbSet<BireyselKonaklama> BireyselKonaklamalar { get; set; }
        public DbSet<BireyselKonaklamaFotograf> BireyselKonaklamaFotograflar { get; set; }
        public DbSet<Veteriner> Veterinerler { get; set; }
        public DbSet<HayvanFotograf> HayvanFotograflar { get; set; }
        public DbSet<Hizmet> Hizmetler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminMapping());
            modelBuilder.Configurations.Add(new HizmetMapping());
            modelBuilder.Configurations.Add(new CizelgeMapping());
            modelBuilder.Configurations.Add(new EvcilHayvanMapping());
            modelBuilder.Configurations.Add(new HayvanIrkMapping());
            modelBuilder.Configurations.Add(new HayvanTuruMapping());
            modelBuilder.Configurations.Add(new KonaklamaRezervasyonMapping());
            modelBuilder.Configurations.Add(new KurumsalFotografMapping());
            modelBuilder.Configurations.Add(new KurumsalUyeMapping());
            modelBuilder.Configurations.Add(new KurumsalTelefonMapping());
            modelBuilder.Configurations.Add(new OdemeMapping());
            modelBuilder.Configurations.Add(new RolMapping());
            modelBuilder.Configurations.Add(new UyeMapping());
            modelBuilder.Configurations.Add(new MesajMapping());
            modelBuilder.Configurations.Add(new MesajDetayMapping());
            modelBuilder.Configurations.Add(new BireyselKonaklamaFotografMapping());
            modelBuilder.Configurations.Add(new BireyselKonaklamaMapping());
            modelBuilder.Configurations.Add(new BireyselUyeMapping());
            modelBuilder.Configurations.Add(new HayvanFotografMapping());
            modelBuilder.Configurations.Add(new VeterinerMapping());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
