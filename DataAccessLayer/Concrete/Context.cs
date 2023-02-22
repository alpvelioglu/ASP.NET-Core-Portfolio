using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//Veritabanına yansıtılan tablolar
//Proje katmanlar arasında birbirinden referans almalı
namespace DataAccessLayer.Concrete
{
    
    public class Context : IdentityDbContext<WriterUser,WriterRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6BJ4D89; database=CoreProjeDB ;integrated security=true");
        }

        public DbSet<About> Abouts { get; set; } //-s ile biten tablonun ismi
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Test1> Test1s { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<WriterMessage> WriterMessages { get; set; }




        // Context sınıfına ait yansıtılacak tablolar
        // Migration => CodeFirst yaklaşımı - Sınıflar, SQL'e tablo olarak yansıtılacak
        // PM Console context sınıfının bağlı olduğu katman seçiliyor bu da DataAccessLayer
        // add-migration mig1 yazdık konsola dosyalar classlar tablo olarak oluşturuldu sonra update-database diyerek bunu MSSQL üzerinde yazdırdık cool.

    }
}
