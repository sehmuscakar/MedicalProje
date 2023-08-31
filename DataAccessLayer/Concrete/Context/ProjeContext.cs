using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
    // biz ıdentity imiz büylece özeleştirdik appuser ,approle ve int olarak genel primary olarak stringten int e cevirdik user ile ilgili biz özel olarak hangi tabloları yapmışsak buraya da eklememiz lazım 
    //,int> bu int primary i leri strigten int e cevirecek genel olarak diğer paremeetrelede özeleştirilmiş olanlar primary meselesi özeleştirilmiş tablolarda da yapıldı yapılmış olamsı lazım dikkat et
    // identityde özeleştirilmiş olan sınıflarımızı dbset olarak eklememize gerek yok migration ve update yapman yeterli ama ilgili migrationları veya genel migration kalsörünü ve db yi silip baştan yaparsan daha sağlıklı olur 

    // sonra db yi katrol et özeleşrtirilmiş tabloları diyagram oluştur ilşkilerde bi sıkıntı yoksa sıkıntı yoktur devam et.

    // Microsoft.AspNetCore.Identity.EntityFrameworkCore // identity ekleyebilmen için bu kütüphane mutlaka ekli olamsı lazım ilgili yere
  //  Microsoft.Extensions.Identity.Core bunun da ekli olması lazım
    public class ProjeContext : IdentityDbContext<AppUser,AppRole,int> //DbContext
    {
        public DbSet<Topbar> Topbars { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Branch> branches { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Gallery> Galleries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// overide on yaz gelir
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=MedaicalProje; integrated security=true; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)//fluent api ile ilgili ,bunu yapmazsan appuser da kim ekledi kısmında ıd yerine name gelmez bunu yapman lazım
        {

            builder.Entity<Topbar>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Topbars).HasForeignKey(x => x.AppUserId);//verilerimiz gelmesi için db ye erişim oradan geleceği için bunu yapmalıyız
            });
            builder.Entity<WhyUs>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.WhyUs).HasForeignKey(x => x.AppUserId);
            });
            builder.Entity<Business>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Businesses).HasForeignKey(x => x.AppUserId);//appuserıd fazladan geliyor sebebi bu olabilir ,Data Annotation ve Fluent API Kullanımı: Bazı durumlarda, veritabanı şemasını ayarlamak için Data Annotation veya Fluent API kullanabilirsiniz. Eğer AppuserId sütunu bu şekilde yapılandırıldıysa, EF Core bu yapılandırmayı takip eder.
            });

            builder.Entity<Count>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Counts).HasForeignKey(x => x.AppUserId);
            });
            builder.Entity<Branch>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Branches).HasForeignKey(x => x.AppUserId);
            });
            builder.Entity<Doctor>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Doctors).HasForeignKey(x => x.AppUserId);
            });
    
            builder.Entity<Service>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Services).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Footer>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Footers).HasForeignKey(x => x.AppUserId);
            });

            builder.Entity<Gallery>(entity =>
            {

                entity.HasOne(x => x.AppUser).WithMany(x => x.Galleries).HasForeignKey(x => x.AppUserId);
            });

            base.OnModelCreating(builder);
        }
    }
}
