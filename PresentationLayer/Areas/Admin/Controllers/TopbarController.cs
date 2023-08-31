using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Authorize]
    public class TopbarController : Controller
    {

        private readonly ITopbarManager _topbarManager;

        public TopbarController(ITopbarManager topbarManager)
        {
            _topbarManager = topbarManager;
        }

        public async Task<IActionResult> Index()
        {
            //   var listele=   _topbarManager.GetList();
            var listeledto = _topbarManager.GetTopbarListManager();
            return View(listeledto);
        }


        // GET: TopbarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: TopbarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Topbar topbar)
        {
            try
            {
                _topbarManager.Add(topbar);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception hata) // hata paemtredir o isimmi değiştirebilirsin, Exception:Bizlere fırlatılan ilgili tumm bilgileri olan bir ust turdur.
            //ust:yani butun hataları kkarşılayabilen bir türdür.
            //hata:bu paremetre uzerinden bizler alinan hataya dair bilgiler edinebilmekte ve gerekli loglama vs. gibi operasyonlar gerçekleştirebilmekteyiz.
            //(Exception hata) :bu paremtre catch bloguna yazilmak zorunda değildir. eğer ki tanimlama yapılırsa hataya dair bilgi alabiliriz.yok eger tanimlama yapilmazsa hata neticesinde
            //catch calışacak lakin bilgi alamayacağız..
            {
                Console.WriteLine("Mesaj : "+ hata.Message);
                return View();
            }
        }

        // GET: TopbarController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir=_topbarManager.GetByID(id);
            return View(verigetir);
        }

        // POST: TopbarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Topbar topbar)
        {
            try
            {
                _topbarManager.Update(topbar);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: TopbarController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _topbarManager.GetByID(id);
            return View(verigetir);
        }

        // POST: TopbarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Topbar topbar)
        {
            try
            {
                _topbarManager.Remove(topbar);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }
    }
}
