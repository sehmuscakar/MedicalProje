using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CountController : Controller
    {

        private readonly ICountManager _countManager;

        public CountController(ICountManager countManager)
        {
            _countManager = countManager;
        }

        // GET: CountController
        public async Task<IActionResult> Index()
        {
            // var listele = _countManager.GetList();
            var listeledto = _countManager.GetCountListManager();
            return View(listeledto);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: FooterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Count count)
        {
            try
            {
                _countManager.Add(count);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: CountController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var verigetir=_countManager.GetByID(id);
            return View(verigetir);
        }

        // POST: CountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Count count)
        {
            try
            {
                _countManager.Update(count);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception hata)
            {
                Console.WriteLine("Mesaj : " + hata.Message);
                return View();
            }
        }

        // GET: CountController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var verigetir = _countManager.GetByID(id);
            return View(verigetir);
        }

        // POST: CountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Count count)
        {
            try
            {
                _countManager.Remove(count);
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
