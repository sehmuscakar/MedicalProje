using DataAccessLayer.Dtos.AdminDtos;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [AllowAnonymous] // 
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager; // bu sınıf ıdentity içinde bulunan hazır bir sınıf 

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SignUp()
        {
            return View();
        }

        [HttpPost]
      public async Task<IActionResult> SignUp(AppUserRegisterDto appUserRegisterDto) //AppUserRegisterDto bu modeli kullanma amacımız sadece gerekli propertyleri kullanmak için
        {

            if (ModelState.IsValid)
            {

                AppUser appUser = new AppUser() // atamalarımızı yaptık, AppUser bu sınıftaki olanları hepsinin atamalrını bi şekilde yapman lazım ,özeliştirilmiş olan entityler yani diğerleri ıdentityd zaten
                {
                    UserName = appUserRegisterDto.UserName,
                    Name = appUserRegisterDto.Name,
                    LastName = appUserRegisterDto.LastName,
                    Email = appUserRegisterDto.Email,
                    About = "ddd",
                    Adress = "aaa",
                    Phone = "bbb",                
                    ImageUrl = "ccc",
                    // burda entityin kendi tablolarındaki propertylerinde bazıları nul gecçe veya geçmeme onlara dikat et senin yazdığın validasyonlarınla ilgisi yok onları kontrol etmen lazım 

                };

                var result = await _userManager.CreateAsync(appUser, appUserRegisterDto.Password);//eklemeleri yapacak ilgili olanları ve result değişkenine atama yapacak
                if (result.Succeeded)
                {

                    return RedirectToAction("Signİn", "Login");
                }
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> MyAccount() // profil bilgilerini getirme işlemi yapacaz 
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name); // burda sisteme login olan otantike olan kişin bilgilerini name göre bulacak ve getirecek yani username göre diyeebiliriz
            AppUserEditDto appUserEditDto = new AppUserEditDto();// bu bi nevi view model olarak hareket edecek
            appUserEditDto.Name = values.Name;
            appUserEditDto.LastName = values.LastName;
            appUserEditDto.Phone = values.Phone;
            appUserEditDto.Email = values.Email;
            appUserEditDto.About = values.About;
            appUserEditDto.Adress = values.Adress;
            appUserEditDto.ImageUrl = values.ImageUrl;
            return View(appUserEditDto);
           
        }

        [HttpPost]
        public async Task<IActionResult> MyAccount(AppUserEditDto appUserEditDto) // güncelleme işini yapacaz 
        {
            if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)//ikişfrede aynısı ise 
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);//username göre önceliğğinde hareket edecek

                user.Phone = appUserEditDto.Phone;
                user.LastName = appUserEditDto.LastName;
                user.About = appUserEditDto.About;
                user.Adress = appUserEditDto.Adress;
                user.Name = appUserEditDto.Name;
                user.ImageUrl = "test";
                user.Email = appUserEditDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password);//şifremizi gene gizli bi şekide veri tabanımıza göndereecez bu kod sayesinde 
                var resut = await _userManager.UpdateAsync(user);
                if (resut.Succeeded) // eğer güncelleme başarılı ise loginin indexine yönlendir
                {
                    return RedirectToAction("Signİn", "Login");
                }

            }
            return View();
        }
    }
}
