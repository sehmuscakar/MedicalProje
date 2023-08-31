using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Entities
{
    public class AppUser:IdentityUser<int> //// IdentityUser: veritabanındaki  aspnetusers tablosuyla ilişkiye koyacaz ve ordaki tabloya eklmek istediğimniz verileri ekleyecez ;IdentityUser =aspnetusers tablosu gibi düşün
    //<int> bunu toblodaki id primary si string ti bunu int ecevirdik bu yuzden ve gerekli diğer tablolarıda çevir role me filan daha sağlıklı
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
     //   public int ConfirmCode { get; set; }//onay kodu,mail doğrulama işlemi için kullanılacak ,migration olduğunda migration da nullable yi true yaptık ayrıntı

    public List<Topbar> Topbars { get; set; }
    public List<WhyUs> WhyUs { get; set; }
    public List<Business> Businesses { get; set; }
    public List<Count> Counts { get; set; }
    public List<Service> Services { get; set; }
    public List<Branch> Branches { get; set; }
    public List<Doctor> Doctors { get; set; }
    public List<Footer> Footers { get; set; }
    public List<Question> Questions { get; set; }
    public List<Gallery> Galleries { get; set; }

    }
}
